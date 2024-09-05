using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class GetDistrictsDto
    {
        public int DistrictID { get; set; }
        public string DistrictName { get; set; }
        public int CityID { get; set; }
    }
}
