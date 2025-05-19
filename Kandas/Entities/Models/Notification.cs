using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public ICollection<PersonalInformation> PersonId { get; set; }
        
        public Donation Donation { get; set; }
        public int DonationId { get; set; }
        public DateTime NotificationDate { get; set; }
        public bool IsActive { get; set; }
        //public ICollection<PersonalInformationNotification> PersonalInformationNotifications { get; set; }
        




    }
}
