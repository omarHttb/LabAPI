using AutoMapper;
using Lab.Data;
using Lab.Model;

namespace Lab.Services
{
    public class LabInformationService : ILabInformation
    {
        LabContext context;
        IMapper mapper;
        public LabInformationService(LabContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        public void Insert(LabInformationDTO labInfoDTO)
        {


            LabInformation LabInfo = mapper.Map<LabInformation>(labInfoDTO);


            context.LabsInformation.Add(LabInfo);
            context.SaveChanges();
        }
    }
}
