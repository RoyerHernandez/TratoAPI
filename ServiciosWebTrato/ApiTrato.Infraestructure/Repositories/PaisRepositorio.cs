using ApiTrato.Core.Entities;
using ApiTrato.Core.Interfaces;
using ApiTrato.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiTrato.Infraestructure.Repositories
{
    public class PaisRepositorio : IPaisRepositorio
    {
        private readonly TRATO_DATABASEContext  _context;

        public PaisRepositorio(TRATO_DATABASEContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Pais>> GetPais()
        {
            var paises = await _context.Pais.ToListAsync();
            await Task.Delay(10);
            return paises;
        }       
    }
}
