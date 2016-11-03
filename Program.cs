using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ConsoleApplication
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(
                context => {
                    return context.Response.WriteAsync("Hello scott on the web");
                    }
            );
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();

            host.Run();

            Console.WriteLine("Hello World!");

            string name = Console.ReadLine();

            Console.WriteLine("Hello {0}", name);
            Console.WriteLine($"Hello {name}");
        }
    }
}
