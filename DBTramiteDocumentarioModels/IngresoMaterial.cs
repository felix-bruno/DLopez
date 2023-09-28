using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBTramiteDocumentarioModels;

[PrimaryKey("IdComprobante", "IdMaterial")]
[Table("IngresoMaterial")]
public partial class IngresoMaterial
{
    [StringLength(18)]
    [Unicode(false)]
    public string? FechaIngreso { get; set; }

    [StringLength(18)]
    [Unicode(false)]
    public string? Cantidad { get; set; }

    [Key]
    [StringLength(10)]
    public string IdComprobante { get; set; } = null!;

    [Key]
    public int IdMaterial { get; set; }

    [StringLength(50)]
    public string? Estado { get; set; }

    [ForeignKey("IdComprobante")]
    [InverseProperty("IngresoMaterials")]
    public virtual ComprobanteProvedor IdComprobanteNavigation { get; set; } = null!;

    [ForeignKey("IdMaterial")]
    [InverseProperty("IngresoMaterials")]
    public virtual Material IdMaterialNavigation { get; set; } = null!;
}
