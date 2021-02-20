using System.Collections.Generic;

namespace VeterinaryClinic.Services
{
    public class VisitTypeService : IVisitTypeService
    {
        private readonly List<string> _visitTypes = new List<string>() {
            "Szczepienie",
            "Wizyta kontrolna",
            "Czyszczenie zębów",
            "Obcinanie pazurów",
            "Testy alergiczne",
            "Inne"
        };
        public List<string> GetVisitTypes()
        {
            return _visitTypes;
        }
    }
}
