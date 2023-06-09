﻿// <auto-generated />
using System;
using CA.DepartmentStore.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CA.DepartmentStore.Persistence.Migrations
{
    [DbContext(typeof(DepartmentStoreDbContext))]
    partial class DepartmentStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CA.DepartmentStore.Domain.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoleType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RoleType = "Store Manager"
                        },
                        new
                        {
                            Id = 2,
                            RoleType = "Cashier"
                        },
                        new
                        {
                            Id = 3,
                            RoleType = "Inventory Manager"
                        });
                });

            modelBuilder.Entity("CA.DepartmentStore.Domain.Entities.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StaffRoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StaffRoleId");

                    b.ToTable("Staffs");

                    b.HasData(
                        new
                        {
                            Id = 999,
                            Address = "",
                            Age = 99,
                            Email = "",
                            MobileNo = "9999999999",
                            Name = "Master",
                            Password = "Server@123"
                        });
                });

            modelBuilder.Entity("CA.DepartmentStore.Domain.Entities.Staff", b =>
                {
                    b.HasOne("CA.DepartmentStore.Domain.Entities.Role", "StaffRole")
                        .WithMany()
                        .HasForeignKey("StaffRoleId");

                    b.Navigation("StaffRole");
                });
#pragma warning restore 612, 618
        }
    }
}
