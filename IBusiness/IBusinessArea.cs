using RequestResponstModels.Request;
using RequestResponstModels.Responst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusiness
{
    /// <summary>
    /// Hereda los metodos de la interface Crud Business
    /// Tambien es permitido crear propios métodos
    /// </summary>
    public interface IBusinessArea:IBusinessCrud<RequestArea,ResponseArea>
    {
    }
}
