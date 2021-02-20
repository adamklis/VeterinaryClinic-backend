using System;
using System.ComponentModel.DataAnnotations;

namespace VeterinaryClinic.Models
{
    public class Rating
    {
        [Required]
        public int Value { get; }
        public Rating(int rating)
        {
            if (rating < 0 || rating > 10) throw new ArgumentException("Rating is out of range");
            Value = rating;
        }
    }
}