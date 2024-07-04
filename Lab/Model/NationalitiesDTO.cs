using AutoMapper;
using Lab.Data;
using Lab.Services;

namespace Lab.Model
{
    [AutoMap(typeof(Nationalities), ReverseMap = true)]
    public class NationalitiesDTO : BaseModel
    {
        public string Name { get; set; }

    }
}
