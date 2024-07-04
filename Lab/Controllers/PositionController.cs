using Lab.Data;
using Lab.Model;
using Lab.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionController : ControllerBase
    {
        IPosition positionService;
        public PositionController(IPosition positionService) 
        {
            this.positionService = positionService;
        }
        [HttpPost]
        [Route("Insert")]
        public void Insert(PositionDTO positionDTO)
        {
            positionService.Insert(positionDTO);
        }
    }
}
