using System;
using System.Collections.Generic;
using VeterinaryClinic.Models;

namespace VeterinaryClinic.Services
{
    public class VisitService : IVisitService
    {
        private readonly List<Visit> _visits = new List<Visit>();

        Visit IVisitService.DeleteVisit(string uuid)
        {
            Visit visit = _visits.Find(visit => visit.Uuid == uuid);
            _visits.Remove(visit);
            return visit;
        }

        Visit IVisitService.GetVisit(string uuid)
        {
            return _visits.Find(visit => visit.Uuid == uuid);
        }

        List<Visit> IVisitService.GetVisits()
        {
            return _visits;
        }

        void IVisitService.PostVisit(Visit visit)
        {
            visit.Uuid = Guid.NewGuid().ToString();
            _visits.Add(visit);
        }
    }
}
