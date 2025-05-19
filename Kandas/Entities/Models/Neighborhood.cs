using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Neighborhood
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NeighborhoodId { get; set; }
        public string NeighborhoodName { get; set; }
        public int DistrictId { get; set; }
        public int CityId { get; set; }


        public District District { get; set; }
        public City City{ get; set; }

        public ICollection<PersonalInformation> PersonalDetails { get; set; }
        public ICollection<Hospital> Hospital { get; set; }
    }
}
