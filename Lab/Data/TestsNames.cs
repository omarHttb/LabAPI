using System.ComponentModel.DataAnnotations.Schema;
using Lab.Model;

namespace Lab.Data
{
    [Table("TestsNames")]
    public class TestsNames : BaseModel
    {

        //public int Id { get; set; }

        public string Name { get; set; }



        public ICollection<LabOrders> LabOrders { get; set; }

        //add by ----
        //[ForeignKey("AddedBy")]
        //public int AddById { get; set; }



        //public DateTime AddDate { get; set; }

        //public Employee AddedBy { get; set; }

    }
}
