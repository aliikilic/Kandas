using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class GetHospitalDto
    {
        public int ID { get; set; }
        public string HospitalName { get; set; }
    }
}
