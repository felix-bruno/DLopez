using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBTramiteDocumentarioModels;

[Table("Provedor")]
public partial class Provedor
{
    [Key]
    public int IdProvedor { get; set; }

    public int IdPersona { get; set; }

    [InverseProperty("IdProvedorNavigation")]
    public virtual ICollection<ComprobanteProvedor> ComprobanteProvedors { get; set; } = new List<ComprobanteProvedor>();

    [ForeignKey("IdPersona")]
    [InverseProperty("Provedors")]
    public virtual Persona IdPersonaNavigation { get; set; } = null!;
}
