using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class CreateNotificationDto
    {
        //public int NotificationId { get; set; }
        public int DonationId { get; set; }
        public DateTime NotificationDate { get; set; }
        public bool IsActive { get; set; }
    }
}
