using Lab.Data;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab.Model
{
    public class ApplicationUser :IdentityUser
    {
        public string Name { get; set;}

        public string Email { get; set;}

        public string gender { get; set;}

        public DateTime DateOfBirth { get; set; }

        [ForeignKey("Employee")]
        public int? EmployeeId { get; set; }

        public Employee? Employee { get; set; }
    }
}
