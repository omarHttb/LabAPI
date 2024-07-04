using AutoMapper;
using Lab.Data;
using Lab.Model;

namespace Lab.Services
{
    public class PositionService : IPosition
    {
        LabContext context;
        IMapper mapper;
        public PositionService(LabContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        public void Insert(PositionDTO PositionDTO)
        {


            Position Position = mapper.Map<Position>(PositionDTO);


            context.positions.Add(Position);
            context.SaveChanges();
        }
    }
}
