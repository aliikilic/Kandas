using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class CreateDMDto
    {
        public int DonationId { get; set; }
        public int PersonId { get; set; }
        public DateTime DonationDate { get; set; }
        public int DonationTypeId { get; set; }
        public int DonationAmount { get; set; }
        public string Description { get; set; }
        public int MovementStatusId { get; set; }
    }
}
