﻿// <auto-generated />
using CompaniesProjectz.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CompaniesProjectz.Migrations
{
    [DbContext(typeof(CompaniesProjectzDbContext))]
    partial class CompaniesProjectzDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CompaniesProjectz.Data.Models.CompaniesInstInvestor", b =>
                {
                    b.Property<int>("IdTsCompany")
                        .HasColumnType("int");

                    b.Property<int>("IdInstinvestorName")
                        .HasColumnType("int");

                    b.HasKey("IdTsCompany", "IdInstinvestorName");

                    b.HasIndex("IdInstinvestorName");

                    b.ToTable("CompaniesInstInvestors");
                });

            modelBuilder.Entity("CompaniesProjectz.Data.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AboutTheCompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("IconPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MarketCap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TickerSymbol")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("WebSite")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyId");

                    b.HasIndex("TickerSymbol")
                        .IsUnique()
                        .HasFilter("[TickerSymbol] IS NOT NULL");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("CompaniesProjectz.Data.Models.IndividualInvestor", b =>
                {
                    b.Property<int>("InvestorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("IdTsCompany")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvestorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SharesInProcents")
                        .HasColumnType("int");

                    b.HasKey("InvestorId");

                    b.HasIndex("IdTsCompany");

                    b.ToTable("IndividualInvestors");
                });

            modelBuilder.Entity("CompaniesProjectz.Data.Models.InstitutionalInvestor", b =>
                {
                    b.Property<int>("InvestorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvestorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InvestorId");

                    b.ToTable("InstitutionalInvestors");
                });

            modelBuilder.Entity("CompaniesProjectz.Data.Models.Owner", b =>
                {
                    b.Property<int>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CEO")
                        .HasColumnType("int");

                    b.Property<string>("OwnerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OwnerId");

                    b.HasIndex("CEO");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("CompaniesProjectz.Data.Models.Statistic", b =>
                {
                    b.Property<int>("StatsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<float>("Alltimehighs")
                        .HasColumnType("real");

                    b.Property<float>("Alltimelows")
                        .HasColumnType("real");

                    b.Property<string>("BuyOrSell")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdTsCompany")
                        .HasColumnType("int");

                    b.HasKey("StatsId");

                    b.HasIndex("IdTsCompany");

                    b.ToTable("Statistics");
                });

            modelBuilder.Entity("CompaniesProjectz.Data.Models.CompaniesInstInvestor", b =>
                {
                    b.HasOne("CompaniesProjectz.Data.Models.InstitutionalInvestor", "IdInstinvestorNavigation")
                        .WithMany("CompaniesInstInvestors")
                        .HasForeignKey("IdInstinvestorName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompaniesProjectz.Data.Models.Company", "IdTsCompanyNavigation")
                        .WithMany("CompaniesInstInvestors")
                        .HasForeignKey("IdTsCompany")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdInstinvestorNavigation");

                    b.Navigation("IdTsCompanyNavigation");
                });

            modelBuilder.Entity("CompaniesProjectz.Data.Models.IndividualInvestor", b =>
                {
                    b.HasOne("CompaniesProjectz.Data.Models.Company", "IdTsCompanyNavigation")
                        .WithMany("IndividualInvestors")
                        .HasForeignKey("IdTsCompany")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdTsCompanyNavigation");
                });

            modelBuilder.Entity("CompaniesProjectz.Data.Models.Owner", b =>
                {
                    b.HasOne("CompaniesProjectz.Data.Models.Company", "CEONavigation")
                        .WithMany("Owners")
                        .HasForeignKey("CEO")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CEONavigation");
                });

            modelBuilder.Entity("CompaniesProjectz.Data.Models.Statistic", b =>
                {
                    b.HasOne("CompaniesProjectz.Data.Models.Company", "IdTsCompanyNavigation")
                        .WithMany("Statistics")
                        .HasForeignKey("IdTsCompany")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdTsCompanyNavigation");
                });

            modelBuilder.Entity("CompaniesProjectz.Data.Models.Company", b =>
                {
                    b.Navigation("CompaniesInstInvestors");

                    b.Navigation("IndividualInvestors");

                    b.Navigation("Owners");

                    b.Navigation("Statistics");
                });

            modelBuilder.Entity("CompaniesProjectz.Data.Models.InstitutionalInvestor", b =>
                {
                    b.Navigation("CompaniesInstInvestors");
                });
#pragma warning restore 612, 618
        }
    }
}
