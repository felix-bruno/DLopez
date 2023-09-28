using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBTramiteDocumentarioModels;

[Table("Modelo")]
public partial class Modelo
{
    [Key]
    public int IdModelo { get; set; }

    [StringLength(30)]
    public string? NombreModelo { get; set; }

    [StringLength(10)]
    public string? CodigoModelo { get; set; }

    [StringLength(100)]
    public string? Descripcion { get; set; }

    [StringLength(18)]
    [Unicode(false)]
    public string? Talla { get; set; }

    [StringLength(18)]
    [Unicode(false)]
    public string? Categoria { get; set; }

    [InverseProperty("IdModeloNavigation")]
    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
