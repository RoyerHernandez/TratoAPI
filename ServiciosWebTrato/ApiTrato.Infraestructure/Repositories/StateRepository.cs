using ApiTrato.Core.Entities;
using ApiTrato.Core.Interfaces;
using ApiTrato.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiTrato.Infraestructure.Repositories
{
    public class StateRepository : IStateRepository
    {
        private readonly TRATO_DATABASEContext _context;
        public StateRepository(TRATO_DATABASEContext context)
        {
            _context = context;
        }
        public async Task<States> DeleteState(States states)
        {
            _context.States.Remove(states);
            await _context.SaveChangesAsync();
            return states;
        }
        public async Task<States> GetState(int id)
        {
            var state = await _context.States.FirstOrDefaultAsync(x => x.StateId == id);
            return state;
        }
        public async Task<IEnumerable<States>> GetStates()
        {
            var states = await _context.States.ToListAsync();
            return states;
        }
        public async Task<States> InsertState(States states)
        {
            _context.States.Add(states);
            await _context.SaveChangesAsync();
            return states;
        }
    }
}
