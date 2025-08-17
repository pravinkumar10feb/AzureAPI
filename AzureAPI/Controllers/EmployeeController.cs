using AzureAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AzureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeContext _employee;

        public EmployeeController(EmployeeContext employee)
        {
            _employee = employee;
        }

        // GET: api/employee>
        [HttpGet]
        public async Task<IActionResult> GetContacts()
        {
            return Ok(await _employee.Employees.ToListAsync());
        }
    }
}
