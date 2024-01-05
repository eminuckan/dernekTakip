﻿// <auto-generated />
using System;
using Dernek.DAL;
using EntityFrameworkCore.Jet.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dernek.DAL.Migrations
{
    [DbContext(typeof(DernekDbContext))]
    partial class DernekDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasKey("Id");

                    b.ToTable("MembershipFeeEntity");
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
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.HasIndex("MembershipFeeId");

                    b.ToTable("PaymentEntity");
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
                        .HasForeignKey("MembershipFeeId");

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
