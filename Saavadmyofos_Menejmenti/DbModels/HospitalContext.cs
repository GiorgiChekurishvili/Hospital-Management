using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace Saavadmyofos_Menejmenti.DbModels;

public partial class HospitalContext : DbContext
{
    public HospitalContext()
    {
    }

    public HospitalContext(DbContextOptions<HospitalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Eqimebi> Eqimebis { get; set; }

    public virtual DbSet<Pacientebi> Pacientebis { get; set; }

    public virtual DbSet<Simptomebi> Simptomebis { get; set; }

    public virtual DbSet<Wamlebi> Wamlebis { get; set; }

    public virtual DbSet<Wvdoma> Wvdomas { get; set; }

    public virtual DbSet<WvdomisTipebi> WvdomisTipebis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=Hospital;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Eqimebi>(entity =>
        {
            entity.HasKey(e => e.EqimisId).HasName("PK__Eqimebi__21EC3C6919D3DD90");

            entity.ToTable("Eqimebi");

            entity.Property(e => e.EqimisId).HasColumnName("EqimisID");
            entity.Property(e => e.Daemata)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.GamocdilebaWeli).HasColumnName("Gamocdileba_Weli");
            entity.Property(e => e.Gvari).HasMaxLength(100);
            entity.Property(e => e.MobilurisNomeri).HasColumnName("Mobiluris_Nomeri");
            entity.Property(e => e.PiradiNomeri).HasColumnName("Piradi_Nomeri");
            entity.Property(e => e.Profesia).HasMaxLength(50);
            entity.Property(e => e.Saxeli).HasMaxLength(50);
            entity.Property(e => e.WvdomisId).HasColumnName("WvdomisID");
        });

        modelBuilder.Entity<Pacientebi>(entity =>
        {
            entity.HasKey(e => e.PacientisId).HasName("PK__Paciente__2CD90B04E3273916");

            entity.ToTable("Pacientebi");

            entity.Property(e => e.PacientisId).HasColumnName("PacientisID");
            entity.Property(e => e.Daemata)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EqimisId).HasColumnName("EqimisID");
            entity.Property(e => e.GadasakhdeliDazghvevit)
                .HasComputedColumnSql("([Gadasakhdeli_Tankha]-coalesce([Dazghveva],(0)))", false)
                .HasColumnName("Gadasakhdeli_Dazghvevit");
            entity.Property(e => e.GadasakhdeliTankha).HasColumnName("Gadasakhdeli_Tankha");
            entity.Property(e => e.Gvari).HasMaxLength(100);
            entity.Property(e => e.MobilurisNomeri).HasColumnName("Mobiluris_Nomeri");
            entity.Property(e => e.PiradiNomeri).HasColumnName("Piradi_Nomeri");
            entity.Property(e => e.Saxeli).HasMaxLength(50);
            entity.Property(e => e.SisxlisJgufi)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Sisxlis_Jgufi");
            entity.Property(e => e.Sqesi).HasMaxLength(50);
        });

        modelBuilder.Entity<Simptomebi>(entity =>
        {
            entity.HasKey(e => e.SimptomisId).HasName("PK__Simptome__3213E83F22A92B5F");

            entity.ToTable("Simptomebi");

            entity.Property(e => e.SimptomisId).HasColumnName("SimptomisID");
            entity.Property(e => e.Daemata)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PacientisId).HasColumnName("PacientisID");
            entity.Property(e => e.Simptomi).HasMaxLength(200);
        });

        modelBuilder.Entity<Wamlebi>(entity =>
        {
            entity.HasKey(e => e.WamlisId).HasName("PK__Wamlebi__3213E83F933CB2D3");

            entity.ToTable("Wamlebi");

            entity.Property(e => e.WamlisId).HasColumnName("WamlisID");
            entity.Property(e => e.Daemata)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EqimisId).HasColumnName("EqimisID");
            entity.Property(e => e.PacientisId).HasColumnName("PacientisID");
            entity.Property(e => e.WamlisSaxeli)
                .HasMaxLength(200)
                .HasColumnName("Wamlis_Saxeli");
        });

        modelBuilder.Entity<Wvdoma>(entity =>
        {
            entity.HasKey(e => e.WvdomisId).HasName("PK__Wvdoma__3213E83FACB737BD");

            entity.ToTable("Wvdoma");

            entity.Property(e => e.WvdomisId).HasColumnName("WvdomisID");
            entity.Property(e => e.MomkhmareblisSaxeli)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Momkhmareblis_saxeli");
            entity.Property(e => e.Paroli)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TipisId).HasColumnName("TipisID");
        });

        modelBuilder.Entity<WvdomisTipebi>(entity =>
        {
            entity.HasKey(e => e.TipisId).HasName("PK__WvdomisT__3213E83F8CE0E37B");

            entity.ToTable("WvdomisTipebi");

            entity.Property(e => e.TipisId).HasColumnName("TipisID");
            entity.Property(e => e.Saxeli)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
