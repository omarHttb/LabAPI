using AutoMapper;
using Lab.Data;
using Lab.Services;
using System.ComponentModel.DataAnnotations;

namespace Lab.Model
{
    [AutoMap(typeof(Position), ReverseMap = true)]
    public class PositionDTO : BaseModel
    {
        [Required]
        public string Name { get; set; }

    }
}
