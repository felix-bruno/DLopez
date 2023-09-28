using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBTramiteDocumentarioModels;

[Table("Area")]
public partial class Area
{
    [Key]
    public int IdArea { get; set; }

    [StringLength(20)]
    public string? NombreArea { get; set; }

    [StringLength(50)]
    public string? Descripcion { get; set; }

    [InverseProperty("IdAreaNavigation")]
    public virtual ICollection<ControlProduccion> ControlProduccions { get; set; } = new List<ControlProduccion>();
}
