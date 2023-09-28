using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBTramiteDocumentarioModels;

[Table("Persona")]
public partial class Persona
{
    [Key]
    public int IdPersona { get; set; }

    [StringLength(50)]
    public string NombrePersona { get; set; } = null!;

    [StringLength(30)]
    public string TipoPersona { get; set; } = null!;

    [StringLength(15)]
    public string TipoDocumento { get; set; } = null!;

    [StringLength(20)]
    public string NumeroDocumento { get; set; } = null!;

    [StringLength(15)]
    public string Telefono { get; set; } = null!;

    [StringLength(6)]
    [Unicode(false)]
    public string? CodigoUbigeo { get; set; }

    [StringLength(50)]
    public string? Direccion { get; set; }

    [InverseProperty("IdPersonaNavigation")]
    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    [InverseProperty("IdPersonaNavigation")]
    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();

    [InverseProperty("IdPersonaNavigation")]
    public virtual ICollection<Provedor> Provedors { get; set; } = new List<Provedor>();

    [InverseProperty("IdPersonaNavigation")]
    public virtual ICollection<Trasporte> Trasportes { get; set; } = new List<Trasporte>();

    [InverseProperty("IdPersonaNavigation")]
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
