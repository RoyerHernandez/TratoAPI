using ApiTrato.Core.Entities;
using ApiTrato.Core.Interfaces;
using ApiTrato.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiTrato.Infraestructure.Repositories
{
    public class CountryRepository: ICountryRepository
    {
        private readonly TRATO_DATABASEContext _context;

        public CountryRepository(TRATO_DATABASEContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Country>> GetCountry()
        {
            var paises = await _context.Countries.ToListAsync();
            await Task.Delay(10);
            return paises;
        }
        public async Task<Country> GetCountry(int id)
        {
            var countries = await _context.Countries.FirstOrDefaultAsync(x => x.CountryId == id);
            return countries;
        }
        public async Task InsertCountry(Country country)
        {
            _context.Countries.Add(country);
            await _context.SaveChangesAsync();
        }
    }
}
