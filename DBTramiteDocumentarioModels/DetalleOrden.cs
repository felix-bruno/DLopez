using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBTramiteDocumentarioModels;

[PrimaryKey("IdOrden", "IdProducto", "Talla")]
[Table("DetalleOrden")]
public partial class DetalleOrden
{
    [Column(TypeName = "money")]
    public decimal PrecioUnitario { get; set; }

    public int Cantidad { get; set; }

    [Key]
    [StringLength(18)]
    [Unicode(false)]
    public string Talla { get; set; } = null!;

    [StringLength(20)]
    public string Unidad { get; set; } = null!;

    [Key]
    public int IdProducto { get; set; }

    [Key]
    [StringLength(10)]
    public string IdOrden { get; set; } = null!;

    [ForeignKey("IdOrden")]
    [InverseProperty("DetalleOrdens")]
    public virtual Orden IdOrdenNavigation { get; set; } = null!;

    [ForeignKey("IdProducto")]
    [InverseProperty("DetalleOrdens")]
    public virtual Producto IdProductoNavigation { get; set; } = null!;
}
