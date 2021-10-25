﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Services.Order.Infrastructure.Migrations
{
    [DbContext(typeof(OrderDbContext))]
    [Migration("20210331200152_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Course.Services.Order.Domain.OrderAggregate.Order", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("BuyerId")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("CreatedDate")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.ToTable("Orders", "ordering");
            });

            modelBuilder.Entity("Course.Services.Order.Domain.OrderAggregate.OrderItem", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int?>("OrderId")
                    .HasColumnType("int");

                b.Property<string>("PictureUrl")
                    .HasColumnType("nvarchar(max)");

                b.Property<decimal>("Price")
                    .HasColumnType("decimal(18,2)");

                b.Property<string>("ProductId")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ProductName")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("OrderId");

                b.ToTable("OrderItems", "ordering");
            });

            modelBuilder.Entity("Course.Services.Order.Domain.OrderAggregate.Order", b =>
            {
                b.OwnsOne("Course.Services.Order.Domain.OrderAggregate.Address", "Address", b1 =>
                {
                    b1.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b1.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b1.Property<string>("Line")
                        .HasColumnType("nvarchar(max)");

                    b1.Property<string>("Province")
                        .HasColumnType("nvarchar(max)");

                    b1.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b1.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b1.HasKey("OrderId");

                    b1.ToTable("Orders");

                    b1.WithOwner()
                        .HasForeignKey("OrderId");
                });

                b.Navigation("Address");
            });

            modelBuilder.Entity("Course.Services.Order.Domain.OrderAggregate.OrderItem", b =>
            {
                b.HasOne("FreeCourse.Services.Order.Domain.OrderAggregate.Order", null)
                    .WithMany("OrderItems")
                    .HasForeignKey("OrderId");
            });

            modelBuilder.Entity("Course.Services.Order.Domain.OrderAggregate.Order", b =>
            {
                b.Navigation("OrderItems");
            });
#pragma warning restore 612, 618
        }
    }
}
