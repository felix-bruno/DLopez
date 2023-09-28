using AutoMapper;
using Business;
using IBusiness;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeb.Controllers
{
    /// <summary>
    /// Api de Area
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AreaController : ControllerBase
    {
        #region
        private readonly IBusinessArea _businessArea;
        private readonly IMapper _mapper;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mapper"></param>
        public AreaController(IMapper mapper)
        {
            _mapper = mapper;
            _businessArea = new BusinessArea(_mapper);
        }
        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Lista de Areas</returns>
        [HttpGet]
        public IActionResult GetAll() => Ok(_businessArea.GetAll());
    }
}
