using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace Curs_Radaeva.Models;

public partial class Ispr2525RadaevaVaKursachContext : DbContext
{
    public Ispr2525RadaevaVaKursachContext()
    {
    }

    public Ispr2525RadaevaVaKursachContext(DbContextOptions<Ispr2525RadaevaVaKursachContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<AdminView> AdminViews { get; set; }

    public virtual DbSet<Authorization> Authorizations { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Driver> Drivers { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Route> Routes { get; set; }

    public virtual DbSet<StatusDriver> StatusDrivers { get; set; }

    public virtual DbSet<TimeTable> TimeTables { get; set; }

    public virtual DbSet<Transport> Transports { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=cfif31.ru;database=ISPr25-25_RadaevaVA_Kursach;uid=ISPr25-25_RadaevaVA;pwd=ISPr25-25_RadaevaVA", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.42-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.IdAdmin).HasName("PRIMARY");

            entity.ToTable("Admin");

            entity.HasIndex(e => e.IdAuthorization, "IdUser").IsUnique();

            entity.Property(e => e.NameAdmin).HasMaxLength(45);

            entity.HasOne(d => d.IdAuthorizationNavigation).WithOne(p => p.Admin)
                .HasForeignKey<Admin>(d => d.IdAuthorization)
                .HasConstraintName("fk_Admin_User");
        });

        modelBuilder.Entity<AdminView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("AdminView");
        });

        modelBuilder.Entity<Authorization>(entity =>
        {
            entity.HasKey(e => e.IdAuthorization).HasName("PRIMARY");

            entity.ToTable("Authorization");

            entity.HasIndex(e => e.IdRole, "FK_Avtorizacia_Role");

            entity.HasIndex(e => e.Login, "Login").IsUnique();

            entity.Property(e => e.Login).HasMaxLength(45);
            entity.Property(e => e.Password).HasMaxLength(105);

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Authorizations)
                .HasForeignKey(d => d.IdRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Authorization_ibfk_1");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.IdClient).HasName("PRIMARY");

            entity.ToTable("Client");

            entity.HasIndex(e => e.IdAvtorizacia, "IdUser").IsUnique();

            entity.Property(e => e.NameClient).HasMaxLength(45);

            entity.HasOne(d => d.IdAvtorizaciaNavigation).WithOne(p => p.Client)
                .HasForeignKey<Client>(d => d.IdAvtorizacia)
                .HasConstraintName("fk_Client_User");
        });

        modelBuilder.Entity<Driver>(entity =>
        {
            entity.HasKey(e => e.IdDrivers).HasName("PRIMARY");

            entity.HasIndex(e => e.IdAuthorization, "IdUser").IsUnique();

            entity.HasIndex(e => e.IdStatusDrivers, "fk_timetable_idStatusDrivers_idx");

            entity.Property(e => e.NameDrivers).HasMaxLength(45);

            entity.HasOne(d => d.IdAuthorizationNavigation).WithOne(p => p.Driver)
                .HasForeignKey<Driver>(d => d.IdAuthorization)
                .HasConstraintName("fk_Drivers_Avtorizacia");

            entity.HasOne(d => d.IdStatusDriversNavigation).WithMany(p => p.Drivers)
                .HasForeignKey(d => d.IdStatusDrivers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_timetable_idStatusDrivers");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.IdRole).HasName("PRIMARY");

            entity.ToTable("Role");

            entity.Property(e => e.NameRole).HasMaxLength(45);
        });

        modelBuilder.Entity<Route>(entity =>
        {
            entity.HasKey(e => e.IdRoutes).HasName("PRIMARY");

            entity.Property(e => e.EndLocationRoutes).HasMaxLength(45);
            entity.Property(e => e.StartLocationRoutes).HasMaxLength(45);
            entity.Property(e => e.TravelTimeRoutes).HasColumnType("time");
        });

        modelBuilder.Entity<StatusDriver>(entity =>
        {
            entity.HasKey(e => e.IdStatusDrivers).HasName("PRIMARY");

            entity.Property(e => e.NameStatusDrivers).HasMaxLength(45);
        });

        modelBuilder.Entity<TimeTable>(entity =>
        {
            entity.HasKey(e => e.IdTimeTable).HasName("PRIMARY");

            entity.ToTable("TimeTable");

            entity.HasIndex(e => e.IdDrivers, "fk_timetable_idDrivers_idx");

            entity.HasIndex(e => e.IdRoutes, "fk_timetable_idRoutes_idx");

            entity.HasIndex(e => e.IdTransport, "fk_timetable_idTransport_idx");

            entity.Property(e => e.ArrivalTime).HasColumnType("time");
            entity.Property(e => e.DepartureTime).HasColumnType("time");

            entity.HasOne(d => d.Driver).WithMany(p => p.TimeTables)
                .HasForeignKey(d => d.IdDrivers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_timetable_idDrivers");

            entity.HasOne(d => d.Route).WithMany(p => p.TimeTables)
                .HasForeignKey(d => d.IdRoutes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_timetable_idRoutes");

            entity.HasOne(d => d.Transport).WithMany(p => p.TimeTables)
                .HasForeignKey(d => d.IdTransport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_timetable_idTransport");
        });

        modelBuilder.Entity<Transport>(entity =>
        {
            entity.HasKey(e => e.IdTransport).HasName("PRIMARY");

            entity.ToTable("Transport");

            entity.Property(e => e.HeightTransport).HasPrecision(5, 2);
            entity.Property(e => e.LongTransport).HasPrecision(5, 2);
            entity.Property(e => e.NumberplateTransport).HasMaxLength(9);
            entity.Property(e => e.WidthTransport).HasPrecision(5, 2);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
