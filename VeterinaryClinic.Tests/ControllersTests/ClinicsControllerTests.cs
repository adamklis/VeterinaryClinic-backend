using Microsoft.Extensions.Logging;
using Moq;
using System.Collections.Generic;
using VeterinaryClinic.Controllers;
using VeterinaryClinic.Models;
using VeterinaryClinic.Services;
using Xunit;

namespace VeterinaryClinic.Tests
{
    public class ClinicsControllerTests
    {
        [Fact]
        public void Get_ReturnsClinicsList()
        {
            var logger = new Mock<ILogger<ClinicsController>>();
            var clinicService = new Mock<IClinicService>();
            clinicService.Setup(x => x.GetClinics()).Returns(new List<Clinic>());
            var controller = new ClinicsController(clinicService.Object, logger.Object);

            var result = controller.Get();

            clinicService.Verify(x => x.GetClinics(), Times.Once);
            Assert.Empty(result);
        }
    }
}
