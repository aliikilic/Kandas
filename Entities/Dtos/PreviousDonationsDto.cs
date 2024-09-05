using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class PreviousDonationsDto
    {
        public DateTime DateandTime { get; set; }
        public string Hospital { get; set; }
        public string DonationType { get; set; }
        public string Recepient { get; set; }
    }
}
