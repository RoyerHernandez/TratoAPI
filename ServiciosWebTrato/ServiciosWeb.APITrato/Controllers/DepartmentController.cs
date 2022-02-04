using ApiTrato.Core.Entities;
using ApiTrato.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiciosWeb.APITrato.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetDepartments()
        {
            var departments = await _departmentRepository.GetDepartments();
            return Ok(departments);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDepartment(int id)
        {
            var department = await _departmentRepository.GetDepartment(id);
            return Ok(department);
        }
        [HttpPost]
        public async Task<IActionResult> InsertDepartment(Departments departments)
        {
            await _departmentRepository.InsertDepartment(departments);
            return Ok(departments);
        }
    }
}
