using AutoMapper;
using Lab.Data;
using Lab.Model;

namespace Lab.Services
{
    public class WorkTypeService : IWorkType
    {
        LabContext context;
        IMapper mapper;
        public WorkTypeService(LabContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        public void Insert(WorkTypeDTO WorkTypeDTO)
        {


            WorkType WorkType = mapper.Map<WorkType>(WorkTypeDTO);


            context.workTypes.Add(WorkType);
            context.SaveChanges();
        }
    }
}
