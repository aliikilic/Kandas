using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class MovementStatus
    {
        public int MovementStatusId { get; set; }
        public string StatusName { get; set; }
        public ICollection<DonationMovement> DonationMovements{ get; set; }
        // public int StatusId { get; set; }

    }
}
