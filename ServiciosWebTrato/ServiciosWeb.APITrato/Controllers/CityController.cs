using ApiTrato.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ServiciosWeb.APITrato.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : Controller
    {
        private readonly ICityRepository _cityRepository;
        public CityController(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetCity()
        {
            var city = await _cityRepository.GetCity();
            return Ok(city);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCit(int id)
        {
            var city = await _cityRepository.GetCity(id);
            return Ok(city);
        }
    }
}
