using CascadingParameterInDetail;
using CascadingParameterInDetail.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddCascadingValue<RootLevelSampleModel>(sp => new()
{
    Message = "Hello Blazor School!"
});
builder.Services.AddCascadingValue<RootLevelSampleModel>("Variant2", sp => new()
{
    Message = "Hello Blazor School! (Variant2)"
});

builder.Services.AddCascadingValue(sp =>
{
    var value = new RootLevelUpdatingModel()
    {
        Message = "Hello Blazor School! (With Notifying)",
    };

    value.Source = new CascadingValueSource<RootLevelUpdatingModel>(value, false);

    return value.Source;
});

await builder.Build().RunAsync();
