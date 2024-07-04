using AutoMapper;
using Lab.Data;
using Lab.Services;

namespace Lab.Model
{
    [AutoMap(typeof(LabOrders), ReverseMap = true)]
    public class LabOrdersDTO  : BaseModel
    {
        public DateTime DateTaken { get; set; }


        public int LabId { get; set; }

        public LabInformation Lab { get; set; }


        public int PatientID { get; set; }


        public Patients PatientId { get; set; }



        public int TestNameID { get; set; }

        public TestNamesDTO TestsNames { get; set; }
    }
}
