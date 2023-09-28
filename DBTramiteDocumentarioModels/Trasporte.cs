using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBTramiteDocumentarioModels;

[Table("Trasporte")]
public partial class Trasporte
{
    [Key]
    public int IdTrasporte { get; set; }

    [StringLength(20)]
    public string? NumeroPlaca { get; set; }

    [StringLength(50)]
    public string? LicenciaConductor { get; set; }

    [StringLength(18)]
    [Unicode(false)]
    public string? TipoAutomovil { get; set; }

    public int IdPersona { get; set; }

    [ForeignKey("IdPersona")]
    [InverseProperty("Trasportes")]
    public virtual Persona IdPersonaNavigation { get; set; } = null!;

    [InverseProperty("IdTrasporteNavigation")]
    public virtual ICollection<Orden> Ordens { get; set; } = new List<Orden>();
}
