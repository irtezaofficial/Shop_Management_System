using Microsoft.VisualBasic.Logging;
using Pharmacy_Management_System1.Model;
using ShopMigrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            using (var db = new ShopDbContext())
            {
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
            }

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new TestForm());

            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();
        }
    }
}
