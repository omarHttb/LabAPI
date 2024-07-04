using AutoMapper;
using Lab.Data;
using Lab.Services;

namespace Lab.Model
{
    [AutoMap(typeof(LabInformation), ReverseMap = true)]
    public class LabInformationDTO : BaseModel
    {
        public string Name { get; set; }

        public string Location { get; set; }

        public string phoneNumber { get; set; }
    }
}
