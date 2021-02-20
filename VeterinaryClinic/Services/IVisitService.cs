using System.Collections.Generic;
using VeterinaryClinic.Models;

namespace VeterinaryClinic.Services
{
    public interface IVisitService
    {
        List<Visit> GetVisits();
        Visit GetVisit(string uuid);
        void PostVisit(Visit visit);
        Visit DeleteVisit(string uuid);
    }
}
