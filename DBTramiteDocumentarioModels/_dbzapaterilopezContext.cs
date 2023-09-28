using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DBTramiteDocumentarioModels;

public partial class _dbzapaterilopezContext : DbContext
{
    public _dbzapaterilopezContext()
    {
    }

    public _dbzapaterilopezContext(DbContextOptions<_dbzapaterilopezContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<ComprobanteDetalle> ComprobanteDetalles { get; set; }

    public virtual DbSet<ComprobanteProvedor> ComprobanteProvedors { get; set; }

    public virtual DbSet<ControlProduccion> ControlProduccions { get; set; }

    public virtual DbSet<Credito> Creditos { get; set; }

    public virtual DbSet<DetalleCredio> DetalleCredios { get; set; }

    public virtual DbSet<DetalleOrden> DetalleOrdens { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Error> Errors { get; set; }

    public virtual DbSet<Historial> Historials { get; set; }

    public virtual DbSet<IngresoMaterial> IngresoMaterials { get; set; }

    public virtual DbSet<IngresoProducto> IngresoProductos { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<Modelo> Modelos { get; set; }

    public virtual DbSet<Orden> Ordens { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Produccion> Produccions { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Provedor> Provedors { get; set; }

    public virtual DbSet<SalidaMaterial> SalidaMaterials { get; set; }

    public virtual DbSet<SalidaProducto> SalidaProductos { get; set; }

    public virtual DbSet<Trasporte> Trasportes { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=zapaterilopez;Integrated Security=True;Trusted_Connection=true;Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.IdArea).HasName("XPKArea");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("XPKCliente");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Clientes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_117");
        });

        modelBuilder.Entity<ComprobanteDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdComprobante, e.IdMaterial }).HasName("XPKComprobanteDetalle");

            entity.Property(e => e.PrecioUnitario).IsFixedLength();

            entity.HasOne(d => d.IdComprobanteNavigation).WithMany(p => p.ComprobanteDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_99");

            entity.HasOne(d => d.IdMaterialNavigation).WithMany(p => p.ComprobanteDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_100");
        });

        modelBuilder.Entity<ComprobanteProvedor>(entity =>
        {
            entity.HasKey(e => e.IdComprobante).HasName("XPKComprobanteProvedor");

            entity.HasOne(d => d.IdProvedorNavigation).WithMany(p => p.ComprobanteProvedors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_98");
        });

        modelBuilder.Entity<ControlProduccion>(entity =>
        {
            entity.HasKey(e => new { e.IdProduccion, e.IdArea, e.IdEmpleado }).HasName("XPKControlProduccion");

            entity.HasOne(d => d.IdAreaNavigation).WithMany(p => p.ControlProduccions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_108");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.ControlProduccions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_114");

            entity.HasOne(d => d.IdProduccionNavigation).WithMany(p => p.ControlProduccions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_107");
        });

        modelBuilder.Entity<Credito>(entity =>
        {
            entity.HasKey(e => e.IdCredito).HasName("XPKCredito");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Creditos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_123");
        });

        modelBuilder.Entity<DetalleCredio>(entity =>
        {
            entity.HasKey(e => new { e.IdOrden, e.IdCredito }).HasName("XPKDetalle_Credio");

            entity.HasOne(d => d.IdCreditoNavigation).WithMany(p => p.DetalleCredios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_122");

            entity.HasOne(d => d.IdOrdenNavigation).WithMany(p => p.DetalleCredios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_72");
        });

        modelBuilder.Entity<DetalleOrden>(entity =>
        {
            entity.HasKey(e => new { e.IdOrden, e.IdProducto, e.Talla }).HasName("XPKDetalleOrden");

            entity.Property(e => e.Talla).IsFixedLength();

            entity.HasOne(d => d.IdOrdenNavigation).WithMany(p => p.DetalleOrdens)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_116");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.DetalleOrdens)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_115");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpleado).HasName("XPKEmpleado");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Empleados)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_112");
        });

        modelBuilder.Entity<Error>(entity =>
        {
            entity.HasKey(e => e.IdError).HasName("XPKError");
        });

        modelBuilder.Entity<Historial>(entity =>
        {
            entity.HasKey(e => e.IdHistorial).HasName("XPKHistorial");
        });

        modelBuilder.Entity<IngresoMaterial>(entity =>
        {
            entity.HasKey(e => new { e.IdComprobante, e.IdMaterial }).HasName("XPKIngresoMaterial");

            entity.Property(e => e.Cantidad).IsFixedLength();
            entity.Property(e => e.FechaIngreso).IsFixedLength();

            entity.HasOne(d => d.IdComprobanteNavigation).WithMany(p => p.IngresoMaterials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_101");

            entity.HasOne(d => d.IdMaterialNavigation).WithMany(p => p.IngresoMaterials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_102");
        });

        modelBuilder.Entity<IngresoProducto>(entity =>
        {
            entity.HasKey(e => new { e.IdProduccion, e.IdProducto }).HasName("XPKIngresoProducto");

            entity.HasOne(d => d.IdProduccionNavigation).WithMany(p => p.IngresoProductos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_110");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.IngresoProductos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_111");
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.IdMaterial).HasName("XPKMaterial");
        });

        modelBuilder.Entity<Modelo>(entity =>
        {
            entity.HasKey(e => e.IdModelo).HasName("XPKModelo");

            entity.Property(e => e.Categoria).IsFixedLength();
            entity.Property(e => e.Talla).IsFixedLength();
        });

        modelBuilder.Entity<Orden>(entity =>
        {
            entity.HasKey(e => e.IdOrden).HasName("XPKOrden");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Ordens)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_74");

            entity.HasOne(d => d.IdTrasporteNavigation).WithMany(p => p.Ordens)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_27");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.IdPersona).HasName("XPKPersona");
        });

        modelBuilder.Entity<Produccion>(entity =>
        {
            entity.HasKey(e => e.IdProduccion).HasName("XPKProduccion");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("XPKProducto");

            entity.HasOne(d => d.IdModeloNavigation).WithMany(p => p.Productos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_85");
        });

        modelBuilder.Entity<Provedor>(entity =>
        {
            entity.HasKey(e => e.IdProvedor).HasName("XPKProvedor");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Provedors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_97");
        });

        modelBuilder.Entity<SalidaMaterial>(entity =>
        {
            entity.HasKey(e => new { e.IdProduccion, e.IdMaterial }).HasName("XPKSalidaMaterial");

            entity.HasOne(d => d.IdMaterialNavigation).WithMany(p => p.SalidaMaterials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_104");

            entity.HasOne(d => d.IdProduccionNavigation).WithMany(p => p.SalidaMaterials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_103");
        });

        modelBuilder.Entity<SalidaProducto>(entity =>
        {
            entity.HasKey(e => new { e.IdProducto, e.IdOrden, e.Talla }).HasName("XPKSalidaProducto");

            entity.HasOne(d => d.IdOrdenNavigation).WithMany(p => p.SalidaProductos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_120");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.SalidaProductos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_119");
        });

        modelBuilder.Entity<Trasporte>(entity =>
        {
            entity.HasKey(e => e.IdTrasporte).HasName("XPKTrasporte");

            entity.Property(e => e.TipoAutomovil).IsFixedLength();

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Trasportes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_118");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("XPKUsuario");

            entity.Property(e => e.IdUsuario).IsFixedLength();
            entity.Property(e => e.Rol).IsFixedLength();

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Usuarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_121");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
