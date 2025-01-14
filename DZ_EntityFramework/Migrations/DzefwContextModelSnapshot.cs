﻿// <auto-generated />
using System;
using DZ_EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DZ_EntityFramework.Migrations
{
    [DbContext(typeof(DzefwContext))]
    partial class DzefwContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DZ_EntityFramework.Models.Article", b =>
                {
                    b.Property<int>("ArticleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticleID"));

                    b.Property<int>("AuthorID")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArticleID");

                    b.HasIndex("AuthorID");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("DZ_EntityFramework.Models.Author", b =>
                {
                    b.Property<int>("AuthorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorID");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("DZ_EntityFramework.Models.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookID"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("DZ_EntityFramework.Models.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingID"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookingID");

                    b.HasIndex("RoomID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("DZ_EntityFramework.Models.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentID"));

                    b.Property<int>("ArticleID")
                        .HasColumnType("int");

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommentID");

                    b.HasIndex("ArticleID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("DZ_EntityFramework.Models.Hotel", b =>
                {
                    b.Property<int>("HotelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.HasKey("HotelID");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("DZ_EntityFramework.Models.Rental", b =>
                {
                    b.Property<int>("RentalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RentalID"));

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("RentalID");

                    b.HasIndex("BookID");

                    b.HasIndex("UserID");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("DZ_EntityFramework.Models.Room", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomID"));

                    b.Property<int>("HotelID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomID");

                    b.HasIndex("HotelID");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("DZ_EntityFramework.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DZ_EntityFramework.Models.Article", b =>
                {
                    b.HasOne("DZ_EntityFramework.Models.Author", "Author")
                        .WithMany("Articles")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("DZ_EntityFramework.Models.Booking", b =>
                {
                    b.HasOne("DZ_EntityFramework.Models.Room", "Room")
                        .WithMany("Bookings")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("DZ_EntityFramework.Models.Comment", b =>
                {
                    b.HasOne("DZ_EntityFramework.Models.Article", "Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");
                });

            modelBuilder.Entity("DZ_EntityFramework.Models.Rental", b =>
                {
                    b.HasOne("DZ_EntityFramework.Models.Book", "Book")
                        .WithMany("Rentals")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DZ_EntityFramework.Models.User", "User")
                        .WithMany("Rentals")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DZ_EntityFramework.Models.Room", b =>
                {
                    b.HasOne("DZ_EntityFramework.Models.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("DZ_EntityFramework.Models.Article", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("DZ_EntityFramework.Models.Author", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("DZ_EntityFramework.Models.Book", b =>
                {
                    b.Navigation("Rentals");
                });

            modelBuilder.Entity("DZ_EntityFramework.Models.Hotel", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("DZ_EntityFramework.Models.Room", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("DZ_EntityFramework.Models.User", b =>
                {
                    b.Navigation("Rentals");
                });
#pragma warning restore 612, 618
        }
    }
}
