using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBTramiteDocumentarioModels;

[PrimaryKey("IdProduccion", "IdProducto")]
[Table("IngresoProducto")]
public partial class IngresoProducto
{
    [Key]
    [StringLength(10)]
    public string IdProduccion { get; set; } = null!;

    [Key]
    public int IdProducto { get; set; }

    public int Cantidad { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaIngreso { get; set; }

    [ForeignKey("IdProduccion")]
    [InverseProperty("IngresoProductos")]
    public virtual Produccion IdProduccionNavigation { get; set; } = null!;

    [ForeignKey("IdProducto")]
    [InverseProperty("IngresoProductos")]
    public virtual Producto IdProductoNavigation { get; set; } = null!;
}
