﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using assignments.Models;

#nullable disable

namespace assignments.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231023234204_fifthmigration")]
    partial class fifthmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("assignments.Models.Console", b =>
                {
                    b.Property<int>("ConsoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.HasKey("ConsoleId");

                    b.ToTable("Consoles");
                });

            modelBuilder.Entity("assignments.Models.Product", b =>
                {
                    b.Property<string>("SKU")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("GamesId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductDescription")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("ProductImage")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.HasKey("SKU");

                    b.HasIndex("GamesId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("assignments.Models.Product", b =>
                {
                    b.HasOne("assignments.Models.Console", "Game")
                        .WithMany("Products")
                        .HasForeignKey("GamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("assignments.Models.Console", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
