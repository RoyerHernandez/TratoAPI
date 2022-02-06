using ApiTrato.Core.Entities;
using ApiTrato.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiciosWeb.APITrato.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class StateController : Controller
    {
        private readonly IStateRepository _context;
        public StateController(IStateRepository context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetStates()
        {
            var states = await _context.GetStates();
            return Ok(states);
        }
        [HttpGet("{id}")]
        public async Task <IActionResult> GetState(int id)
        {
            var state = await _context.GetState(id);
            return Ok(state);
        }
        [HttpPost]
        public async Task<IActionResult> InsertState(States states)
        {
            await _context.InsertState(states);
            return Ok(states);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteState(States states)
        {
            await _context.DeleteState(states);
            return Ok(states);
        }
    }
}
