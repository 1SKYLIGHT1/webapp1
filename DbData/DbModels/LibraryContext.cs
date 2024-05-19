using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DbData.DbModels;

public partial class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Author { get; set; }

    public virtual DbSet<Book> Book { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(100);
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.Property(e => e.PublicationDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(100);

            entity.HasOne(d => d.Author).WithMany(p => p.Book)
                .HasForeignKey(d => d.AuthorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Book_Author");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
