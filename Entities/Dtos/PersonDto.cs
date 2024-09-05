using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class PersonDto
    {
        public string TcNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public int BirthPlaceId { get; set; }
        public string FatherName { get; set; }
        public bool Marriage { get; set; }
        public bool Gender { get; set; }
        public int PersonEducationStatusId { get; set; }
        public string Job { get; set; }
        public int CityId { get; set; }
        public int ResidanceDistrictId { get; set; }
        public int ResidanceNeighborhoodId { get; set; }
        public string BloodType { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool IsActive { get; set; }

    }
}
