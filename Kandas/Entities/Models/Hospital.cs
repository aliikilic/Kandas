using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Hospital
    {
        public int ID { get; set; }
        public string HospitalName { get; set; }
        public City AddressCity { get; set; }
        public int AddressCityID { get; set; }
        public District AddressDistrict { get; set;}
        public int AddressDistrictID { get; set;}
        public Neighborhood AddressNeighbohood { get; set; }
        public int AddressNeighbohoodID { get; set; }
        public string AddressDescription { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool isActive { get; set; }

        public ICollection<Donation> Donations { get; set; }
    }
}
