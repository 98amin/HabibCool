using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HabibCool.Models.Agreement
{
    public class Agreement
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("CarType")]
        public int CarTypeId { get; set; }
        [ForeignKey("ServiceMan")]
        public int ServiceManId { get; set; }
        public string AgreementCode { get; set; }
        public string CarPlateNumber { get; set; }
        public string? ChassiNumber { get; set; }
        public DateTime EnterDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public DateTime? ExitDate { get; set; }
        public virtual ServiceMan ServiceMan { get; set; } 
        public virtual CarType.CarType CarType { get; set; }
    }
}
