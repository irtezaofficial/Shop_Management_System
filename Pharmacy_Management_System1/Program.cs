using Microsoft.AspNetCore.Hosting;
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

namespace Pharmacy_Management_System1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //var builder = WebHostBuilder.CreateBuilder(args);
            //var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");

            //app.Run();
            //var host = CreateHostBuilder(args).Build();
            //host.Run();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
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
            IUserService a = new UserService(db);
            UserController b = new UserController(a);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TestForm(b));
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
    }
}
