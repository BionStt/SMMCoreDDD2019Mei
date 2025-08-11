using Microsoft.AspNetCore.ResponseCompression;
using SumberMas2015.SalesMarketing;
using Microsoft.OpenApi.Models;
using System.Reflection;
using SumberMas2015.Inventory;
using SumberMas2015.BlazorIdentity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using SumberMas2015.Blazor.Server.Middleware;
using SumberMas2015.Blazor.Server.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSalesMarketing(builder.Configuration.GetConnectionString("BlazorIdentityConnection"));
builder.Services.AddInventory(builder.Configuration.GetConnectionString("InventoryConnection"));
builder.Services.AddBlazorIdentity(builder.Configuration.GetConnectionString("InventoryConnection"));

// Add API Versioning
builder.Services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ReportApiVersions = true;
    options.ApiVersionReader = ApiVersionReader.Combine(
        new UrlSegmentApiVersionReader(),
        new HeaderApiVersionReader("X-API-Version"),
        new MediaTypeApiVersionReader("X-API-Version"));
});

builder.Services.AddVersionedApiExplorer(options =>
{
    options.GroupNameFormat = "'v'VVV";
    options.SubstituteApiVersionInUrl = true;
});

// Add Rate Limiting
builder.Services.AddRateLimiter(options =>
{
    options.GlobalLimiter = PartitionedRateLimiter.Create<HttpContext, string>(context =>
        RateLimitPartition.GetFixedWindowLimiter("GlobalLimiter",
            partition => new FixedWindowRateLimiterOptions
            {
                AutoReplenishment = true,
                PermitLimit = 100,
                Window = TimeSpan.FromMinutes(1)
            }));

    options.AddPolicy("AuthenticatedUser", context =>
        RateLimitPartition.GetFixedWindowLimiter("AuthenticatedUser",
            partition => new FixedWindowRateLimiterOptions
            {
                AutoReplenishment = true,
                PermitLimit = 200,
                Window = TimeSpan.FromMinutes(1)
            }));
});

// Add CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder => builder
            .WithOrigins("https://localhost:5001", "https://localhost:5002")
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials());
});

// Add Health Checks
builder.Services.AddHealthChecks()
    .AddCheck("self", () => Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult.Healthy());

// Add Global Exception Handler
builder.Services.AddTransient<GlobalExceptionHandler>();

// Configure API Behavior
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = false;
});

// Add Controllers with proper configuration
builder.Services.AddControllers(options =>
{
    options.Filters.Add<ValidateModelStateFilter>();
})
.ConfigureApiBehaviorOptions(options =>
{
    options.InvalidModelStateResponseFactory = actionContext =>
    {
        var errors = actionContext.ModelState
            .Where(e => e.Value.Errors.Count > 0)
            .Select(e => $"{e.Key}: {string.Join(", ", e.Value.Errors.Select(e => e.ErrorMessage))}")
            .ToList();

        var response = ApiResponse<object>.ErrorResult("Validation failed", errors);
        response.RequestId = actionContext.HttpContext.TraceIdentifier;

        return new BadRequestObjectResult(response);
    };
});


// Configure Swagger with API Versioning
builder.Services.AddSwaggerGen(c => {
    // Get the provider from the service collection
    var provider = builder.Services.BuildServiceProvider()
        .GetRequiredService<IApiVersionDescriptionProvider>();

    foreach (var description in provider.ApiVersionDescriptions)
    {
        c.SwaggerDoc(description.GroupName, new OpenApiInfo { 
            Title = "Sumber Mas Enterprise API",
            Version = description.ApiVersion.ToString(),
            Description = "Enterprise-grade API for Sumber Mas Business Management System",
            TermsOfService = new Uri("https://sutantogasali.com/terms"),
            Contact = new OpenApiContact
            {
                Name = "Sutanto Gasali",
                Email = "sutanto.gasali@gmail.com",
                Url = new Uri("https://sutantogasali.com"),
            },
            License = new OpenApiLicense
            {
                Name = "Sumber Mas Enterprise License",
                Url = new Uri("https://sutantogasali.com/license"),        
            }
         });
    }

    // Add API Key Authorization
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });

    // Include XML comments
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    if (File.Exists(xmlPath))
    {
        c.IncludeXmlComments(xmlPath);
    }

    // Add operation filters for versioning
    c.DocInclusionPredicate((name, api) => true);
    c.TagActionsBy(api => new[] { api.GroupName ?? "v1" });
    c.DocInclusionPredicate((docName, apiDesc) => true);
});

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

// Add middleware in correct order
app.UseHttpsRedirection();

// Add CORS (must be before authentication)
app.UseCors("AllowSpecificOrigin");

// Add Request/Response Logging (early in pipeline)
app.UseMiddleware<RequestResponseLoggingMiddleware>();

// Add Global Exception Handler (early in pipeline)
app.UseMiddleware<GlobalExceptionHandler>();

// Add Rate Limiting (after logging but before auth)
app.UseRateLimiter();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// Map Health Checks
app.MapHealthChecks("/health", new Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckOptions
{
    ResponseWriter = async (context, report) =>
    {
        context.Response.ContentType = "application/json";
        var response = new
        {
            status = report.Status.ToString(),
            checks = report.Entries.Select(x => new
            {
                name = x.Key,
                status = x.Value.Status.ToString(),
                description = x.Value.Description
            })
        };
        await context.Response.WriteAsJsonAsync(response);
    }
});

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

// Configure Swagger UI with versioning
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();
    
    foreach (var description in provider.ApiVersionDescriptions)
    {
        c.SwaggerEndpoint(
            $"/swagger/{description.GroupName}/swagger.json",
            $"Sumber Mas API {description.GroupName.ToUpperInvariant()}");
    }
    
    c.RoutePrefix = "api-docs";
    c.DocumentTitle = "Sumber Mas Enterprise API Documentation";
});


app.Run();

