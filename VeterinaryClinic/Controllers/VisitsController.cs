using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using VeterinaryClinic.Models;
using VeterinaryClinic.Services;

namespace VeterinaryClinic.Controllers
{
    [ApiController]
    [Route("visits")]
    [Produces("application/json")]
    public class VisitsController : ControllerBase
    {
        private readonly ILogger<VisitsController> _logger;
        private readonly IVisitService _visitService;
        private readonly IClinicService _clinicService;

        public VisitsController(IVisitService visitService, IClinicService clinicService, ILogger<VisitsController> logger)
        {
            _logger = logger;
            _visitService = visitService;
            _clinicService = clinicService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<Visit> Get()
        {
            _logger.LogInformation("Geting all visits.");
            return _visitService.GetVisits();
        }

        [HttpGet("{uuid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Visit> Get(string uuid)
        {
            _logger.LogInformation($"Geting visit {uuid}.");
            Visit visit = _visitService.GetVisit(uuid);
            if (visit == null)
            {
                _logger.LogInformation("Visit not found.");
                return NotFound();
            }
            return visit;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody] Visit visit)
        {
            if (!ModelState.IsValid)
            {
                return new BadRequestObjectResult(ModelState);
            }
            _logger.LogInformation("Post visit.");

            if (!_clinicService.ClinicExist(visit.ClinicUUid))
            {
                return new BadRequestObjectResult("Clinic does not exist.");
            }
            _visitService.PostVisit(visit);
            return Created("", visit);
        }

        [HttpDelete("{uuid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Visit> Delete(string uuid)
        {
            _logger.LogInformation("Delete visit.");
            Visit visit = _visitService.DeleteVisit(uuid);
            if (visit == null)
            {
                _logger.LogInformation("Visit not found.");
                return NotFound();
            }
            return visit;
        }
    }
}
