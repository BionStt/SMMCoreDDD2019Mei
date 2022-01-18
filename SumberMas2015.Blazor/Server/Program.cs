using Microsoft.AspNetCore.ResponseCompression;
using SumberMas2015.SalesMarketing;
using Microsoft.OpenApi.Models;
using System.Reflection;
using SumberMas2015.Inventory;
using SumberMas2015.BlazorIdentity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSalesMarketing(builder.Configuration.GetConnectionString("BlazorIdentityConnection"));
builder.Services.AddInventory(builder.Configuration.GetConnectionString("InventoryConnection"));
builder.Services.AddBlazorIdentity(builder.Configuration.GetConnectionString("InventoryConnection"));


builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo { 
        Title = "Sumber Mas Blazor API",
        Version = "v1",
        Description = "An API To perform Sumber Mas Blazor Operations",
        TermsOfService = new Uri("https://example.con/terms"),
        Contact = new OpenApiContact
        {
            Name = "Sutanto Gasali",
            Email = "sutanto.gasali@gmail.com",
            Url = new Uri("https://sutantogasali.com"),
        },
        License = new OpenApiLicense
        {

            Name = "Employee API xxx",
            Url = new Uri("https://example.com/license"),        
        }
     });

    // set the comments path for the swagger JSON and UI
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);

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
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

// Enable middleware to serve generated Swagger as a JSON endpoint.
app.UseSwagger();

// Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
// specifying the Swagger JSON endpoint.
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
});


app.Run();
