using _40_LifeTimeManagement_BlazorClient.Contracts;
using _40_LifeTimeManagement_BlazorClient.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace _40_LifeTimeManagement_BlazorClient
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddTransient<ITransient, LifeCycle>();
            builder.Services.AddScoped<IScoped, LifeCycle>();
            builder.Services.AddSingleton<ISingleton, LifeCycle>();

            await builder.Build().RunAsync();
        }
    }
}
