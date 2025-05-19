using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class CreateDonationDto
    {
        public int RecepientId { get; set; }
        public int HospitalId { get; set; }
        public int DonationTypeId { get; set; }
        public int NecessityAmount { get; set; }
        public DateTime NecessityStartDate { get; set; }
        public bool IsActive { get; set; }

    }
}
