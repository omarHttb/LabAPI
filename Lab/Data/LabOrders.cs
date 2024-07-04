using System.ComponentModel.DataAnnotations.Schema;
using Lab.Model;

namespace Lab.Data
{
    [Table("LabOrders")]
    public class LabOrders : BaseModel
    {

        //public int Id { get; set; }

        public DateTime DateTaken { get; set; }


        [ForeignKey("Lab")]
        public int LabId { get; set; }

        public LabInformation Lab { get; set; }


        [ForeignKey("PatientId")]
        public int PatientID { get; set; }


        public Patients PatientId { get; set; }



        [ForeignKey("TestsNames")]
        public int TestNameID { get; set; }

        public TestsNames TestsNames { get; set; }

        //add by ----
        //[ForeignKey("AddedBy")]
        //public int AddById { get; set; }

        //public DateTime AddDate { get; set; }

        //public Employee AddedBy { get; set; }

    }
}
