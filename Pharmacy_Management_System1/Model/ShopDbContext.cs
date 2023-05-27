using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Pharmacy_Management_System1.Model;
//using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data.Entity.ModelConfiguration.Conventions;

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
    }
}