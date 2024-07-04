using Lab.Model;
using Lab.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestNamesController : ControllerBase
    {
        ITestNames testNamesService;
        public TestNamesController(ITestNames testNamesService) 
        {
            this.testNamesService = testNamesService;
        }

        [HttpPost]
        public void Insert(TestNamesDTO testNamesDTO) 
        {
            testNamesService.Insert(testNamesDTO);
        }
    }
}
