using DBTramiteDocumentarioModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    /// <summary>
    /// Hereda los métodos genericos de Crud Repository
    /// Puedo Crear mis propias consultas.
    /// </summary>
    public interface IRepositoryArea:IRepositoryCrud<Area>
    {
    }
}
