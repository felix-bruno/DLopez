using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBTramiteDocumentarioModels;

[Table("Produccion")]
public partial class Produccion
{
    [Key]
    [StringLength(10)]
    public string IdProduccion { get; set; } = null!;

    public int Meta { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaInicio { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaFinal { get; set; }

    [StringLength(20)]
    public string Unidad { get; set; } = null!;

    [StringLength(20)]
    public string EstadoProduccion { get; set; } = null!;

    [InverseProperty("IdProduccionNavigation")]
    public virtual ICollection<ControlProduccion> ControlProduccions { get; set; } = new List<ControlProduccion>();

    [InverseProperty("IdProduccionNavigation")]
    public virtual ICollection<IngresoProducto> IngresoProductos { get; set; } = new List<IngresoProducto>();

    [InverseProperty("IdProduccionNavigation")]
    public virtual ICollection<SalidaMaterial> SalidaMaterials { get; set; } = new List<SalidaMaterial>();
}
