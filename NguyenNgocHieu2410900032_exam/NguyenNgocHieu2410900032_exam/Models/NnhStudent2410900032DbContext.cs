using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NguyenNgocHieu2410900032_exam.Models;

public partial class NnhStudent2410900032DbContext : DbContext
{
    public NnhStudent2410900032DbContext()
    {
    }

    public NnhStudent2410900032DbContext(DbContextOptions<NnhStudent2410900032DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<NnhStudent> NnhStudents { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	=> optionsBuilder.UseSqlServer("Server=NGỌCHIẾU\\SQLEXPRESS02;Database=NnhStudent_2410900032_Db;Trusted_Connection=True;TrustServerCertificate=True");

	protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NnhStudent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NnhStude__3214EC079295B0A0");

            entity.ToTable("NnhStudent");

            entity.Property(e => e.NnhActive).HasDefaultValue(true);
            entity.Property(e => e.NnhEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NnhGender).HasMaxLength(10);
            entity.Property(e => e.NnhName).HasMaxLength(100);
            entity.Property(e => e.NnhPhone)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
