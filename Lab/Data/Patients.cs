using System.ComponentModel.DataAnnotations.Schema;
using Lab.Model;

namespace Lab.Data
{
    [Table("Patients")]
    public class Patients :BaseModel
    {

        //public int Id { get; set; }

        public string FirstName { get; set; }   

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime DateOfBirth { get; set; }

        public List<LabOrders> LabOrders { get; set; }

        [ForeignKey("Nationalities")]
        public int NationalityId { get; set; }

        public Nationalities Nationalities { get; set; }


        ////add by ----
        //[ForeignKey("AddedBy")]
        //public int AddById { get; set; }




        //public DateTime AddDate { get; set; }


        //public Employee AddedBy { get; set; }




    }
}
