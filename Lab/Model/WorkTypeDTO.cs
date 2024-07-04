using AutoMapper;
using Lab.Data;
using Lab.Services;

namespace Lab.Model
{
    [AutoMap(typeof(WorkType), ReverseMap = true)]
    public class WorkTypeDTO : BaseModel 
    {
        public string Name { get; set; }

    }
}
