// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebshopAPI.Context;

#nullable disable

namespace WebshopAPI.Migrations
{
    [DbContext(typeof(WebshopContext))]
    [Migration("20220617095354_ListProductsChange")]
    partial class ListProductsChange
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebshopAPI.Models.Cart", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Username");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("WebshopAPI.Models.News", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("ArticleText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("WebshopAPI.Models.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long?>("ProductsId")
                        .HasColumnType("bigint");

                    b.Property<double?>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ProductsId");

                    b.HasIndex("Username");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("WebshopAPI.Models.Products", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime?>("AvailableSince")
                        .HasColumnType("datetime2");

                    b.Property<long?>("CartId")
                        .HasColumnType("bigint");

                    b.Property<bool?>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Property1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property16")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property17")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property18")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property19")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property20")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property21")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property22")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property23")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property24")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property25")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("WishlistId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("WishlistId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WebshopAPI.Models.Users", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HouseNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zipcode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Username");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebshopAPI.Models.Wishlist", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<bool?>("PriceAlert")
                        .HasColumnType("bit");

                    b.Property<double?>("PriceAlertAmount")
                        .HasColumnType("float");

                    b.Property<string>("PriceAlertProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Username");

                    b.ToTable("Wishlist");
                });

            modelBuilder.Entity("WebshopAPI.Models.Cart", b =>
                {
                    b.HasOne("WebshopAPI.Models.Users", "User")
                        .WithMany()
                        .HasForeignKey("Username")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebshopAPI.Models.Order", b =>
                {
                    b.HasOne("WebshopAPI.Models.Products", "Products")
                        .WithMany()
                        .HasForeignKey("ProductsId");

                    b.HasOne("WebshopAPI.Models.Users", "User")
                        .WithMany()
                        .HasForeignKey("Username");

                    b.Navigation("Products");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebshopAPI.Models.Products", b =>
                {
                    b.HasOne("WebshopAPI.Models.Cart", null)
                        .WithMany("Products")
                        .HasForeignKey("CartId");

                    b.HasOne("WebshopAPI.Models.Wishlist", null)
                        .WithMany("Products")
                        .HasForeignKey("WishlistId");
                });

            modelBuilder.Entity("WebshopAPI.Models.Wishlist", b =>
                {
                    b.HasOne("WebshopAPI.Models.Users", "User")
                        .WithMany()
                        .HasForeignKey("Username");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebshopAPI.Models.Cart", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("WebshopAPI.Models.Wishlist", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
