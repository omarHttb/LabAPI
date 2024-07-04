using Lab.Model;
using Lab.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabOrdersController : ControllerBase
    {
        ILabOrders labOrdersService;

        public LabOrdersController(ILabOrders labOrders)
        {
            this.labOrdersService = labOrders;
        }

        [HttpPost]
        public void insert(LabOrdersDTO labOrdersDTO)
        {
            labOrdersService.Insert(labOrdersDTO);
        }
    }
}
