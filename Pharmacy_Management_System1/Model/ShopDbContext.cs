using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Pharmacy_Management_System1.Model;
//using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace ShopMigrations
{
    public class ShopDbContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
    }
}