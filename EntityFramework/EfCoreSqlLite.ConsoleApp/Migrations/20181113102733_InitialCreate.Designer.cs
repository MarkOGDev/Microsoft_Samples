﻿// <auto-generated />
using MarkOGDev.Microsoft_Samples.EfCoreSqlLite.ConsoleApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MarkOGDev.Microsoft_Samples.EfCoreSqlLite.ConsoleApp.Migrations
{
    [DbContext(typeof(DirectoriesContext))]
    [Migration("20181113102733_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("MarkOGDev.Microsoft_Samples.EfCoreSqlLite.ConsoleApp.Data.Directory", b =>
                {
                    b.Property<int>("DirectoryId");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("DirectoryId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Directories");

                    b.HasData(
                        new { DirectoryId = 1, Description = "Amazing Exotic Cars for sale", Name = "Exotic Cars Online" },
                        new { DirectoryId = 2, Description = "Swap Not Buy.", Name = "Fashion Swap Shop UK" }
                    );
                });

            modelBuilder.Entity("MarkOGDev.Microsoft_Samples.EfCoreSqlLite.ConsoleApp.Data.Item", b =>
                {
                    b.Property<int>("ItemId");

                    b.Property<string>("Description");

                    b.Property<int>("DirectoryId");

                    b.Property<string>("Image");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("ItemId");

                    b.HasIndex("DirectoryId");

                    b.ToTable("Items");

                    b.HasData(
                        new { ItemId = 1, DirectoryId = 1, Title = "BMW I8" },
                        new { ItemId = 2, DirectoryId = 1, Title = "Porsche 911" },
                        new { ItemId = 3, DirectoryId = 1, Title = "Ferrari  Enzo" },
                        new { ItemId = 4, DirectoryId = 2, Title = "Classic Knee High Boots" },
                        new { ItemId = 5, DirectoryId = 2, Title = "Designer Handbag" },
                        new { ItemId = 6, DirectoryId = 2, Title = "Groovy Summer Hat" }
                    );
                });

            modelBuilder.Entity("MarkOGDev.Microsoft_Samples.EfCoreSqlLite.ConsoleApp.Data.Item", b =>
                {
                    b.HasOne("MarkOGDev.Microsoft_Samples.EfCoreSqlLite.ConsoleApp.Data.Directory", "Directory")
                        .WithMany("Items")
                        .HasForeignKey("DirectoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
