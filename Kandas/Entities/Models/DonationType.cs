using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class DonationType
    {
        public int Id { get; set; }
        public string DonationTypeName { get; set; }

        public ICollection<Donation> Donations { get; set; }
        public ICollection<DonationMovement> DonationMovements { get; set; }
    }
}
