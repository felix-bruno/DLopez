using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBTramiteDocumentarioModels;

[PrimaryKey("IdProduccion", "IdArea", "IdEmpleado")]
[Table("ControlProduccion")]
public partial class ControlProduccion
{
    public int CantidadProduccion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaRegistro { get; set; }

    [StringLength(10)]
    public string UnidadProduccion { get; set; } = null!;

    [Key]
    [StringLength(10)]
    public string IdProduccion { get; set; } = null!;

    [Key]
    public int IdArea { get; set; }

    [StringLength(50)]
    public string? Descripcion { get; set; }

    [Key]
    public int IdEmpleado { get; set; }

    [ForeignKey("IdArea")]
    [InverseProperty("ControlProduccions")]
    public virtual Area IdAreaNavigation { get; set; } = null!;

    [ForeignKey("IdEmpleado")]
    [InverseProperty("ControlProduccions")]
    public virtual Empleado IdEmpleadoNavigation { get; set; } = null!;

    [ForeignKey("IdProduccion")]
    [InverseProperty("ControlProduccions")]
    public virtual Produccion IdProduccionNavigation { get; set; } = null!;
}
