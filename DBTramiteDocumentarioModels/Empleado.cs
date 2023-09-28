using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBTramiteDocumentarioModels;

[Table("Empleado")]
public partial class Empleado
{
    [Key]
    public int IdEmpleado { get; set; }

    [StringLength(30)]
    public string? ApellidoEmp { get; set; }

    [Column(TypeName = "money")]
    public decimal Salario { get; set; }

    public int IdPersona { get; set; }

    [InverseProperty("IdEmpleadoNavigation")]
    public virtual ICollection<ControlProduccion> ControlProduccions { get; set; } = new List<ControlProduccion>();

    [ForeignKey("IdPersona")]
    [InverseProperty("Empleados")]
    public virtual Persona IdPersonaNavigation { get; set; } = null!;
}
