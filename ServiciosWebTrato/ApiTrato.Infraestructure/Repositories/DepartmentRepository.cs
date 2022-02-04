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
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly TRATO_DATABASEContext _context;

        public DepartmentRepository(TRATO_DATABASEContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Departments>> GetDepartments()
        {
            var departments = await _context.Departments.ToListAsync();
            await Task.Delay(10);
            return (departments);
        }

        public async Task<Departments> GetDepartment(int id)
        {
            var department = await _context.Departments.FirstOrDefaultAsync(x => x.DepartmentId == id);
            return (department);
        }

        public async Task InsertDepartment(Departments departments)
        {
             _context.Departments.Add(departments);
            await _context.SaveChangesAsync();
        }
    }
}
