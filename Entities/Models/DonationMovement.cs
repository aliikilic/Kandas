using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class DonationMovement
    {
        public int Id { get; set; }
        public Donation Donation { get; set; }
        public int DonationId { get; set; }
        public PersonalInformation PersonalDetails { get; set; }
        public int PersonId { get; set; }
        public DateTime DonationDate { get; set; }
        public DonationType DonationType { get; set; }
        public int DonationTypeId { get; set; }
        public int DonationAmount { get; set; }
        public string Description { get; set; }
        public int MovementStatusId { get; set; }
        public MovementStatus MovementStatus { get; set; }

    }
}
