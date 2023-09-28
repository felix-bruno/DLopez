using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBTramiteDocumentarioModels;

[Table("Historial")]
public partial class Historial
{
    [Key]
    public int IdHistorial { get; set; }

    public int IdUsuario { get; set; }

    [StringLength(50)]
    public string? Rol { get; set; }

    public int IdPersona { get; set; }

    public string? Detalle { get; set; }

    public string? TableName { get; set; }

    public int IdTable { get; set; }
}
