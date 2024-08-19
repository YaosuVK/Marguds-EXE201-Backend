﻿// <auto-generated />
using System;
using Marguds_DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Marguds_DataAccessLayer.Migrations
{
    [DbContext(typeof(MargudsContext))]
    partial class MargudsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Marguds_BussinessObject.Model.Account", b =>
                {
                    b.Property<string>("AccountID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
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

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountID");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Brand", b =>
                {
                    b.Property<int>("BrandID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrandID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrandID");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Cart", b =>
                {
                    b.Property<int>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartID"));

                    b.Property<string>("AccountID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CartID");

                    b.HasIndex("AccountID");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.CartItem", b =>
                {
                    b.Property<int>("CartItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartItemID"));

                    b.Property<int>("CartID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartItemID");

                    b.HasIndex("CartID");

                    b.HasIndex("ProductID");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Fees", b =>
                {
                    b.Property<int>("FeesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeesID"));

                    b.Property<double>("FixedFee")
                        .HasColumnType("float");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

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
                    b.Property<int>("FeeConfigID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeeConfigID"));

                    b.Property<decimal>("FixedFeePercentage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PaymentFeePercentage")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("FeeConfigID");

                    b.ToTable("FeesConfigurations");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.ImageProduct", b =>
                {
                    b.Property<int>("ImageProductsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageProductsID"));

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("ImageProductsID");

                    b.HasIndex("ProductID");

                    b.ToTable("ImageProducts");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<string>("AccountID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("FeesID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<int?>("ReportID")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<string>("transactionID")
                        .HasColumnType("nvarchar(450)");

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
                    b.Property<int>("OrderDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetailID"));

                    b.Property<int?>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

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
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"));

                    b.Property<string>("AccountID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("BrandID")
                        .HasColumnType("int");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

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
                    b.Property<int>("RatingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RatingID"));

                    b.Property<string>("AccountID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

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
                    b.Property<int>("ReportID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReportID"));

                    b.Property<string>("AccountID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

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
                    b.Property<int>("ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewID"));

                    b.Property<string>("AccountID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ReviewID");

                    b.HasIndex("AccountID");

                    b.HasIndex("ProductID");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Marguds_BussinessObject.Model.Transaction", b =>
                {
                    b.Property<string>("ResponseId")
                        .HasColumnType("nvarchar(450)");

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
