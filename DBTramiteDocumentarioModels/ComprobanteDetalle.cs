using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBTramiteDocumentarioModels;

[PrimaryKey("IdComprobante", "IdMaterial")]
[Table("ComprobanteDetalle")]
public partial class ComprobanteDetalle
{
    public int? Cantidad { get; set; }

    [StringLength(20)]
    public string? Unidad { get; set; }

    [Key]
    [StringLength(10)]
    public string IdComprobante { get; set; } = null!;

    [Key]
    public int IdMaterial { get; set; }

    [StringLength(18)]
    [Unicode(false)]
    public string? PrecioUnitario { get; set; }

    [ForeignKey("IdComprobante")]
    [InverseProperty("ComprobanteDetalles")]
    public virtual ComprobanteProvedor IdComprobanteNavigation { get; set; } = null!;

    [ForeignKey("IdMaterial")]
    [InverseProperty("ComprobanteDetalles")]
    public virtual Material IdMaterialNavigation { get; set; } = null!;
}
