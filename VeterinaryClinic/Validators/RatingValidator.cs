using FluentValidation;
using VeterinaryClinic.Models;

namespace VeterinaryClinic.Validators
{
    public class RatingValidator : AbstractValidator<Rating>
    {
        public RatingValidator()
        {
            RuleFor(x => x.Value)
                .NotEmpty()
                .GreaterThanOrEqualTo(0)
                .LessThanOrEqualTo(10);
        }
    }
}
