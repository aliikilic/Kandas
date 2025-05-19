namespace Entities.Models
{
    public class PersonalInformationNotifications
    {
        public PersonalInformation PersonalInformations { get; set; }
        public int PersonalInformationId { get; set; }
        public Notification Notifications{ get; set; }
        public int NotificationId { get; set; }
        public DateTime InsertDate { get; set; }
    }
}