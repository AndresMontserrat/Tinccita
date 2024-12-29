﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tinccita.Infraestructure.Data;

#nullable disable

namespace Tinccita.Infraestructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241225161046_20241225_basicEntities")]
    partial class _20241225_basicEntities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("AppointmentBookedCustomer", b =>
                {
                    b.Property<Guid>("AppointmentsBookedId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CustomersGuid")
                        .HasColumnType("TEXT");

                    b.HasKey("AppointmentsBookedId", "CustomersGuid");

                    b.HasIndex("CustomersGuid");

                    b.ToTable("AppointmentBookedCustomer");
                });

            modelBuilder.Entity("Tinccita.Domain.Entities.AppointmentAvailable", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ServiceId")
                        .HasColumnType("TEXT");

                    b.Property<TimeOnly>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.ToTable("AppointmentsAvailable");
                });

            modelBuilder.Entity("Tinccita.Domain.Entities.AppointmentBooked", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.PrimitiveCollection<string>("CustomersId")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ServiceId")
                        .HasColumnType("TEXT");

                    b.Property<TimeOnly>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.ToTable("AppointmentsBooked");
                });

            modelBuilder.Entity("Tinccita.Domain.Entities.Business", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Businesses");
                });

            modelBuilder.Entity("Tinccita.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("BusinessId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BusinessId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Tinccita.Domain.Entities.Customer", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Prefix")
                        .HasColumnType("TEXT");

                    b.HasKey("Guid");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Tinccita.Domain.Entities.Service", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("SubcategoryId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SubcategoryId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Tinccita.Domain.Entities.Subcategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Subcategories");
                });

            modelBuilder.Entity("AppointmentBookedCustomer", b =>
                {
                    b.HasOne("Tinccita.Domain.Entities.AppointmentBooked", null)
                        .WithMany()
                        .HasForeignKey("AppointmentsBookedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tinccita.Domain.Entities.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomersGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Tinccita.Domain.Entities.AppointmentAvailable", b =>
                {
                    b.HasOne("Tinccita.Domain.Entities.Service", "Service")
                        .WithMany("AppointmentsAvailable")
                        .HasForeignKey("ServiceId");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Tinccita.Domain.Entities.AppointmentBooked", b =>
                {
                    b.HasOne("Tinccita.Domain.Entities.Service", "Service")
                        .WithMany("AppointmentsBooked")
                        .HasForeignKey("ServiceId");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Tinccita.Domain.Entities.Category", b =>
                {
                    b.HasOne("Tinccita.Domain.Entities.Business", "Business")
                        .WithMany("Categories")
                        .HasForeignKey("BusinessId");

                    b.Navigation("Business");
                });

            modelBuilder.Entity("Tinccita.Domain.Entities.Service", b =>
                {
                    b.HasOne("Tinccita.Domain.Entities.Subcategory", "Subcategory")
                        .WithMany("Services")
                        .HasForeignKey("SubcategoryId");

                    b.Navigation("Subcategory");
                });

            modelBuilder.Entity("Tinccita.Domain.Entities.Subcategory", b =>
                {
                    b.HasOne("Tinccita.Domain.Entities.Category", "Category")
                        .WithMany("Subcategories")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Tinccita.Domain.Entities.Business", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("Tinccita.Domain.Entities.Category", b =>
                {
                    b.Navigation("Subcategories");
                });

            modelBuilder.Entity("Tinccita.Domain.Entities.Service", b =>
                {
                    b.Navigation("AppointmentsAvailable");

                    b.Navigation("AppointmentsBooked");
                });

            modelBuilder.Entity("Tinccita.Domain.Entities.Subcategory", b =>
                {
                    b.Navigation("Services");
                });
#pragma warning restore 612, 618
        }
    }
}
