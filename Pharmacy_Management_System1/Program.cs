﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualBasic.Logging;
using Pharmacy_Management_System1.Forms;
using Pharmacy_Management_System1.Model;
using Pharmacy_Management_System1.Model.Order;
using Pharmacy_Management_System1.Model.Product;
using Pharmacy_Management_System1.Model.User;
using ShopMigrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;

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

            // initializing service with interface
            IUserService service = new UserService(db);
            IProductService service1 = new ProductService(db); 
            IOrderService service2 = new OrderService(db);


            // passing interface service to controller param
            UserController userController = new UserController(service);
            ProductController productController = new ProductController(service1);
            OrderController orderController = new OrderController(service2);

            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(userController, productController, orderController));
        }
    }
}
