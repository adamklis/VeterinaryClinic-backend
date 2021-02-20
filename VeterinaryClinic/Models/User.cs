using System.ComponentModel.DataAnnotations;

namespace VeterinaryClinic.Models
{
    public class User
    {
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Forename { get; set; }
        public string TelephoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
