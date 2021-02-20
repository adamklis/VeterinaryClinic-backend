using FluentValidation;
using VeterinaryClinic.Models;

namespace VeterinaryClinic.Validators
{
    public class VisitValidator : AbstractValidator<Visit>
    {
        public VisitValidator()
        {
            RuleFor(x => x.VisitType).NotEmpty();
            RuleFor(x => x.User).NotEmpty();
            RuleFor(x => x.Animal).NotEmpty();
            RuleFor(x => x.ClinicUUid).NotEmpty();
        }
    }
}
