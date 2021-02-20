using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using VeterinaryClinic.Models;
using VeterinaryClinic.Services;

namespace VeterinaryClinic.Controllers
{
    [ApiController]
    [Route("clinics")]
    [Produces("application/json")]
    public class ClinicsController : ControllerBase
    {
        private readonly ILogger<ClinicsController> _logger;
        private readonly IClinicService _clinicService;

        public ClinicsController(IClinicService clinicService, ILogger<ClinicsController> logger)
        {
            _logger = logger;
            _clinicService = clinicService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<Clinic> Get()
        {
            _logger.LogInformation("Geting all clinincs.");
            return _clinicService.GetClinics();
        }
    }
}
