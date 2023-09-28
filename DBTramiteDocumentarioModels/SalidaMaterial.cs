using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBTramiteDocumentarioModels;

[PrimaryKey("IdProduccion", "IdMaterial")]
[Table("SalidaMaterial")]
public partial class SalidaMaterial
{
    public int Cantidad { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaSalida { get; set; }

    [StringLength(20)]
    public string UnidadMaterial { get; set; } = null!;

    [Key]
    [StringLength(10)]
    public string IdProduccion { get; set; } = null!;

    [Key]
    public int IdMaterial { get; set; }

    [ForeignKey("IdMaterial")]
    [InverseProperty("SalidaMaterials")]
    public virtual Material IdMaterialNavigation { get; set; } = null!;

    [ForeignKey("IdProduccion")]
    [InverseProperty("SalidaMaterials")]
    public virtual Produccion IdProduccionNavigation { get; set; } = null!;
}
