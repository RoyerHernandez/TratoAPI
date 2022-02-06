using ApiTrato.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiTrato.Core.Interfaces
{
    public interface IStateRepository
    {
        public  Task<IEnumerable<States>> GetStates();
        public Task<States> GetState(int id);
        public Task<States> InsertState(States states);
        public Task<States> DeleteState(States states);
    }
}
