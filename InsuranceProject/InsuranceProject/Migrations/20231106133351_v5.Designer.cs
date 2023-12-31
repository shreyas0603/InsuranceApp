﻿// <auto-generated />
using System;
using InsuranceProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InsuranceProject.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20231106133351_v5")]
    partial class v5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InsuranceDay1.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("InsuranceDay1.Models.Agent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Commision")
                        .HasColumnType("float");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MobileNumber")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalCommision")
                        .HasColumnType("float");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Agents");
                });

            modelBuilder.Entity("InsuranceDay1.Models.Commision", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AgentId")
                        .HasColumnType("int");

                    b.Property<double>("CommisionAmount")
                        .HasColumnType("float");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("InsurancePlanId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AgentId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("InsurancePlanId");

                    b.ToTable("Commisions");
                });

            modelBuilder.Entity("InsuranceDay1.Models.CommisionWithdrawal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("TotalWithdrawalAmount")
                        .HasColumnType("float");

                    b.Property<double>("WithdrawalAmount")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("CommisionWithdrawals");
                });

            modelBuilder.Entity("InsuranceDay1.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AgentId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("MobileNumber")
                        .HasColumnType("int");

                    b.Property<string>("NomineeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomineeRelation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AgentId");

                    b.HasIndex("LocationId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("InsuranceDay1.Models.CustomerInsuranceAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsuranceCreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("InsurancePlanId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("MaturityDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PolicyTerm")
                        .HasColumnType("int");

                    b.Property<double>("ProfitRatio")
                        .HasColumnType("float");

                    b.Property<double>("SumAssured")
                        .HasColumnType("float");

                    b.Property<double>("TotalPremium")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("InsurancePlanId");

                    b.ToTable("CustomerInsuranceAccounts");
                });

            modelBuilder.Entity("InsuranceDay1.Models.Documents", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("DocumentInformation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("InsuranceDay1.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("InsuranceDay1.Models.InsurancePlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("InsuranceSchemeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MaxAge")
                        .HasColumnType("int");

                    b.Property<double>("MaxInvestmentAmount")
                        .HasColumnType("float");

                    b.Property<int>("MaxPolicyTerm")
                        .HasColumnType("int");

                    b.Property<int>("MinAge")
                        .HasColumnType("int");

                    b.Property<double>("MinInvestmentAmount")
                        .HasColumnType("float");

                    b.Property<int>("MinPolicyTerm")
                        .HasColumnType("int");

                    b.Property<double>("ProfitRatioPercentage")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("InsuranceSchemeId");

                    b.ToTable("InsurancePlans");
                });

            modelBuilder.Entity("InsuranceDay1.Models.InsuranceScheme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("InstallmentPaymentCommision")
                        .HasColumnType("float");

                    b.Property<string>("InsuranceSchemeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InsuranceTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<double>("NewRegistrastionCommision")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("InsuranceTypeId");

                    b.ToTable("InsuranceSchemes");
                });

            modelBuilder.Entity("InsuranceDay1.Models.InsuranceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("InsuranceTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("InsuranceTypes");
                });

            modelBuilder.Entity("InsuranceDay1.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("InsuranceDay1.Models.PolicyClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("InsurancePlanId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<double>("WithdrawalAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("WithdrawalDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("InsurancePlanId");

                    b.ToTable("PolicyClaims");
                });

            modelBuilder.Entity("InsuranceDay1.Models.PolicyPayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("InsurancePlanId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<double>("PaidAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("PaidDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("TaxAmount")
                        .HasColumnType("float");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.Property<string>("TransactionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("InsurancePlanId");

                    b.ToTable("PolicyPayments");
                });

            modelBuilder.Entity("InsuranceDay1.Models.Query", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("QueryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("QueryMessage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QueryTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reply")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Queries");
                });

            modelBuilder.Entity("InsuranceDay1.Models.Commision", b =>
                {
                    b.HasOne("InsuranceDay1.Models.Agent", "Agent")
                        .WithMany("Commisions")
                        .HasForeignKey("AgentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceDay1.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceDay1.Models.InsurancePlan", "InsurancePlan")
                        .WithMany("Commisions")
                        .HasForeignKey("InsurancePlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agent");

                    b.Navigation("Customer");

                    b.Navigation("InsurancePlan");
                });

            modelBuilder.Entity("InsuranceDay1.Models.Customer", b =>
                {
                    b.HasOne("InsuranceDay1.Models.Agent", "Agent")
                        .WithMany("Customers")
                        .HasForeignKey("AgentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceDay1.Models.Location", "Location")
                        .WithMany("Customers")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agent");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("InsuranceDay1.Models.CustomerInsuranceAccount", b =>
                {
                    b.HasOne("InsuranceDay1.Models.Customer", "Customer")
                        .WithMany("CustomerInsuranceAccounts")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceDay1.Models.InsurancePlan", "InsurancePlan")
                        .WithMany("CustomerInsuranceAccounts")
                        .HasForeignKey("InsurancePlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("InsurancePlan");
                });

            modelBuilder.Entity("InsuranceDay1.Models.Documents", b =>
                {
                    b.HasOne("InsuranceDay1.Models.Customer", "Customer")
                        .WithMany("Documents")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("InsuranceDay1.Models.InsurancePlan", b =>
                {
                    b.HasOne("InsuranceDay1.Models.InsuranceScheme", "insuranceScheme")
                        .WithMany("InsurancePlans")
                        .HasForeignKey("InsuranceSchemeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("insuranceScheme");
                });

            modelBuilder.Entity("InsuranceDay1.Models.InsuranceScheme", b =>
                {
                    b.HasOne("InsuranceDay1.Models.InsuranceType", "InsuranceType")
                        .WithMany("InsuranceSchemes")
                        .HasForeignKey("InsuranceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InsuranceType");
                });

            modelBuilder.Entity("InsuranceDay1.Models.PolicyClaim", b =>
                {
                    b.HasOne("InsuranceDay1.Models.Customer", "Customer")
                        .WithMany("PolicyClaims")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceDay1.Models.InsurancePlan", "InsurancePlan")
                        .WithMany("PolicyClaims")
                        .HasForeignKey("InsurancePlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("InsurancePlan");
                });

            modelBuilder.Entity("InsuranceDay1.Models.PolicyPayment", b =>
                {
                    b.HasOne("InsuranceDay1.Models.Customer", "Customer")
                        .WithMany("PolicyPayments")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceDay1.Models.InsurancePlan", "InsurancePlan")
                        .WithMany("PolicyPayments")
                        .HasForeignKey("InsurancePlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("InsurancePlan");
                });

            modelBuilder.Entity("InsuranceDay1.Models.Query", b =>
                {
                    b.HasOne("InsuranceDay1.Models.Customer", "Customer")
                        .WithMany("Queries")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("InsuranceDay1.Models.Agent", b =>
                {
                    b.Navigation("Commisions");

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("InsuranceDay1.Models.Customer", b =>
                {
                    b.Navigation("CustomerInsuranceAccounts");

                    b.Navigation("Documents");

                    b.Navigation("PolicyClaims");

                    b.Navigation("PolicyPayments");

                    b.Navigation("Queries");
                });

            modelBuilder.Entity("InsuranceDay1.Models.InsurancePlan", b =>
                {
                    b.Navigation("Commisions");

                    b.Navigation("CustomerInsuranceAccounts");

                    b.Navigation("PolicyClaims");

                    b.Navigation("PolicyPayments");
                });

            modelBuilder.Entity("InsuranceDay1.Models.InsuranceScheme", b =>
                {
                    b.Navigation("InsurancePlans");
                });

            modelBuilder.Entity("InsuranceDay1.Models.InsuranceType", b =>
                {
                    b.Navigation("InsuranceSchemes");
                });

            modelBuilder.Entity("InsuranceDay1.Models.Location", b =>
                {
                    b.Navigation("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}
