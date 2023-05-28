using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Pharmacy_Management_System1.Model;
//using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data.Entity.ModelConfiguration.Conventions;
using Pharmacy_Management_System1.Model.Rider;
using Pharmacy_Management_System1.Model.Product;
using Pharmacy_Management_System1.Model.Payment;
using Pharmacy_Management_System1.Model.Order;
using Pharmacy_Management_System1.Model.Order.OrderDetail;

namespace ShopMigrations
{
    public class ShopDbContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity<User>().ToTable("Users");
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        //    base.OnModelCreating(modelBuilder);


        //}
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<RiderEntity> Rider { get; set; }
        public DbSet<ProductEntity> Product { get; set; }
        public DbSet<PaymentDetails> PaymentDetails { get; set; }
        public DbSet<OrderEntity> Order { get; set; }
        public DbSet<OrderDetailEntity> OrderDetail { get; set; }
    }
}