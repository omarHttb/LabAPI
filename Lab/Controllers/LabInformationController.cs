using Lab.Model;
using Lab.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabInformationController : ControllerBase
    {
        ILabInformation labInformationService;

        public LabInformationController(ILabInformation _labInformationService)
        {
            labInformationService = _labInformationService;
        }

        [HttpPost]
        public void insert(LabInformationDTO labInformationDTO)
        {
                labInformationService.Insert(labInformationDTO);
        }
    }
}
