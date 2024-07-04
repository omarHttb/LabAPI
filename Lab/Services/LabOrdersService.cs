using AutoMapper;
using Lab.Data;
using Lab.Model;

namespace Lab.Services
{
    public class LabOrdersService :ILabOrders
    {
        LabContext context;
        IMapper mapper;
        public LabOrdersService(LabContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        public void Insert(LabOrdersDTO labOrdersDTO)
        {


            LabOrders labOrders = mapper.Map<LabOrders>(labOrdersDTO);


            context.LabOrders.Add(labOrders);
            context.SaveChanges();
        }
    }
}
