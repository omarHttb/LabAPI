using AutoMapper;
using Lab.Data;
using Lab.Model;

namespace Lab.Services
{
    public class EmployeeService : IEmployee
    {
        LabContext context;
        IMapper mapper;
        public EmployeeService(LabContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        public void Insert(EmployeeDTO employeeDTO)
        {


            Employee newEmployee = mapper.Map<Employee>(employeeDTO);


            context.Employees.Add(newEmployee);
            context.SaveChanges();
        }
    }
}
