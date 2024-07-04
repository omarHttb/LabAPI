using Lab.Model;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab.Data
{
    [Table("Employees")]
    public class Employee 
    {

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
            
        public string Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime HiringDate { get; set; }

        public DateTime? QuitDate { get; set; }
        //--------------------------------------
        [ForeignKey("WorkType")]
        public int WorkTypeId { get; set; }

        public WorkType WorkType { get; set; }

        [ForeignKey("Nationalities")]
        public int NationalityId { get; set; }

        public Nationalities Nationalities { get; set; }

        [ForeignKey("Departments")]
        public int DepartmentId { get; set; }

        public Department Departments { get; set; }

        [ForeignKey("Positions")]
        public int PositionId { get; set; }
        public Position Positions { get; set; }

        // Position relationships
        public ICollection<Position> AddedPositions { get; set; }
        public ICollection<Position> UpdatedPositions { get; set; }

        // TestsNames relationships
        public ICollection<TestsNames> AddedTestsNames { get; set; }
        public ICollection<TestsNames> UpdatedTestsNames { get; set; }

        // Patients relationships
        public ICollection<Patients> AddedPatients { get; set; }
        public ICollection<Patients> UpdatedPatients { get; set; }

        // LabInformation relationships
        public ICollection<LabInformation> AddedLabInformation { get; set; }
        public ICollection<LabInformation> UpdatedLabInformation { get; set; }

        // LabOrders relationships
        public ICollection<LabOrders> AddedLabOrders { get; set; }
        public ICollection<LabOrders> UpdatedLabOrders { get; set; }

        // Nationalities relationships
        public List<Nationalities> AddedNationalities { get; set; }
        public List<Nationalities> UpdatedNationalities { get; set; }

        // WorkType relationships
        public ICollection<WorkType> AddedWorkTypes { get; set; }
        public ICollection<WorkType> UpdatedWorkTypes { get; set; }

        // Department relations
        public ICollection<Department> AddedDepartments { get; set; }
        public ICollection<Department> UpdatedDepartments { get; set; }


        // User relation

        public ApplicationUser ApplicationUser { get; set; }


        //add by   ----
        [ForeignKey("AddedBy")]
        public int? AddedById { get; set; }

        public DateTime? AddDate { get; set; }

        public Employee AddedBy { get; set; }

        //update by ----

        [ForeignKey("UpdatedBy")]
        public int? UpdatedById { get; set; }

        public DateTime? UpdateDate { get; set; }

        public Employee UpdatedBy { get; set; }



    }
}
