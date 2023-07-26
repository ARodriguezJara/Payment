using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Payment.Models;

public partial class PaymentsContext : DbContext
{
    public PaymentsContext()
    {
    }

    public PaymentsContext(DbContextOptions<PaymentsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Record> Record { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-R3VP92L; Database=Payments; Trusted_Connection=True; TrustServerCertificate=True ");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Record>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__Table__9B556A388A401B4C");

            entity.ToTable("Record");

            entity.Property(e => e.Concept).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
