using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBTramiteDocumentarioModels;

[Table("Credito")]
public partial class Credito
{
    [Key]
    public int IdCredito { get; set; }

    [Column(TypeName = "money")]
    public decimal? MontoTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal? MontoPagado { get; set; }

    [Column(TypeName = "money")]
    public decimal? MontoDeuda { get; set; }

    [StringLength(20)]
    public string? EstadoCredito { get; set; }

    public int IdCliente { get; set; }

    [InverseProperty("IdCreditoNavigation")]
    public virtual ICollection<DetalleCredio> DetalleCredios { get; set; } = new List<DetalleCredio>();

    [ForeignKey("IdCliente")]
    [InverseProperty("Creditos")]
    public virtual Cliente IdClienteNavigation { get; set; } = null!;
}
