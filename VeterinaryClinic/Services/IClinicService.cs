using System.Collections.Generic;
using VeterinaryClinic.Models;

namespace VeterinaryClinic.Services
{
    public interface IClinicService
    {
        List<Clinic> GetClinics();
        public bool ClinicExist(string uuid);
    }
}