using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class City
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CityID { get; set; }
        public string CityName { get; set; }
        
        public ICollection<District> Districts { get; set; }
        public ICollection<Neighborhood> Neighborhoods{ get; set; }
        public ICollection<PersonalInformation> PersonalDetails { get; set; }
        public ICollection<Hospital> Hospital{ get; set; }

        public ICollection<PersonalInformation> BirthPlaceDetails { get; set; }
        public ICollection<Recepient> BirthPlace { get; set; }

    }
}
