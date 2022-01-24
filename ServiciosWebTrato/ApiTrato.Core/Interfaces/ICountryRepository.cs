using ApiTrato.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiTrato.Core.Interfaces
{
    public interface ICountryRepository
    {
        public Task<IEnumerable<Pais>> GetPais();
    }
}
