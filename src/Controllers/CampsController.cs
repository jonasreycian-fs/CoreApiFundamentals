using AutoMapper;
using CoreCodeCamp.Data;
using CoreCodeCamp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreCodeCamp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CampsController : Controller
    {
        private readonly ILogger _logger;
        private readonly ICampRepository _repository;
        private readonly IMapper _mapper;

        public CampsController(ILogger logger, ICampRepository repository, IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<CampModel[]>> Get(bool includeTalk = false)
        {
            try
            {
                var results = await _repository.GetAllCampsAsync(includeTalk);
                return _mapper.Map<CampModel[]>(results);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }

        [HttpGet("{moniker}")]
        public ActionResult<CampModel> Get(string moniker)
        {
            try
            {
                var result = _repository.GetCampAsync(moniker);
                if (result == null) return NotFound();
                return _mapper.Map<CampModel>(result);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
    }
}
