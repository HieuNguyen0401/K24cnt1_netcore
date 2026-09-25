using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NnhLession10efdbfist.Models;

public partial class NnhLession10efdbContext : DbContext
{
    public NnhLession10efdbContext()
    {
    }

    public NnhLession10efdbContext(DbContextOptions<NnhLession10efdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<NnhMember> NnhMembers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=NGỌCHIẾU\\SQLEXPRESS02;Database=NnhLession10efdb;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NnhMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NnhMembe__3214EC0740E7A604");

            entity.ToTable("NnhMember");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.NnhEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NnhFullName).HasMaxLength(50);
            entity.Property(e => e.NnhPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NnhPhone)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NnhUserName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
