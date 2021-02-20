using System.Collections.Generic;
using System.Linq;
using VeterinaryClinic.Models;

namespace VeterinaryClinic.Services
{
    public class ClinicService : IClinicService
    {
        private readonly List<Clinic> _clinics = new List<Clinic>() {
            new Clinic { Uuid = "c9c7bbf7-a226-49cb-9fd7-b18f86c4a2135",  Name = "Całodobowa Klinika Weterynaryjna Arka w Krakowie", Address = new Address {City = "Kraków", Street = "Królewska", Number = "135" }, Rating = new Rating(5), Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." },
            new Clinic { Uuid = "c9c7bbf7-a226-49cb-9fd7-b18f86c4a2136",  Name = "Lecznica Weterynaryjna Luxvet24", Address = new Address {City = "Kraków", Street = "Młodej Polski", Number = "12" }, Rating = new Rating(9), Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." },
            new Clinic { Uuid = "c9c7bbf7-a226-49cb-9fd7-b18f86c4a2137",  Name = "Przychodnia Weterynaryjna Retina", Address = new Address {City = "Kraków", Street = "Długa", Number = "5" }, Rating = new Rating(7), Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." },
            new Clinic { Uuid = "c9c7bbf7-a226-49cb-9fd7-b18f86c4a2138",  Name = "Przychodnia Weterynaryjna Abwet", Address = new Address {City = "Kraków", Street = "Wielicka", Number = "230" }, Rating = new Rating(4), Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." },
            new Clinic { Uuid = "c9c7bbf7-a226-49cb-9fd7-b18f86c4a2139",  Name = "Lessie Gabinet Weterynaryjny", Address = new Address {City = "Kraków", Street = "Motyla", Number = "4" }, Rating = new Rating(10), Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." },
            new Clinic { Uuid = "c9c7bbf7-a226-49cb-9fd7-b18f86c4a2130",  Name = "Medicavet Przychodnia Weterynaryjna", Address = new Address {City = "Kraków", Street = "Kapelanka", Number = "13C" }, Rating = new Rating(0), Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." }
        };
        public List<Clinic> GetClinics()
        {
            return _clinics;
        }

        public bool ClinicExist(string uuid)
        {
            return _clinics.Any(x => x.Uuid == uuid);
        }
    }
}
