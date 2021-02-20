using System.Collections.Generic;

namespace VeterinaryClinic.Services
{
    public interface IAnimalSpeciesService
    {
        List<string> GetAnimalSpecies();
    }
}
