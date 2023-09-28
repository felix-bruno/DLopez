using DBTramiteDocumentarioModels;
using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    /// <summary>
    /// Herencia de Repository de crud generico.
    /// tambien podemos crear propios metodos.
    /// </summary>
    public class RepositoryArea:RespositoryCrud<Area>,IRepositoryArea
    {
    }
}
