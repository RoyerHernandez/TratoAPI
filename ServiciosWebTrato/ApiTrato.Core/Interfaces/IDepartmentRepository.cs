using ApiTrato.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiTrato.Core.Interfaces
{
    public interface IDepartmentRepository
    {
        public Task<IEnumerable<Departments>> GetDepartments();
        public Task<Departments> GetDepartment(int id);
        public Task InsertDepartment(Departments cities);
    }
}
