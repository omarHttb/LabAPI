using Lab.Model;
using Lab.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        IDepartment departmentService;

        public DepartmentController(IDepartment _department)
        {
            departmentService = _department;
        }

        [HttpPost]
        [Route("Insert")]
        public void Insert(DepartmentDTO departmentDTO)
        {
            departmentService.Insert(departmentDTO);
        }
    }
}
