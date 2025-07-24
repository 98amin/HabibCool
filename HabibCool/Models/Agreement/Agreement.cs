using System.ComponentModel.DataAnnotations;

namespace HabibCool.Models.Agreement
{
    public class Agreement
    {
        [Key]
        public int Id { get; set; }
        public string AgreementCode { get; set; }
        public string CarPlateNumber { get; set; }
        public DateTime EnterDate { get; set; }
        public DateTime ExitDate { get; set; }
    }
}
