using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBTramiteDocumentarioModels;

[Table("ComprobanteProvedor")]
public partial class ComprobanteProvedor
{
    [Column(TypeName = "datetime")]
    public DateTime FechaEntrega { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaPedido { get; set; }

    [Column(TypeName = "money")]
    public decimal CosteTransporte { get; set; }

    [Key]
    [StringLength(10)]
    public string IdComprobante { get; set; } = null!;

    [StringLength(20)]
    public string TipoComprobante { get; set; } = null!;

    [StringLength(20)]
    public string CodigoComprobante { get; set; } = null!;

    public int IdProvedor { get; set; }

    [InverseProperty("IdComprobanteNavigation")]
    public virtual ICollection<ComprobanteDetalle> ComprobanteDetalles { get; set; } = new List<ComprobanteDetalle>();

    [ForeignKey("IdProvedor")]
    [InverseProperty("ComprobanteProvedors")]
    public virtual Provedor IdProvedorNavigation { get; set; } = null!;

    [InverseProperty("IdComprobanteNavigation")]
    public virtual ICollection<IngresoMaterial> IngresoMaterials { get; set; } = new List<IngresoMaterial>();
}
