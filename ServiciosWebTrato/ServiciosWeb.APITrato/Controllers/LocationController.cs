using ApiTrato.Core.Entities;
using ApiTrato.Core.Interfaces;
using ApiTrato.Infraestructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiciosWeb.APITrato.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class LocationController : Controller
    {
        private readonly ILocationRepository _context;
        public LocationController(ILocationRepository context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetLocations()
        {
            var locations = await _context.GetLocations();
            return Ok(locations);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLocacion(int id)
        {
            var location = await _context.GetLocation(id);
            return Ok(location);
        }
        public async Task<IActionResult> InsertLocation(Locations locations)
        {
            await _context.InsertLocation(locations);
            return Ok(locations);
        }
    }
}
