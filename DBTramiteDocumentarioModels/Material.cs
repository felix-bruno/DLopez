using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBTramiteDocumentarioModels;

[Table("Material")]
public partial class Material
{
    [Key]
    public int IdMaterial { get; set; }

    [StringLength(50)]
    public string NombreMaterial { get; set; } = null!;

    public int Stock { get; set; }

    [StringLength(20)]
    public string Unidad { get; set; } = null!;

    [InverseProperty("IdMaterialNavigation")]
    public virtual ICollection<ComprobanteDetalle> ComprobanteDetalles { get; set; } = new List<ComprobanteDetalle>();

    [InverseProperty("IdMaterialNavigation")]
    public virtual ICollection<IngresoMaterial> IngresoMaterials { get; set; } = new List<IngresoMaterial>();

    [InverseProperty("IdMaterialNavigation")]
    public virtual ICollection<SalidaMaterial> SalidaMaterials { get; set; } = new List<SalidaMaterial>();
}
