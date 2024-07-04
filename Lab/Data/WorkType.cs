using System.ComponentModel.DataAnnotations.Schema;
using Lab.Model;

namespace Lab.Data
{

    [Table("WorkTypes")]  
    public class WorkType : BaseModel 
    {

         //public int Id { get; set; }
        public string Name { get; set; }

        public List<Employee> Employees { get; set; }


        //add by ---
        //[ForeignKey("AddedBy")]
        //public int AddById { get; set; }

        //public DateTime AddDate { get; set; }

        //public Employee AddedBy { get; set; }



    }
}
