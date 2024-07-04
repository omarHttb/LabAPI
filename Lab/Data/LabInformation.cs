using System.ComponentModel.DataAnnotations.Schema;
using Lab.Model;

namespace Lab.Data
{
    [Table("LabsInformation")]
    public class LabInformation : BaseModel 
    {

        //public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public string phoneNumber { get; set; }

        //add by ----
        //[ForeignKey("AddedBy")]
        //public int AddById { get; set; }



        //public DateTime AddDate { get; set; }


        //public Employee AddedBy { get; set; }

    }
}
