using AutoMapper;
using Lab.Data;

namespace Lab.Model
{
    [AutoMap(typeof(Patients), ReverseMap = true)]
    public class PatientsDTO : BaseModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime DateOfBirth { get; set; }

        public List<LabOrders> LabOrders { get; set; }

        public int NationalityId { get; set; }

        public NationalitiesDTO Nationalities { get; set; }
    }
}
