using Lab.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Lab.Model
{
    public abstract class BaseModel
    {
        public int Id { set; get; }

        public int? AddedById { set; get; }

        public int? UpdatedById { set; get; }

        public DateTime? AddDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public Employee Updated { get; set; }

        public Employee Added { get; set; }

    }
}
