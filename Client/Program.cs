using Epsa.Client;
using Epsa.Client.Services.Client;
using Epsa.Client.Services.Users;
using Epsa.Client.Shared.Services;
using Epsa.Shared.Models;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

/// <summary>
/// Adding Scopes for context
/// </summary>

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IHttpService, HttpService>();
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<ILocalStorageService, LocalStorageService>();
builder.Services.AddScoped<UserViewModel>();
builder.Services.AddScoped<CobranzaDataViewModel>();
builder.Services.AddScoped<ClientsViewModel>();
builder.Services.AddScoped<FcPaymentsViewModel>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


await builder.Build().RunAsync();
