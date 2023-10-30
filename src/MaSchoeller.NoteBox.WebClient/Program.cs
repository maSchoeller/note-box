using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.FluentUI.AspNetCore.Components;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddFluentUIComponents(options =>
{
    options.HostingModel = BlazorHostingModel.WebAssembly;
});
await builder.Build().RunAsync();
