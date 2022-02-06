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
    public class LocationRepository : ILocationRepository
    {
        private readonly TRATO_DATABASEContext _context;
        public LocationRepository(TRATO_DATABASEContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Locations>> GetLocations()
        {
            var locations = await _context.Locations.ToListAsync();
            return locations;
        }
        public async Task<Locations> GetLocation(int id)
        {
            var location = await _context.Locations.FirstOrDefaultAsync(x => x.LocationId == id);
            return location;
        }
        public async Task InsertLocation(Locations locations)
        {
            _context.Locations.Add(locations);
            await _context.SaveChangesAsync();            
        }
    }
}
