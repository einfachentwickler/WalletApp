﻿// <auto-generated />
using System;
using DataAccess.WallerAppDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(WalletAppDbContext))]
    [Migration("20231031181611_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Entities.TransactionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Amount")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(64000)
                        .HasColumnType("character varying(64000)");

                    b.Property<bool>("IsAutorizedUser")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsPending")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("ct_transactions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 12.130000000000001,
                            Date = new DateTime(2023, 10, 31, 18, 16, 11, 573, DateTimeKind.Utc).AddTicks(4225),
                            Description = "Some description",
                            IsAutorizedUser = true,
                            IsPending = true,
                            Name = "Transaction 1",
                            Type = 0
                        },
                        new
                        {
                            Id = 2,
                            Amount = 12.130000000000001,
                            Date = new DateTime(2002, 12, 12, 12, 12, 12, 0, DateTimeKind.Unspecified),
                            Description = "Some description 2",
                            IsAutorizedUser = true,
                            IsPending = false,
                            Name = "Transaction 2",
                            Type = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
