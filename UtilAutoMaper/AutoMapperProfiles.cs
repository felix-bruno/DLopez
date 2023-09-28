using AutoMapper;
using DBTramiteDocumentarioModels;
using RequestResponstModels.Request;
using RequestResponstModels.Responst;

namespace UtilAutoMaper
{
    /// <summary>
    /// Clase AutoMapperProflies que sirve para maper los datos de las tablas.
    /// </summary>
    public class AutoMapperProfiles:Profile
    {
        /// <summary>
        /// El constructor de la clase AutoMapperProfiles
        /// </summary>
        public AutoMapperProfiles() 
        {
            //Mapeo de la tabla Area
            CreateMap<Area, RequestArea>().ReverseMap();
            CreateMap<Area, ResponseArea>().ReverseMap();
            CreateMap<RequestArea,ResponseArea>().ReverseMap(); 
        }
    }
}