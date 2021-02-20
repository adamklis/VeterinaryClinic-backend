using System.ComponentModel.DataAnnotations;

namespace VeterinaryClinic.Models
{
    public class Visit
    {
        public string Uuid { get; set; }
        [Required]
        public string VisitType { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public string Animal { get; set; }
        [Required]
        public string ClinicUUid { get; set; }
    }
}
