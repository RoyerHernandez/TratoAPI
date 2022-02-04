using ApiTrato.Core.Entities;
using ApiTrato.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ServiciosWeb.APITrato.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : Controller
    {
        private readonly ICountryRepository _countryRepository;
        public CountryController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetPais()
        {
            var paises = await _countryRepository.GetCountry();
            return Ok(paises);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCountry(int id)
        {
            var paises = await _countryRepository.GetCountry(id);
            return Ok(paises);
        }
        [HttpPost]
        public async Task<IActionResult> Country(Country country)
        {
            await _countryRepository.InsertCountry(country);
            return Ok(country);
        }
    }
}
