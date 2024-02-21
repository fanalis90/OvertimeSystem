﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(OvertimeSystemDbContext))]
    [Migration("20240221042643_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("API.Models.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<DateTime>("Expired")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("expired");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_active");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_used");

                    b.Property<int>("OTP")
                        .HasColumnType("int")
                        .HasColumnName("otp");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("password");

                    b.HasKey("Id");

                    b.ToTable("tbl_m_accounts");
                });

            modelBuilder.Entity("API.Models.AccountRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("char(36)")
                        .HasColumnName("account_id");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)")
                        .HasColumnName("role_id");

                    b.HasKey("Id");

                    b.ToTable("tbl_tr_account_roles");
                });

            modelBuilder.Entity("API.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("department");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("FristName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("first_name");

                    b.Property<DateTime>("JoinedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("joined_date");

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("last_name");

                    b.Property<Guid?>("ManagerId")
                        .HasColumnType("char(36)")
                        .HasColumnName("manager_id");

                    b.Property<string>("NIK")
                        .IsRequired()
                        .HasColumnType("varchar(6)")
                        .HasColumnName("nik");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("position");

                    b.Property<int>("Salary")
                        .HasColumnType("int")
                        .HasColumnName("salary");

                    b.HasKey("Id");

                    b.ToTable("tbl_m_employees");
                });

            modelBuilder.Entity("API.Models.Overtime", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("document");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("reason");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("status");

                    b.Property<int>("TotalHours")
                        .HasColumnType("int")
                        .HasColumnName("total_hours");

                    b.HasKey("Id");

                    b.ToTable("tbl_m_overtimes");
                });

            modelBuilder.Entity("API.Models.OvertimeRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("char(36)")
                        .HasColumnName("account_id");

                    b.Property<string>("Comment")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("comment");

                    b.Property<Guid>("OvertimeId")
                        .HasColumnType("char(36)")
                        .HasColumnName("overtime_id");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("status");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("time_stamp");

                    b.HasKey("Id");

                    b.ToTable("tbl_tr_overtime_requests");
                });

            modelBuilder.Entity("API.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("tbl_m_roles");
                });
#pragma warning restore 612, 618
        }
    }
}
