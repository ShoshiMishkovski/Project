﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dal.Models;

public partial class NutritionContext : DbContext
{
    public NutritionContext(DbContextOptions<NutritionContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Dietitian> Dietitians { get; set; }

    public virtual DbSet<Meeting> Meetings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Clients_pk");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("firstName");
            entity.Property(e => e.Kind)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("kind");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("phone");
        });

        modelBuilder.Entity<Dietitian>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Dietitians_pk");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(25)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("firstName");
            entity.Property(e => e.Kind)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("kind");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("phone");
        });

        modelBuilder.Entity<Meeting>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("Meetings_pk");

            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.ClientsId).HasColumnName("clientsId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DieticanId).HasColumnName("dieticanId");
            entity.Property(e => e.Hour)
                .HasColumnType("datetime")
                .HasColumnName("hour");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("status");

            entity.HasOne(d => d.Clients).WithMany(p => p.Meetings)
                .HasForeignKey(d => d.ClientsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("clientsId_fk");

            entity.HasOne(d => d.Dietican).WithMany(p => p.Meetings)
                .HasForeignKey(d => d.DieticanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("dieticanId_fk");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
