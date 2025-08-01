using HabibCool.Models.Agreement;
using System.ComponentModel.DataAnnotations;

namespace HabibCool.Models
{
    public class ServiceMan
    {
        [Key]
        public int Id { get; set; }
        public string ServiceManName { get; set; }
        public long BaseSalary { get; set; }

        public virtual List<Agreement.Agreement> Agreements { get; set; }
    }
}
