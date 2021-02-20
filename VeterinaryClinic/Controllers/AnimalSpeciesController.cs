using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using VeterinaryClinic.Services;

namespace VeterinaryClinic.Controllers
{
    [ApiController]
    [Route("animal-species")]
    [Produces("application/json")]
    public class AnimalSpeciesController : ControllerBase
    {
        private readonly ILogger<AnimalSpeciesController> _logger;
        private readonly IAnimalSpeciesService _animalSpeciesService;

        public AnimalSpeciesController(IAnimalSpeciesService animalSpeciesService, ILogger<AnimalSpeciesController> logger)
        {
            _logger = logger;
            _animalSpeciesService = animalSpeciesService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<string> Get()
        {
            _logger.LogInformation("Geting all animal species.");
            return _animalSpeciesService.GetAnimalSpecies();
        }
    }
}
