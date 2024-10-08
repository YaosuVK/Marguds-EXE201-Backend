﻿// <auto-generated />
using System;
using Marguds_DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Marguds_DataAccessLayer.Migrations
{
    [DbContext(typeof(MargudsContext))]
    [Migration("20240901145101_InitialSetup")]
    partial class InitialSetup
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Marguds_BussinessObject.Model.Account", b =>
                {
                    b.Property<Guid>("AccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("AccountID");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Brand", b =>
                {
                    b.Property<Guid>("BrandID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrandID");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Cart", b =>
                {
                    b.Property<Guid>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CartID");

                    b.HasIndex("AccountID");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.CartItem", b =>
                {
                    b.Property<Guid>("CartItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CartID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartItemID");

                    b.HasIndex("CartID");

                    b.HasIndex("ProductID");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Category", b =>
                {
                    b.Property<Guid>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Fees", b =>
                {
                    b.Property<Guid>("FeesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("FixedFee")
                        .HasColumnType("float");

                    b.Property<Guid>("OrderID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("PaymentFee")
                        .HasColumnType("float");

                    b.Property<double>("TotalFee")
                        .HasColumnType("float");

                    b.HasKey("FeesID");

                    b.HasIndex("OrderID")
                        .IsUnique();

                    b.ToTable("Fees");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.FeesConfiguration", b =>
                {
                    b.Property<Guid>("FeeConfigID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("FixedFeePercentage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PaymentFeePercentage")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("FeeConfigID");

                    b.ToTable("FeesConfigurations");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.ImageProduct", b =>
                {
                    b.Property<Guid>("ImageProductsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ImageProductsID");

                    b.HasIndex("ProductID");

                    b.ToTable("ImageProducts");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Order", b =>
                {
                    b.Property<Guid>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FeesID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<Guid?>("ReportID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<Guid?>("transactionID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OrderID");

                    b.HasIndex("AccountID");

                    b.HasIndex("ReportID")
                        .IsUnique()
                        .HasFilter("[ReportID] IS NOT NULL");

                    b.HasIndex("transactionID")
                        .IsUnique()
                        .HasFilter("[transactionID] IS NOT NULL");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.OrderDetail", b =>
                {
                    b.Property<Guid>("OrderDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("OrderID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.Property<double>("promotionPrice")
                        .HasColumnType("float");

                    b.Property<double>("unitPrice")
                        .HasColumnType("float");

                    b.HasKey("OrderDetailID");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrdersDetail");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Product", b =>
                {
                    b.Property<Guid>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BrandID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InventoryQuantity")
                        .HasColumnType("int");

                    b.Property<double>("PurchasePrice")
                        .HasColumnType("float");

                    b.Property<double>("Size")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("ProductID");

                    b.HasIndex("AccountID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Rating", b =>
                {
                    b.Property<Guid>("RatingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProductID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("RatingID");

                    b.HasIndex("AccountID");

                    b.HasIndex("ProductID");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Report", b =>
                {
                    b.Property<Guid>("ReportID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OrderID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ReportText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResponseText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ReportID");

                    b.HasIndex("AccountID");

                    b.HasIndex("ProductID");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Review", b =>
                {
                    b.Property<Guid>("ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProductID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ReviewID");

                    b.HasIndex("AccountID");

                    b.HasIndex("ProductID");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Transaction", b =>
                {
                    b.Property<Guid>("ResponseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("Amount")
                        .HasColumnType("bigint");

                    b.Property<string>("BankCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankTranNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PayDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResponseCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecureHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TmnCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TxnRef")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResponseId");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Cart", b =>
                {
                    b.HasOne("Marguds_BussinessObject.Model.Account", "Accounts")
                        .WithMany("Carts")
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.CartItem", b =>
                {
                    b.HasOne("Marguds_BussinessObject.Model.Cart", "Cart")
                        .WithMany("CartItem")
                        .HasForeignKey("CartID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Marguds_BussinessObject.Model.Product", "Product")
                        .WithMany("CartItems")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Fees", b =>
                {
                    b.HasOne("Marguds_BussinessObject.Model.Order", "Order")
                        .WithOne("Fees")
                        .HasForeignKey("Marguds_BussinessObject.Model.Fees", "OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.ImageProduct", b =>
                {
                    b.HasOne("Marguds_BussinessObject.Model.Product", "Products")
                        .WithMany("ImageProducts")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Order", b =>
                {
                    b.HasOne("Marguds_BussinessObject.Model.Account", "Account")
                        .WithMany("Orders")
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Marguds_BussinessObject.Model.Report", "Report")
                        .WithOne("Order")
                        .HasForeignKey("Marguds_BussinessObject.Model.Order", "ReportID");

                    b.HasOne("Marguds_BussinessObject.Model.Transaction", "Transaction")
                        .WithOne("Order")
                        .HasForeignKey("Marguds_BussinessObject.Model.Order", "transactionID");

                    b.Navigation("Account");

                    b.Navigation("Report");

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.OrderDetail", b =>
                {
                    b.HasOne("Marguds_BussinessObject.Model.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID");

                    b.HasOne("Marguds_BussinessObject.Model.Product", "Products")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Product", b =>
                {
                    b.HasOne("Marguds_BussinessObject.Model.Account", "Account")
                        .WithMany("Products")
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Marguds_BussinessObject.Model.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Marguds_BussinessObject.Model.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Rating", b =>
                {
                    b.HasOne("Marguds_BussinessObject.Model.Account", "Account")
                        .WithMany("Ratings")
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Marguds_BussinessObject.Model.Product", "Product")
                        .WithMany("Ratings")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Report", b =>
                {
                    b.HasOne("Marguds_BussinessObject.Model.Account", "Account")
                        .WithMany("Reports")
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Marguds_BussinessObject.Model.Product", "Products")
                        .WithMany("Reports")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Review", b =>
                {
                    b.HasOne("Marguds_BussinessObject.Model.Account", "Account")
                        .WithMany("Reviews")
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Marguds_BussinessObject.Model.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Account", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Orders");

                    b.Navigation("Products");

                    b.Navigation("Ratings");

                    b.Navigation("Reports");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Cart", b =>
                {
                    b.Navigation("CartItem");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Order", b =>
                {
                    b.Navigation("Fees")
                        .IsRequired();

                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Product", b =>
                {
                    b.Navigation("CartItems");

                    b.Navigation("ImageProducts");

                    b.Navigation("OrderDetails");

                    b.Navigation("Ratings");

                    b.Navigation("Reports");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Report", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Transaction", b =>
                {
                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}
