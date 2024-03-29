﻿// <auto-generated />
using System;
using DuzceUni.DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DuzceUni.DataAccess.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221119232026_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DuzceUni.Entity.Concrete.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AdminAbout")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("AdminMail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("AdminName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("AdminPasswordHash")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("AdminStatus")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecretKey")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            AdminId = 1,
                            AdminAbout = "Admin",
                            AdminMail = "admin@admin.com",
                            AdminName = "Admin",
                            AdminPasswordHash = "3B612C75A7B5048A435FB6EC81E52FF92D6D795A8B5A9C17070F6A63C97A53B2",
                            AdminStatus = true,
                            SecretKey = "376c677277a64d33b1ff7c98d3bc11db20Kas2022022026"
                        });
                });

            modelBuilder.Entity("DuzceUni.Entity.Concrete.Announcement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<string>("AnnouncementContent")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("AnnouncementImage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("AnnouncementThumbnail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("AnnouncementTitle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("BlogStatus")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Announcements");
                });
#pragma warning restore 612, 618
        }
    }
}
