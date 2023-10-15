using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DPA202302ParcialCaso0221100322.Models;

public partial class Dpa202302parcialCaso0221100322Context : DbContext
{
    public Dpa202302parcialCaso0221100322Context()
    {
    }

    public Dpa202302parcialCaso0221100322Context(DbContextOptions<Dpa202302parcialCaso0221100322Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Country> Country { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=WS2302503;Database=DPA202302ParcialCaso0221100322;User=sa;Pwd=123456789;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Country>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Description)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
