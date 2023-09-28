using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBTramiteDocumentarioModels;

[PrimaryKey("IdProducto", "IdOrden", "Talla")]
[Table("SalidaProducto")]
public partial class SalidaProducto
{
    [Key]
    public int IdProducto { get; set; }

    [Key]
    [StringLength(10)]
    public string IdOrden { get; set; } = null!;

    public int Cantidad { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaSalida { get; set; }

    [Key]
    [StringLength(5)]
    public string Talla { get; set; } = null!;

    [ForeignKey("IdOrden")]
    [InverseProperty("SalidaProductos")]
    public virtual Orden IdOrdenNavigation { get; set; } = null!;

    [ForeignKey("IdProducto")]
    [InverseProperty("SalidaProductos")]
    public virtual Producto IdProductoNavigation { get; set; } = null!;
}
