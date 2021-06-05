using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using BlazorAPIClient.DataServices;

namespace BlazorAPIClient
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Blazor client startet");
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            // builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["rest_api_base_url"]) });
            
            // uses REST Api
            builder.Services.AddHttpClient<IMyDataService,RestAlbumDataService>
            (
                x=>x.BaseAddress = new Uri(builder.Configuration["rest_api_base_url"])
            );
            
            // uses GraphQL Api
            builder.Services.AddHttpClient<IPostDataService,GraphQLPostDataService>
            (
                x=>x.BaseAddress = new Uri(builder.Configuration["graph_api_base_url"])
            );

            await builder.Build().RunAsync();
        }
    }
}
