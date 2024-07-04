using AutoMapper;
using Lab.Data;
using Lab.Model;

namespace Lab.Services
{
    public class NationalityService : INationality
    {
        LabContext context;
        IMapper mapper;
        public NationalityService(LabContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        public void Insert(NationalitiesDTO nationalitiesDTO)
        {


            Nationalities nationalities = mapper.Map<Nationalities>(nationalitiesDTO);


            context.Nationalities.Add(nationalities);
            context.SaveChanges();
        }
    }
}
