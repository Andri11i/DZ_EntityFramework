using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DZ_EntityFramework.Models;

public partial class DzefwContext : DbContext
{
    public DzefwContext()
    {
    }

    public DzefwContext(DbContextOptions<DzefwContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=TUF;Initial Catalog=DZEFW;Integrated Security=True");


      

        public DbSet<Author> Authors { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Rental> Rentals { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(a => a.Articles)
                .WithOne(b => b.Author)
                .HasForeignKey(b => b.AuthorID);

            modelBuilder.Entity<Article>()
                .HasMany(a => a.Comments)
                .WithOne(c => c.Article)
                .HasForeignKey(c => c.ArticleID);

            modelBuilder.Entity<Hotel>()
                .HasMany(h => h.Rooms)
                .WithOne(r => r.Hotel)
                .HasForeignKey(r => r.HotelID);

            modelBuilder.Entity<Room>()
                .HasMany(r => r.Bookings)
                .WithOne(b => b.Room)
                .HasForeignKey(b => b.RoomID);
            modelBuilder.Entity<Rental>()
                .HasOne(r => r.Book)
                .WithMany(b => b.Rentals)
                .HasForeignKey(r => r.BookID);

            modelBuilder.Entity<Rental>()
                .HasOne(r => r.User)
                .WithMany(u => u.Rentals)
                .HasForeignKey(r => r.UserID);
    }
    


    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
