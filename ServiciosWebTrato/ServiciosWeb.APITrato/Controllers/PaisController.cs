using ApiTrato.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ServiciosWeb.APITrato.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisController : ControllerBase
    {
        private readonly IPaisRepositorio _paisRepositorio;
        public PaisController(IPaisRepositorio paisRepositorio)
        {
            _paisRepositorio = paisRepositorio;
        }
        [HttpGet]
        public async Task<IActionResult> GetPais()
        {
            var paises = await _paisRepositorio.GetPais();
            return Ok(paises);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCountry(int id)
        {
            var paises = await _paisRepositorio.GetCountry(id);
            return Ok(paises);
        }

    }
}
