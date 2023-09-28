using AutoMapper;
using DBTramiteDocumentarioModels;
using DocumentFormat.OpenXml.Vml.Office;
using IBusiness;
using IRepository;
using Repository;
using RequestResponstModels.Request;
using RequestResponstModels.Responst;
using System.Security.AccessControl;

namespace Business
{
    public class BusinessArea : IBusinessArea
    {
        #region Inyecciones
        private readonly IRepositoryArea _repositoryArea;
        private readonly IMapper _mapper;
        public BusinessArea(IMapper mapper)
        {
            _mapper = mapper;
            _repositoryArea = new RepositoryArea();
        }
        #endregion Inyecciones
        #region Crud Generico
        public ResponseArea Create(RequestArea entity)
        {
            Area area = _mapper.Map<Area>(entity);
            area = _repositoryArea.Create(area);
            ResponseArea response = _mapper.Map<ResponseArea>(area);
            return response;
        }

        public List<ResponseArea> CreateMultiple(List<RequestArea> lista)
        {
            List<Area> area = _mapper.Map<List<Area>>(lista);
            area = _repositoryArea.CreateMultiple(area);
            List<ResponseArea> response = _mapper.Map<List<ResponseArea>>(area);
            return response;
        }

        public int Delete(int id)
        {
            int contar = _repositoryArea.Delete(id);
            return contar;
        }

        public int DeleteMultiple(List<RequestArea> lista)
        {
            List<Area> area = _mapper.Map<List<Area>>(lista);
            int contar = _repositoryArea.DeleteMultiple(area);
            return contar;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<ResponseArea> GetAll()
        {
            List<Area> area = _repositoryArea.GetAll();
            List<ResponseArea> response = _mapper.Map<List<ResponseArea>>(area);
            return response;
        }

        public ResponseArea GetById(int id)
        {
            Area area = _repositoryArea.GetById(id);
            ResponseArea response = _mapper.Map<ResponseArea>(area);
            return response;
        }

        public ResponseArea Update(RequestArea entity)
        {
            Area area = _mapper.Map<Area>(entity);
            area = _repositoryArea.Update(area);
            ResponseArea response = _mapper.Map<ResponseArea>(area);
            return response;
        }

        public List<ResponseArea> UpdateMultiple(List<RequestArea> lista)
        {
            List<Area> area = _mapper.Map<List<Area>>(lista);
            area = _repositoryArea.UpdateMultiple(area);
            List<ResponseArea> response = _mapper.Map<List<ResponseArea>>(area);
            return response;
        }
   
        
        #endregion Crud Generico
    }
}