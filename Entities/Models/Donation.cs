using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Donation
    {
        public int DonationId { get; set; }
        public Recepient Recepient { get; set; }
        public int RecepientId { get; set; }
        public Hospital Hospital { get; set; }
        public int HospitalId { get; set; }
        public DonationType DonationType { get; set; }
        public int DonationTypeId { get; set; }
        public int NecessityAmount { get; set; }
        public DateTime NecessityStartDate { get; set; }
        public bool IsActive { get; set; }

        public ICollection<DonationMovement> DonationMovement { get; set; }
        public ICollection<Notification> Notifications { get; set; }
    }
}
