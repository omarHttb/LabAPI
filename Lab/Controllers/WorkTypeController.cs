using Lab.Model;
using Lab.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkTypeController : ControllerBase
    {
        IWorkType workTypeService;

        public WorkTypeController(IWorkType workTypeService)
        {
            this.workTypeService = workTypeService;
        }
        [HttpPost]
        [Route("Insert")]
        public void Insert(WorkTypeDTO workTypeDTO) 
        {
            workTypeService.Insert(workTypeDTO);
        }
    }
}
