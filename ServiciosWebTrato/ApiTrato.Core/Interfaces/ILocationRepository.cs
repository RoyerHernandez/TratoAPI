using ApiTrato.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiTrato.Core.Interfaces
{
    public interface ILocationRepository
    {
        public Task<IEnumerable<Locations>> GetLocations();
        public Task<Locations> GetLocation(int id);
        public Task InsertLocation(Locations locations);

    }
}
