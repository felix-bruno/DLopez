using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBTramiteDocumentarioModels;

[Table("Usuario")]
public partial class Usuario
{
    [Key]
    [StringLength(18)]
    [Unicode(false)]
    public string IdUsuario { get; set; } = null!;

    [Column("Usuario")]
    [StringLength(30)]
    public string Usuario1 { get; set; } = null!;

    [StringLength(15)]
    public string Password { get; set; } = null!;

    [StringLength(30)]
    public string Email { get; set; } = null!;

    public int IdPersona { get; set; }

    [StringLength(18)]
    [Unicode(false)]
    public string? Rol { get; set; }

    [ForeignKey("IdPersona")]
    [InverseProperty("Usuarios")]
    public virtual Persona IdPersonaNavigation { get; set; } = null!;
}
