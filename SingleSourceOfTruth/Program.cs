using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SingleSourceOfTruth;
using SingleSourceOfTruth.Components.CascadingParameterRootLevel;
using SingleSourceOfTruth.Components.TransferService;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddCascadingValue(sp =>
{
    CascadingParameterSharedData value = new();
    value.Source = new(value, false);

    return value.Source;
});
builder.Services.AddScoped<BlazorSchoolTransferService>();

await builder.Build().RunAsync();
