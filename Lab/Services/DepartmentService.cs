using AutoMapper;
using Lab.Data;
using Lab.Model;
using Microsoft.EntityFrameworkCore;

namespace Lab.Services
{
    public class DepartmentService : IDepartment
    {
        LabContext context;
        IMapper mapper;
        public DepartmentService(LabContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }
        public void Insert(DepartmentDTO departmentDTO)
        {


            Department newDepartment = mapper.Map<Department>(departmentDTO);


            context.Departments.Add(newDepartment);
            context.SaveChanges();
        }
    }
}
