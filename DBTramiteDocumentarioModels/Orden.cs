using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBTramiteDocumentarioModels;

[Table("Orden")]
public partial class Orden
{
    [Key]
    [StringLength(10)]
    public string IdOrden { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FechaOrden { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaRequerido { get; set; }

    public int IdTrasporte { get; set; }

    [StringLength(20)]
    public string EstadoOrden { get; set; } = null!;

    public int IdCliente { get; set; }

    public bool TipoOrden { get; set; }

    [InverseProperty("IdOrdenNavigation")]
    public virtual ICollection<DetalleCredio> DetalleCredios { get; set; } = new List<DetalleCredio>();

    [InverseProperty("IdOrdenNavigation")]
    public virtual ICollection<DetalleOrden> DetalleOrdens { get; set; } = new List<DetalleOrden>();

    [ForeignKey("IdCliente")]
    [InverseProperty("Ordens")]
    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    [ForeignKey("IdTrasporte")]
    [InverseProperty("Ordens")]
    public virtual Trasporte IdTrasporteNavigation { get; set; } = null!;

    [InverseProperty("IdOrdenNavigation")]
    public virtual ICollection<SalidaProducto> SalidaProductos { get; set; } = new List<SalidaProducto>();
}
