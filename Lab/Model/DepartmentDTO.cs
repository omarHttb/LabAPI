using AutoMapper;
using Lab.Data;
using Lab.Services;

namespace Lab.Model
{
    [AutoMap(typeof(Department), ReverseMap = true)]
    public class DepartmentDTO : BaseModel
    {

        public string Name { get; set; }

    }
}
