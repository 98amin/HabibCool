using HabibCool.Models.Agreement;
using System.ComponentModel.DataAnnotations;

namespace HabibCool.Models.CarType
{
    public class CarType
    {
        [Key]
        public int Id { get; set; }
        public string CarTypeName { get; set; }

        public virtual List<Agreement.Agreement> Agreements { get; set; }
    }
}
