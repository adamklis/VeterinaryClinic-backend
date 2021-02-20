using FluentValidation;
using VeterinaryClinic.Models;

namespace VeterinaryClinic.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Forename).NotEmpty();
            RuleFor(x => x.Surname).NotEmpty();
        }
    }
}
