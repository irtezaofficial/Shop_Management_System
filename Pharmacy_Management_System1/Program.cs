using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualBasic.Logging;
using Pharmacy_Management_System1.Model;
using Pharmacy_Management_System1.Model.User;
using ShopMigrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pharmacy_Management_System1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            //// Create a service collection and register the transient service
            //var services = new ServiceCollection();
            //services.AddTransient<ITransientService, TransientService>();

            //// Build the service provider
            //using (var serviceProvider = services.BuildServiceProvider())
            //{
            //    // Create and run your main Windows Form, passing the service provider to it
            //    using (var mainForm = new TestForm(serviceProvider))
            //    {
            //        Application.Run(mainForm);
            //    }
            //}





            //var builder = WebHostBuilder.CreateBuilder(args);
            //var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");

            //app.Run();
            //var host = CreateHostBuilder(args).Build();
            //host.Run();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            //CreateHostBuilder(args).Build().Run();






            //var host = new WebHostBuilder()
            //.UseKestrel() // Optional: Specify the web server
            //.UseStartup<Startup>() // Specify the Startup class
            //.Build();


            //host.Run();








            //    var host = Host.CreateDefaultBuilder(args)
            //// Configuration and additional setup if needed
            //.ConfigureWebHostDefaults(webBuilder =>
            //{
            //    webBuilder.UseStartup<Startup>();
            //})
            //.Build();

            //    CreateHostBuilder(args).Build().Run();
            //    var host = Host.CreateDefaultBuilder(args)
            //    .ConfigureServices((hostContext, services) =>
            //    {
            //        services.AddControllers();
            //        services.AddTransient<ITransientService, TransientService>();
            //    })
            //    .Build();

            // Get an instance of ServiceLifetimeReporter if needed
            //var serviceLifetimeReporter = host.Services.GetRequiredService<ServiceLifetimeReporter>();

            //var services = new ServiceCollection();
            //services.AddTransient(typeof(ITransientService));
            //var serviceProvider = services.BuildServiceProvider();








            var db = new ShopDbContext();
            if (!db.Users.Any())
            {
                db.Users.Add(new UserEntity
                {
                    Id = 1,
                    Email = "admin@shop.com",
                    Username = "shopadmin",
                    Name = "Admin",
                    Password = "123"
                });
                db.SaveChanges();
            }
            IUserService service = new UserService(db);
            UserController controller = new UserController(service);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TestForm(controller));










            //var host = Host.CreateDefaultBuilder(args)
            //.ConfigureWebHost(webBuilder =>
            //{
            //    webBuilder.UseStartup<Startup>();
            //})
            //.Build();

            //host.Run();
        }
        //var db = new ShopDbContext();
        //if (!db.Users.Any())
        //{
        //    db.Users.Add(new UserEntity
        //    {
        //        Id = 1,
        //        Email = "admin@shop.com",
        //        Username = "shopadmin",
        //        Name = "Admin",
        //        Password = "123"
        //    });
        //    db.SaveChanges();
        //}
        //IUserService a = new UserService(db);
        //UserController b = new UserController(a);
        //Application.EnableVisualStyles();
        //Application.SetCompatibleTextRenderingDefault(false);
        //Application.Run(new TestForm(b));




        //using (var db = new ShopDbContext())
        //{
        //    if (!db.Users.Any())
        //    {
        //        db.Users.Add(new UserEntity
        //        {
        //            Id = 1,
        //            Email = "admin@shop.com",
        //            Username = "shopadmin",
        //            Name = "Admin",
        //            Password = "123"
        //        });
        //        db.SaveChanges();
        //    }
        //    IUserService a = new UserService(db);
        //    UserController b = new UserController(a);
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new TestForm(b));
        //}

        //Console.WriteLine("Press any key to exit...");
        //Console.ReadKey();
    }

        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //Host.CreateDefaultBuilder(args)
        //    .ConfigureWebHostDefaults(webBuilder =>
        //    {
        //        webBuilder.UseStartup<Startup>();
        //    });
    //}
}
