﻿// <auto-generated />
using System;
using CAPSTONE_Swift_Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CAPSTONE_Swift_Server.Migrations
{
    [DbContext(typeof(SwiftDbContext))]
    partial class SwiftDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CAPSTONE_Swift_Server.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CustomerUid")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("customer_uid");

                    b.HasKey("Id")
                        .HasName("pk_carts");

                    b.ToTable("carts", (string)null);
                });

            modelBuilder.Entity("CAPSTONE_Swift_Server.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("country");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("customer_email");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer")
                        .HasColumnName("customer_id");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("customer_name");

                    b.Property<long>("CustomerPhoneNumber")
                        .HasColumnType("bigint")
                        .HasColumnName("customer_phone_number");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_time");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("integer")
                        .HasColumnName("order_status_id");

                    b.Property<int>("PaymentId")
                        .HasColumnType("integer")
                        .HasColumnName("payment_id");

                    b.Property<double>("Revenue")
                        .HasColumnType("double precision")
                        .HasColumnName("revenue");

                    b.Property<string>("ShippingMethod")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("shipping_method");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("state");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("street_address");

                    b.Property<string>("TownCity")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("town_city");

                    b.Property<int>("Zipcode")
                        .HasColumnType("integer")
                        .HasColumnName("zipcode");

                    b.HasKey("Id")
                        .HasName("pk_orders");

                    b.ToTable("orders", (string)null);
                });

            modelBuilder.Entity("CAPSTONE_Swift_Server.Models.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Name")
                        .HasColumnType("integer")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_order_statuses");

                    b.ToTable("order_statuses", (string)null);
                });

            modelBuilder.Entity("CAPSTONE_Swift_Server.Models.PaymentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_payment_types");

                    b.ToTable("payment_types", (string)null);
                });

            modelBuilder.Entity("CAPSTONE_Swift_Server.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AdminId")
                        .HasColumnType("integer")
                        .HasColumnName("admin_id");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("category");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("ImageUrl1")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("image_url1");

                    b.Property<string>("ImageUrl2")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("image_url2");

                    b.Property<string>("ImageUrl3")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("image_url3");

                    b.Property<double>("Length")
                        .HasColumnType("double precision")
                        .HasColumnName("length");

                    b.Property<double>("Price")
                        .HasColumnType("double precision")
                        .HasColumnName("price");

                    b.Property<string>("SkateSpots")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("skate_spots");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<double>("Wheelbase")
                        .HasColumnType("double precision")
                        .HasColumnName("wheelbase");

                    b.Property<double>("Width")
                        .HasColumnType("double precision")
                        .HasColumnName("width");

                    b.HasKey("Id")
                        .HasName("pk_products");

                    b.ToTable("products", (string)null);
                });

            modelBuilder.Entity("CAPSTONE_Swift_Server.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("content");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer")
                        .HasColumnName("customer_id");

                    b.HasKey("Id")
                        .HasName("pk_reviews");

                    b.ToTable("reviews", (string)null);
                });

            modelBuilder.Entity("CAPSTONE_Swift_Server.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("bio");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("image_url");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("boolean")
                        .HasColumnName("is_admin");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint")
                        .HasColumnName("phone_number");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("uid");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("CartProduct", b =>
                {
                    b.Property<int>("CartListId")
                        .HasColumnType("integer")
                        .HasColumnName("cart_list_id");

                    b.Property<int>("ProductListId")
                        .HasColumnType("integer")
                        .HasColumnName("product_list_id");

                    b.HasKey("CartListId", "ProductListId")
                        .HasName("pk_cart_product");

                    b.HasIndex("ProductListId")
                        .HasDatabaseName("ix_cart_product_product_list_id");

                    b.ToTable("cart_product", (string)null);
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.Property<int>("OrderListId")
                        .HasColumnType("integer")
                        .HasColumnName("order_list_id");

                    b.Property<int>("ProductListId")
                        .HasColumnType("integer")
                        .HasColumnName("product_list_id");

                    b.HasKey("OrderListId", "ProductListId")
                        .HasName("pk_order_product");

                    b.HasIndex("ProductListId")
                        .HasDatabaseName("ix_order_product_product_list_id");

                    b.ToTable("order_product", (string)null);
                });

            modelBuilder.Entity("ProductReview", b =>
                {
                    b.Property<int>("ProductsId")
                        .HasColumnType("integer")
                        .HasColumnName("products_id");

                    b.Property<int>("ReviewListId")
                        .HasColumnType("integer")
                        .HasColumnName("review_list_id");

                    b.HasKey("ProductsId", "ReviewListId")
                        .HasName("pk_product_review");

                    b.HasIndex("ReviewListId")
                        .HasDatabaseName("ix_product_review_review_list_id");

                    b.ToTable("product_review", (string)null);
                });

            modelBuilder.Entity("CartProduct", b =>
                {
                    b.HasOne("CAPSTONE_Swift_Server.Models.Cart", null)
                        .WithMany()
                        .HasForeignKey("CartListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_cart_product_carts_cart_list_id");

                    b.HasOne("CAPSTONE_Swift_Server.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_cart_product_products_product_list_id");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.HasOne("CAPSTONE_Swift_Server.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("OrderListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_order_product_orders_order_list_id");

                    b.HasOne("CAPSTONE_Swift_Server.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_order_product_products_product_list_id");
                });

            modelBuilder.Entity("ProductReview", b =>
                {
                    b.HasOne("CAPSTONE_Swift_Server.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_product_review_products_products_id");

                    b.HasOne("CAPSTONE_Swift_Server.Models.Review", null)
                        .WithMany()
                        .HasForeignKey("ReviewListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_product_review_reviews_review_list_id");
                });
#pragma warning restore 612, 618
        }
    }
}
