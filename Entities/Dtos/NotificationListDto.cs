using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class NotificationListDto
    {
        public int NotificationId { get; set; }
        public string Hospital { get; set; }
        public string HospitalAddress { get; set; }
        public string Name{ get; set; }
        public string Surname { get; set; }
        public string BloodType { get; set; }
        public string DonationType { get; set; }
        public int NecessityAmount { get; set; }
        public string NotificationTime { get; set; }
    }
}
