using AutoMapper;
using Lab.Data;
using Lab.Model;

namespace Lab.Services
{
    public class PatientService : IPatient
    {
            LabContext context;
            IMapper mapper;
            public PatientService(LabContext _context, IMapper _mapper)
            {
                context = _context;
                mapper = _mapper;
            }

        public void Insert(PatientsDTO patientsDTO)
        {


            Patients newPatient = mapper.Map<Patients>(patientsDTO);


            context.Patients.Add(newPatient);
            context.SaveChanges();
        }

    }
}
