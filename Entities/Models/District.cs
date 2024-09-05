using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class District
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DistrictID { get; set; }
        public string DistrictName { get; set; }
        public int CityID { get; set; }


        public City City { get; set; } 
        public ICollection<Neighborhood> Neighborhoods { get; set; } 

        public ICollection<PersonalInformation> PersonalDetails { get; set; }
        public ICollection<Hospital> Hospital { get; set; }
    }
}
