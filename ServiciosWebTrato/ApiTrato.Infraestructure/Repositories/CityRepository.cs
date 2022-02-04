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
    public class CityRepository : ICityRepository
    {
        private readonly TRATO_DATABASEContext _context;
        public CityRepository(TRATO_DATABASEContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Cities>> GetCity() {
            var cities = await _context.Cities.ToListAsync();
            return cities;
        }
        public async Task<Cities> GetCity(int id)
        {
            var city = await _context.Cities.FirstOrDefaultAsync(x => x.CityId == id) ;
            return city;
        }
        public async Task InsertCity(Cities cities)
        {
            _context.Add(cities);
            await _context.SaveChangesAsync();
        }
    }
}
