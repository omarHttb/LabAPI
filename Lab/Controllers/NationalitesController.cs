using Lab.Model;
using Lab.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalitesController : ControllerBase
    {
        INationality nationalityService;

        public NationalitesController(INationality nationalityService)
        {
            this.nationalityService = nationalityService;
        }

        [HttpPost]
        [Route("Insert")]
        public void insert(NationalitiesDTO nationalitiesDTO) 
        {
            nationalityService.Insert(nationalitiesDTO);
        }
    }
}
