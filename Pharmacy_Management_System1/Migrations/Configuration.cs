namespace Pharmacy_Management_System1.Migrations
{
    using Pharmacy_Management_System1.Model;
    using ShopMigrations;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShopDbContext context)
        {
            
            // seeding admin user
            // testing remaining
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
        }
    }
}
