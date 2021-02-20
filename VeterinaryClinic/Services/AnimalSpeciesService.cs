using System.Collections.Generic;

namespace VeterinaryClinic.Services
{
    public class AnimalSpeciesService : IAnimalSpeciesService
    {
        private readonly List<string> _animalSpecies = new List<string>() {
            "Kot norweski leśny",
            "Kot brytyjski długowłosy",
            "Kot bengalski",
            "Kot singapurski"
        };
        public List<string> GetAnimalSpecies()
        {
            return _animalSpecies;
        }
    }
}
