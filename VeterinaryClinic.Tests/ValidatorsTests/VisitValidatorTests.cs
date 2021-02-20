using VeterinaryClinic.Models;
using VeterinaryClinic.Validators;
using Xunit;

namespace VeterinaryClinic.Tests.ValidatorsTests
{
    public class VisitValidatorTests
    {
        [Fact]
        public void VisitValidator_InvalidVisit_ReturnsFalse()
        {
            var visitValidator = new VisitValidator();
            var visit = new Visit();

            Assert.False(visitValidator.Validate(visit).IsValid);
        }

        [Fact]
        public void VisitValidator_ValidVisit_ReturnsTrue()
        {
            var visitValidator = new VisitValidator();
            var visit = new Visit
            {
                Animal = "animal",
                VisitType = "visit type",
                ClinicUUid = "123",
                User = new User() { Forename = "forename", Surname = "surname", Email = "email" }
            };

            Assert.True(visitValidator.Validate(visit).IsValid);
        }
    }
}
