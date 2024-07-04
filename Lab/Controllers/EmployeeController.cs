using Lab.Model;
using Lab.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployee employeeService;

        public EmployeeController(IEmployee employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpPost]
        [Route("Insert")]
        public void Insert(EmployeeDTO employeeDTO) 
        {
            employeeService.Insert(employeeDTO);
        }
    }
}
