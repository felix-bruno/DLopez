using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponstModels.Responst
{
    /// <summary>
    /// Respuesta de la tabla Area
    /// </summary>
    public class ResponseArea
    {
        public int IdArea { get; set; }
        public string? NombreArea { get; set; }
        public string? Descripcion { get; set; }
        //public virtual ICollection<ControlProduccion> ControlProduccions { get; set; } = new List<ControlProduccion>();
    }
}
