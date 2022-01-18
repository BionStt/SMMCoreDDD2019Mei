using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SumberMas2015.Blazor.Client;
using SumberMas2015.Blazor.Client.ServiceApplication.DataKonsumen.Contracts;
using SumberMas2015.Blazor.Client.ServiceApplication.DataKonsumen.Implementation;
using SumberMas2015.Blazor.Client.ServiceApplication.Identity.Contracts;
using SumberMas2015.Blazor.Client.ServiceApplication.Identity.Implementations;
using SumberMas2015.Blazor.Client.ServiceApplication.MasterBarang.Contracts;
using SumberMas2015.Blazor.Client.ServiceApplication.MasterBarang.Implementation;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<IdentityAuthenticationStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>(s => s.GetRequiredService<IdentityAuthenticationStateProvider>());
builder.Services.AddScoped<IAuthorizeApi, AuthorizeApi>();


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddTransient<IDataKonsumenService, DataKonsumenService>();
builder.Services.AddTransient<IMasterBarangService, MasterBarangService>();




await builder.Build().RunAsync();
