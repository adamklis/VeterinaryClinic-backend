using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using VeterinaryClinic.Services;

namespace VeterinaryClinic.Controllers
{
    [ApiController]
    [Route("visit-types")]
    [Produces("application/json")]
    public class VisitTypesController
    {
        private readonly ILogger<VisitTypesController> _logger;
        private readonly IVisitTypeService _visitTypeService;

        public VisitTypesController(IVisitTypeService visitTypeService, ILogger<VisitTypesController> logger)
        {
            _logger = logger;
            _visitTypeService = visitTypeService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<string> Get()
        {
            _logger.LogInformation("Geting all visit types.");
            return _visitTypeService.GetVisitTypes();
        }
    }
}
