using System.ComponentModel.DataAnnotations;

namespace VeterinaryClinic.Models
{
    public class Address
    {
        [Required]
        public string City { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string Number { get; set; }
    }
}