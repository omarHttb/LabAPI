using AutoMapper;
using Lab.Data;
using Lab.Services;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab.Model
{
    [AutoMap(typeof(Employee), ReverseMap = true)]
    public class EmployeeDTO : BaseModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime HiringDate { get; set; }

        public DateTime? QuitDate { get; set; }
        //--------------------------------------
        
        public int WorkTypeId { get; set; }

        public WorkTypeDTO WorkType { get; set; }

        
        public int NationalityId { get; set; }

        public NationalitiesDTO Nationalities { get; set; }

        
        public int DepartmentId { get; set; }

        public DepartmentDTO Departments { get; set; }

        
        public int PositionId { get; set; }

        public PositionDTO Positions { get; set; }

    }
}
