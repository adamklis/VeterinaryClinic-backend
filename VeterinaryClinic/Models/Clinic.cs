using System.ComponentModel.DataAnnotations;

namespace VeterinaryClinic.Models
{
    public class Clinic
    {
        public string Uuid { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Address Address { get; set; }
        [Required]
        public Rating Rating { get; set; }
        [Required]
        public string Description { get; set; }
    }
}