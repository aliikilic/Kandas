using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class PersonalInformation
    {       
        public int PersonalInformationId { get; set; }
        public string TcNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public City BirthPlace { get; set; }
        public int BirthPlaceId { get; set; }
        public string FatherName { get; set; }
        public bool Marriage { get; set; }
        public bool Gender { get; set; }
        public EducationStatus PersonEducationStatus { get; set; }
        public int PersonEducationStatusId { get; set; }
        public string Job { get; set; }
        public City ResidanceCity { get; set; }
        public int CityId { get; set; }
        public District ResidanceDistrict{ get; set; }
        public int ResidanceDistrictId{ get; set; }
        public Neighborhood ResidanceNeighborhood { get; set; }
        public int ResidanceNeighborhoodId { get; set; }
        public string BloodType { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool IsActive{ get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public ICollection<DonationMovement> DonationMovements { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public PersonInquiryForm PersonInquiryForm { get; set; }
        //public ICollection<PersonalInformationNotification>PersonalInformationNotifications { get; set; }
        



    }
}
