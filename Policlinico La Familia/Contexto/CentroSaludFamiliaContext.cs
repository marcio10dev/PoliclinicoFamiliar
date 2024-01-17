using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Policlinico_La_Familia.Modelos;

namespace Policlinico_La_Familia.Contexto;

public partial class CentroSaludFamiliaContext : DbContext
{
    public CentroSaludFamiliaContext()
    {
    }

    public CentroSaludFamiliaContext(DbContextOptions<CentroSaludFamiliaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cita> Citas { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<HistorialesMedico> HistorialesMedicos { get; set; }

    public virtual DbSet<Medico> Medicos { get; set; }

    public virtual DbSet<Paciente> Pacientes { get; set; }

    public virtual DbSet<Receta> Recetas { get; set; }

    public virtual DbSet<ServiciosMedico> ServiciosMedicos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(local); Initial Catalog=CentroSaludFamilia; Integrated Security=True; TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cita>(entity =>
        {
            entity.HasKey(e => e.Idcita).HasName("PK__Citas__36D350AB1E3846EA");

            entity.Property(e => e.Idcita).ValueGeneratedNever();

            entity.HasOne(d => d.IdmédicoNavigation).WithMany(p => p.Cita).HasConstraintName("FK__Citas__IDMédico__3C69FB99");

            entity.HasOne(d => d.IdpacienteNavigation).WithMany(p => p.Cita).HasConstraintName("FK__Citas__IDPacient__3B75D760");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.Idfactura).HasName("PK__Facturas__492FE939A4388647");

            entity.Property(e => e.Idfactura).ValueGeneratedNever();

            entity.HasOne(d => d.IdcitaNavigation).WithMany(p => p.Facturas).HasConstraintName("FK__Facturas__IDCita__45F365D3");
        });

        modelBuilder.Entity<HistorialesMedico>(entity =>
        {
            entity.HasKey(e => e.Idhistorial).HasName("PK__Historia__C4BEFB69308FC940");

            entity.Property(e => e.Idhistorial).ValueGeneratedNever();

            entity.HasOne(d => d.IdmédicoNavigation).WithMany(p => p.HistorialesMedicos).HasConstraintName("FK__Historial__IDMéd__403A8C7D");

            entity.HasOne(d => d.IdpacienteNavigation).WithMany(p => p.HistorialesMedicos).HasConstraintName("FK__Historial__IDPac__3F466844");
        });

        modelBuilder.Entity<Medico>(entity =>
        {
            entity.HasKey(e => e.Idmédico).HasName("PK__Medicos__13342CA1CB2D4F92");

            entity.Property(e => e.Idmédico).ValueGeneratedNever();
        });

        modelBuilder.Entity<Paciente>(entity =>
        {
            entity.HasKey(e => e.Idpaciente).HasName("PK__Paciente__94DF170F339AB381");

            entity.Property(e => e.Idpaciente).ValueGeneratedNever();
        });

        modelBuilder.Entity<Receta>(entity =>
        {
            entity.HasKey(e => e.Idreceta).HasName("PK__Recetas__91B4C6BC811E75B2");

            entity.Property(e => e.Idreceta).ValueGeneratedNever();

            entity.HasOne(d => d.IdhistorialNavigation).WithMany(p => p.Receta).HasConstraintName("FK__Recetas__IDHisto__4316F928");
        });

        modelBuilder.Entity<ServiciosMedico>(entity =>
        {
            entity.HasKey(e => e.Idservicio).HasName("PK__Servicio__3CCE7416588638F2");

            entity.Property(e => e.Idservicio).ValueGeneratedNever();

            entity.HasOne(d => d.IdcitaNavigation).WithMany(p => p.ServiciosMedicos).HasConstraintName("FK__Servicios__IDCit__48CFD27E");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
