using Lab.Model;
using Lab.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        IPatient PatientService;

        public PatientsController(IPatient patientService)
        {
            PatientService = patientService;
        }
        [HttpPost]
        public void insert(PatientsDTO patient) 
        {
            PatientService.Insert(patient);
        }

        
    }
}
