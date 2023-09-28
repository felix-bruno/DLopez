using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponstModels.Request
{
    /// <summary>
    /// Los Requerimiento de la Tabla Area
    /// </summary>
    public class RequestArea
    {
        public int IdArea { get; set; }
        [StringLength(20)]
        public string? NombreArea { get; set; }
        [StringLength(50)]
        public string? Descripcion { get; set; }
        //public virtual ICollection<ControlProduccion> ControlProduccions { get; set; } = new List<ControlProduccion>();
    }
}
