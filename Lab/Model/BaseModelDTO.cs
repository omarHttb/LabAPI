using AutoMapper;
using Lab.Data;

namespace Lab.Model
{
    [AutoMap(typeof(BaseModel), ReverseMap = true)]
    public abstract class BaseModelDTO
    {
        public int Id { set; get; }

        public int AddById { get; set; }

        public int UpdatedById { get; set; }

        public DateTime AddDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public Int32 UpdatedBy { get; set; }

        public Int32 AddedBy { get; set; }
    }
}
