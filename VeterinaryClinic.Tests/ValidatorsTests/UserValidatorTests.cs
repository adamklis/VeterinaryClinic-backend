using VeterinaryClinic.Models;
using VeterinaryClinic.Validators;
using Xunit;

namespace VeterinaryClinic.Tests.ValidatorsTests
{
    public class UserValidatorTests
    {
        [Fact]
        public void UserValidator_InvalidUser_ReturnsFalse()
        {
            var userValidator = new UserValidator();
            var user = new User();

            Assert.False(userValidator.Validate(user).IsValid);
        }

        [Fact]
        public void UserValidator_ValidUser_ReturnsTrue()
        {
            var userValidator = new UserValidator();
            var user = new User() { Forename = "forename", Surname = "surname", Email = "email@email" };

            Assert.True(userValidator.Validate(user).IsValid);
        }
    }
}
