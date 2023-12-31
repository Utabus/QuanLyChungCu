﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebQuanLyChungCu.Models;

#nullable disable

namespace WebQuanLyChungCu.Migrations
{
    [DbContext(typeof(QUANLYCHUNGCUContext))]
    [Migration("20231229153110_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebQuanLyChungCu.Models.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"), 1L, 1);

                    b.Property<int?>("ApartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Avartar")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InfoId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RelationshipId")
                        .HasColumnType("int");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<byte?>("Status")
                        .HasColumnType("tinyint");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountId");

                    b.HasIndex(new[] { "ApartmentId" }, "IX_Account_ApartmentId");

                    b.HasIndex(new[] { "InfoId" }, "IX_Account_InfoId");

                    b.HasIndex(new[] { "RelationshipId" }, "IX_Account_RelationshipId");

                    b.HasIndex(new[] { "RoleId" }, "IX_Account_RoleId");

                    b.ToTable("Account", (string)null);
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.Apartment", b =>
                {
                    b.Property<int>("ApartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApartmentId"), 1L, 1);

                    b.Property<string>("ApartmentCode")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ApartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ApartmentNumber")
                        .HasColumnType("int");

                    b.Property<double?>("Area")
                        .HasColumnType("float");

                    b.Property<int?>("BuildingId")
                        .HasColumnType("int");

                    b.Property<int?>("FloorNumber")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDay")
                        .HasColumnType("datetime2");

                    b.Property<byte?>("Status")
                        .HasColumnType("tinyint");

                    b.HasKey("ApartmentId");

                    b.HasIndex(new[] { "BuildingId" }, "IX_Apartment_BuildingId");

                    b.ToTable("Apartment", (string)null);
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.ApartmentService", b =>
                {
                    b.Property<int>("ApartmentId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDay")
                        .HasColumnType("date");

                    b.Property<DateTime?>("StartDay")
                        .HasColumnType("date");

                    b.Property<byte?>("Status")
                        .HasColumnType("tinyint");

                    b.HasKey("ApartmentId", "ServiceId");

                    b.HasIndex(new[] { "ServiceId" }, "IX_Apartment_Service_ServiceId");

                    b.ToTable("Apartment_Service", (string)null);
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.Building", b =>
                {
                    b.Property<int>("BuildingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BuildingId"), 1L, 1);

                    b.Property<int?>("AccNumber")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ApartmentNumber")
                        .HasColumnType("int");

                    b.Property<string>("BuildingCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildingName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FloorNumber")
                        .HasColumnType("int");

                    b.Property<byte?>("Status")
                        .HasColumnType("tinyint");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BuildingId");

                    b.ToTable("Building", (string)null);
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.Contract", b =>
                {
                    b.Property<int>("ContractId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContractId"), 1L, 1);

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<int?>("ApartmentId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Deposit")
                        .HasColumnType("decimal(18,0)");

                    b.Property<DateTime?>("EndDay")
                        .HasColumnType("date");

                    b.Property<decimal?>("MonthlyRent")
                        .HasColumnType("decimal(18,0)")
                        .HasColumnName("Monthly_rent");

                    b.Property<DateTime?>("StartDay")
                        .HasColumnType("date");

                    b.Property<byte?>("Status")
                        .HasColumnType("tinyint");

                    b.HasKey("ContractId");

                    b.HasIndex("AccountId");

                    b.HasIndex(new[] { "ApartmentId" }, "IX_Contract_ApartmentId");

                    b.ToTable("Contract", (string)null);
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.ElectricMeter", b =>
                {
                    b.Property<int>("ElectricMeterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ElectricMeterId"), 1L, 1);

                    b.Property<int?>("ApartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<DateTime?>("DeadingDate")
                        .HasColumnType("date");

                    b.Property<double?>("NumberEnd")
                        .HasColumnType("float");

                    b.Property<double?>("NumberOne")
                        .HasColumnType("float");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,0)");

                    b.Property<DateTime?>("RegistrationDate")
                        .HasColumnType("date");

                    b.Property<byte?>("Status")
                        .HasColumnType("tinyint");

                    b.HasKey("ElectricMeterId");

                    b.HasIndex(new[] { "ApartmentId" }, "IX_ElectricMeter_ApartmentId");

                    b.ToTable("ElectricMeter", (string)null);
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.History", b =>
                {
                    b.Property<int>("HistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HistoryId"), 1L, 1);

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<byte?>("Action")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("Day")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("Screen")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HistoryId");

                    b.HasIndex(new[] { "AccountId" }, "IX_History_AccountId");

                    b.ToTable("History", (string)null);
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.InFo", b =>
                {
                    b.Property<int>("InfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InfoId"), 1L, 1);

                    b.Property<DateTime?>("BirthDay")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2")
                        .IsFixedLength();

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CmndCccd")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("CMND_CCCD");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte?>("Sex")
                        .HasColumnType("tinyint");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ward")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InfoId");

                    b.ToTable("InFo", (string)null);
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.News", b =>
                {
                    b.Property<int>("NewsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NewsId"), 1L, 1);

                    b.Property<DateTime?>("CreateDay")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .HasColumnType("ntext")
                        .HasColumnName("description");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte?>("Status")
                        .HasColumnType("tinyint");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NewsId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.Relationship", b =>
                {
                    b.Property<int>("RelationshipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RelationshipId"), 1L, 1);

                    b.Property<string>("RelationshipName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RelationshipId");

                    b.ToTable("Relationships");
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.ResidentsRequired", b =>
                {
                    b.Property<int>("RequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RequestId"), 1L, 1);

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<int?>("ApartmentId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDay")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<DateTime?>("FixDay")
                        .HasColumnType("date");

                    b.Property<int?>("Pending")
                        .HasColumnType("int");

                    b.Property<byte?>("Status")
                        .HasColumnType("tinyint");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RequestId");

                    b.HasIndex(new[] { "ApartmentId" }, "IX_ResidentsRequired_ApartmentId");

                    b.ToTable("ResidentsRequired", (string)null);
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.Revenue", b =>
                {
                    b.Property<int>("RevenueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RevenueId"), 1L, 1);

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<int?>("ApartmentId")
                        .HasColumnType("int");

                    b.Property<string>("CodeVoucher")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<DateTime?>("DayCreat")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DayPay")
                        .HasColumnType("date");

                    b.Property<decimal?>("Debt")
                        .HasColumnType("decimal(18,0)");

                    b.Property<double?>("ElectricNumber")
                        .HasColumnType("float");

                    b.Property<decimal?>("Pay")
                        .HasColumnType("decimal(18,0)");

                    b.Property<byte?>("Payments")
                        .HasColumnType("tinyint");

                    b.Property<decimal?>("ServiceFee")
                        .HasColumnType("decimal(18,0)");

                    b.Property<byte?>("Status")
                        .HasColumnType("tinyint");

                    b.Property<decimal?>("TotalMoney")
                        .HasColumnType("decimal(18,0)");

                    b.Property<double?>("WaterNumber")
                        .HasColumnType("float");

                    b.HasKey("RevenueId");

                    b.HasIndex("AccountId");

                    b.HasIndex(new[] { "ApartmentId" }, "IX_Revenue_ApartmentId");

                    b.ToTable("Revenue", (string)null);
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"), 1L, 1);

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceId"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<decimal?>("ServiceFee")
                        .HasColumnType("decimal(18,0)");

                    b.Property<string>("ServiceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte?>("Status")
                        .HasColumnType("tinyint");

                    b.HasKey("ServiceId");

                    b.ToTable("Service", (string)null);
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.WaterMeter", b =>
                {
                    b.Property<int>("WaterMeterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WaterMeterId"), 1L, 1);

                    b.Property<int?>("ApartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<DateTime?>("DeadingDate")
                        .HasColumnType("date");

                    b.Property<double?>("NumberEnd")
                        .HasColumnType("float");

                    b.Property<double?>("NumberOne")
                        .HasColumnType("float");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,0)");

                    b.Property<DateTime?>("RegistrationDate")
                        .HasColumnType("date");

                    b.Property<byte?>("Status")
                        .HasColumnType("tinyint");

                    b.HasKey("WaterMeterId");

                    b.HasIndex(new[] { "ApartmentId" }, "IX_WaterMeter_ApartmentId");

                    b.ToTable("WaterMeter", (string)null);
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.Account", b =>
                {
                    b.HasOne("WebQuanLyChungCu.Models.Apartment", "Apartment")
                        .WithMany("Accounts")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FK_Account_Apartment");

                    b.HasOne("WebQuanLyChungCu.Models.InFo", "Info")
                        .WithMany("Accounts")
                        .HasForeignKey("InfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FK_Account_InFo");

                    b.HasOne("WebQuanLyChungCu.Models.Relationship", "Relationship")
                        .WithMany("Accounts")
                        .HasForeignKey("RelationshipId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebQuanLyChungCu.Models.Role", "Role")
                        .WithMany("Accounts")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FK_Account_Role");

                    b.Navigation("Apartment");

                    b.Navigation("Info");

                    b.Navigation("Relationship");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.Apartment", b =>
                {
                    b.HasOne("WebQuanLyChungCu.Models.Building", "Building")
                        .WithMany("Apartments")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FK_CanHo_ChungCu");

                    b.Navigation("Building");
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.ApartmentService", b =>
                {
                    b.HasOne("WebQuanLyChungCu.Models.Apartment", "Apartment")
                        .WithMany("ApartmentServices")
                        .HasForeignKey("ApartmentId")
                        .IsRequired()
                        .HasConstraintName("FK_Apartment_Service_Apartment");

                    b.HasOne("WebQuanLyChungCu.Models.Service", "Service")
                        .WithMany("ApartmentServices")
                        .HasForeignKey("ServiceId")
                        .IsRequired()
                        .HasConstraintName("FK_Apartment_Service_Service");

                    b.Navigation("Apartment");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.Contract", b =>
                {
                    b.HasOne("WebQuanLyChungCu.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId");

                    b.HasOne("WebQuanLyChungCu.Models.Apartment", "Apartment")
                        .WithMany("Contracts")
                        .HasForeignKey("ApartmentId")
                        .HasConstraintName("FK_Contract_Apartment");

                    b.Navigation("Account");

                    b.Navigation("Apartment");
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.ElectricMeter", b =>
                {
                    b.HasOne("WebQuanLyChungCu.Models.Apartment", "Apartment")
                        .WithMany("ElectricMeters")
                        .HasForeignKey("ApartmentId")
                        .HasConstraintName("FK_ElectricMeter_Apartment");

                    b.Navigation("Apartment");
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.History", b =>
                {
                    b.HasOne("WebQuanLyChungCu.Models.Account", "Account")
                        .WithMany("Histories")
                        .HasForeignKey("AccountId")
                        .HasConstraintName("FK_History_Account");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.ResidentsRequired", b =>
                {
                    b.HasOne("WebQuanLyChungCu.Models.Apartment", "Apartment")
                        .WithMany("ResidentsRequireds")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FK_ResidentsRequired_Apartment");

                    b.Navigation("Apartment");
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.Revenue", b =>
                {
                    b.HasOne("WebQuanLyChungCu.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId");

                    b.HasOne("WebQuanLyChungCu.Models.Apartment", "Apartment")
                        .WithMany("Revenues")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FK_Revenue_Apartment");

                    b.Navigation("Account");

                    b.Navigation("Apartment");
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.WaterMeter", b =>
                {
                    b.HasOne("WebQuanLyChungCu.Models.Apartment", "Apartment")
                        .WithMany("WaterMeters")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FK_WaterMeter_Apartment");

                    b.Navigation("Apartment");
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.Account", b =>
                {
                    b.Navigation("Histories");
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.Apartment", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("ApartmentServices");

                    b.Navigation("Contracts");

                    b.Navigation("ElectricMeters");

                    b.Navigation("ResidentsRequireds");

                    b.Navigation("Revenues");

                    b.Navigation("WaterMeters");
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.Building", b =>
                {
                    b.Navigation("Apartments");
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.InFo", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.Relationship", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.Role", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("WebQuanLyChungCu.Models.Service", b =>
                {
                    b.Navigation("ApartmentServices");
                });
#pragma warning restore 612, 618
        }
    }
}
