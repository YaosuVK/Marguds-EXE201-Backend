using Marguds_BussinessObject.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marguds_DataAccessLayer
{
    public class MargudsContext : DbContext
    {
        public MargudsContext(): base() { }
        public MargudsContext(DbContextOptions<MargudsContext> options) 
            : base(options) 
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // one one transaction with order
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Transaction>()
                .HasOne(e => e.Order)
            .WithOne(e => e.Transaction)
                .HasForeignKey<Order>(e => e.transactionID);
            // one one order with report
            modelBuilder.Entity<Report>()
                .HasOne(e => e.Order)
                .WithOne(e => e.Report)
                .HasForeignKey<Order>(e => e.ReportID);
            // one many cartItem with cart
            modelBuilder.Entity<Cart>()
                .HasMany(c => c.CartItem)
                .WithOne(ci => ci.Cart)
                .HasForeignKey(ci => ci.CartID)
                .OnDelete(DeleteBehavior.Cascade);
            // one many cartIteam with product
            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Product)
                .WithMany(p => p.CartItems)
                .HasForeignKey(ci => ci.ProductID)
                .OnDelete(DeleteBehavior.NoAction);
            // one many rating with account
            modelBuilder.Entity<Rating>()
                .HasOne(r => r.Account)
                .WithMany(a => a.Ratings)
                .HasForeignKey(r => r.AccountID)
                .OnDelete(DeleteBehavior.NoAction);
            // one many rating with product
            modelBuilder.Entity<Rating>()
                .HasOne(r => r.Product)
                .WithMany(p => p.Ratings)
                .HasForeignKey(r => r.ProductID)
                .OnDelete(DeleteBehavior.NoAction);
            // one many report with product
            modelBuilder.Entity<Report>()
                .HasOne(r => r.Products)
                .WithMany(p => p.Reports)
                .HasForeignKey(r => r.ProductID)
                .OnDelete(DeleteBehavior.NoAction);
            // one many report with account
            modelBuilder.Entity<Report>()
                .HasOne(r => r.Account)
                .WithMany(a => a.Reports)
                .HasForeignKey(r => r.AccountID)
                .OnDelete(DeleteBehavior.NoAction);
            // one many review with product
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Product)
                .WithMany(p => p.Reviews)
                .HasForeignKey(r => r.ProductID)
                .OnDelete(DeleteBehavior.NoAction);
            // one many review with account
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Account)
                .WithMany(a => a.Reviews)
                .HasForeignKey(r => r.AccountID)
                .OnDelete(DeleteBehavior.NoAction);
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Fees> Fees { get; set; }
        public DbSet<FeesConfiguration> FeesConfigurations { get; set; }
        public DbSet<ImageProduct> ImageProducts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrdersDetail { get; set;}
        public DbSet<Product> Products { get;set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Transaction> Transaction { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        //    optionsBuilder.UseLazyLoadingProxies();
        }
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", true, true)
                        .Build();
            var strConn = config["ConnectionStrings:DefaultConnection"];

            return strConn;
        }
    }
}
