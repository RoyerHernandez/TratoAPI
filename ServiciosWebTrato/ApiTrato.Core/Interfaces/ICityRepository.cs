using ApiTrato.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiTrato.Core.Interfaces 
{
    public interface ICityRepository
    {
        public Task<IEnumerable<Cities>> GetCity();
        public Task<Cities> GetCity(int id);
    }
}
