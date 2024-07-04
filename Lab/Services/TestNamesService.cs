using AutoMapper;
using Lab.Data;
using Lab.Model;

namespace Lab.Services
{
    public class TestNamesService : ITestNames
    {
        LabContext context;
        IMapper mapper;
        public TestNamesService(LabContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        public void Insert(TestNamesDTO TestNamesDTO)
        {


            TestsNames newTestName = mapper.Map<TestsNames>(TestNamesDTO);


            context.TestNames.Add(newTestName);
            context.SaveChanges();
        }
    }
}
