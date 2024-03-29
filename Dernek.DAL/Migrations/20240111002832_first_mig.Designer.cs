﻿// <auto-generated />
using System;
using Dernek.DAL;
using EntityFrameworkCore.Jet.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dernek.DAL.Migrations
{
    [DbContext(typeof(DernekDbContext))]
    [Migration("20240111002832_first_mig")]
    partial class first_mig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Jet:ValueGenerationStrategy", JetValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Dernek.Core.Entities.MemberEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("BloodType")
                        .HasColumnType("integer");

                    b.Property<int>("City")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longchar");

                    b.Property<bool>("IsActive")
                        .HasColumnType("smallint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longchar");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("longchar");

                    b.HasKey("Id");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("Dernek.Core.Entities.MembershipFeeEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<decimal>("Fee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Month")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("MemberFees");

                    b.HasData(
                        new
                        {
                            Id = "c2ad7868-fca1-427b-9c29-12f8643d74d0",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fee = 100m,
                            Month = 1
                        },
                        new
                        {
                            Id = "37624a70-748f-42b2-80dd-3a8543809ab7",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fee = 100m,
                            Month = 2
                        },
                        new
                        {
                            Id = "ade06a56-da56-4ca4-af75-0d6f16e5f51d",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fee = 100m,
                            Month = 3
                        },
                        new
                        {
                            Id = "1e5985a7-ae26-405d-baff-4a0480d535c7",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fee = 100m,
                            Month = 4
                        },
                        new
                        {
                            Id = "017925ad-95ca-4673-ab6f-22b8299c2065",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fee = 100m,
                            Month = 5
                        },
                        new
                        {
                            Id = "74ac134b-d377-4aa2-8dce-03ef61fb18ac",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fee = 100m,
                            Month = 6
                        },
                        new
                        {
                            Id = "6656ed48-f06f-44a4-9394-f997127a98d4",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fee = 100m,
                            Month = 7
                        },
                        new
                        {
                            Id = "23ecff19-5105-475d-b665-bb8d4e0b62c6",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fee = 100m,
                            Month = 8
                        },
                        new
                        {
                            Id = "d0bcd558-650a-4284-84c1-db86962a12d7",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fee = 100m,
                            Month = 9
                        },
                        new
                        {
                            Id = "f590f5fa-acf9-4d70-9d5f-a9da39a21412",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fee = 100m,
                            Month = 10
                        },
                        new
                        {
                            Id = "3109ade9-71a8-47e7-8c32-4e92dd33dddf",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fee = 100m,
                            Month = 11
                        },
                        new
                        {
                            Id = "a8196656-59be-415d-9344-00dd4bd015f1",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fee = 100m,
                            Month = 12
                        });
                });

            modelBuilder.Entity("Dernek.Core.Entities.PaymentEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("MemberId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("MembershipFeeId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.HasIndex("MembershipFeeId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Dernek.Core.Entities.PaymentEntity", b =>
                {
                    b.HasOne("Dernek.Core.Entities.MemberEntity", "Member")
                        .WithMany("Payments")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dernek.Core.Entities.MembershipFeeEntity", "MembershipFee")
                        .WithMany("Payments")
                        .HasForeignKey("MembershipFeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");

                    b.Navigation("MembershipFee");
                });

            modelBuilder.Entity("Dernek.Core.Entities.MemberEntity", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("Dernek.Core.Entities.MembershipFeeEntity", b =>
                {
                    b.Navigation("Payments");
                });
#pragma warning restore 612, 618
        }
    }
}
