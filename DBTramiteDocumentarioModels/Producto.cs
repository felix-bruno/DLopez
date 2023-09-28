using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBTramiteDocumentarioModels;

[Table("Producto")]
public partial class Producto
{
    [Key]
    public int IdProducto { get; set; }

    [StringLength(40)]
    public string? NombreProd { get; set; }

    [StringLength(20)]
    public string? CodigoProd { get; set; }

    [Column(TypeName = "money")]
    public decimal? PrecioUnitario { get; set; }

    public int Stock { get; set; }

    public int IdModelo { get; set; }

    [StringLength(20)]
    public string? Color { get; set; }

    public bool EstadoProducto { get; set; }

    [InverseProperty("IdProductoNavigation")]
    public virtual ICollection<DetalleOrden> DetalleOrdens { get; set; } = new List<DetalleOrden>();

    [ForeignKey("IdModelo")]
    [InverseProperty("Productos")]
    public virtual Modelo IdModeloNavigation { get; set; } = null!;

    [InverseProperty("IdProductoNavigation")]
    public virtual ICollection<IngresoProducto> IngresoProductos { get; set; } = new List<IngresoProducto>();

    [InverseProperty("IdProductoNavigation")]
    public virtual ICollection<SalidaProducto> SalidaProductos { get; set; } = new List<SalidaProducto>();
}
