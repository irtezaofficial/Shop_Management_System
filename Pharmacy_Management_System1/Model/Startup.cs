using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Pharmacy_Management_System1.Model;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<ITransientService, TransientService>();

        // Additional service registrations
        // ...
    }

    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
        // Configure middleware, routing, etc.
        // ...
    }
}
