using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBTramiteDocumentarioModels;

[Table("Cliente")]
public partial class Cliente
{
    [Key]
    public int IdCliente { get; set; }

    public int IdPersona { get; set; }

    [InverseProperty("IdClienteNavigation")]
    public virtual ICollection<Credito> Creditos { get; set; } = new List<Credito>();

    [ForeignKey("IdPersona")]
    [InverseProperty("Clientes")]
    public virtual Persona IdPersonaNavigation { get; set; } = null!;

    [InverseProperty("IdClienteNavigation")]
    public virtual ICollection<Orden> Ordens { get; set; } = new List<Orden>();
}
