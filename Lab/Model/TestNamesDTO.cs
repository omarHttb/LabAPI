using AutoMapper;
using Lab.Data;
using Lab.Services;

namespace Lab.Model
{
    [AutoMap(typeof(TestsNames ), ReverseMap = true)]
    public class TestNamesDTO : BaseModel
    {
        public string Name { get; set; }

    }
}
