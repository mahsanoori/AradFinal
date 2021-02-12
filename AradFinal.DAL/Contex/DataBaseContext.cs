using System;
using System.Collections.Generic;
using System.Text;
using AradFinal.DAL.Entities;
using AradFinal.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace AradFinal.DataAccessLayer.Contex
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Factor> Factors { get; set; }
        public DbSet<FactorDetail> FactorDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductSeen> ProductSeens { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<UserIP> UserIPs { get; set; }
        public DbSet<Social> socials { get; set; }
    }
}
