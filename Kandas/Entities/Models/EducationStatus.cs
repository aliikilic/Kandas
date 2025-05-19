using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class EducationStatus
    {
        public int EducationStatusId { get; set; }
        public string StatusName { get; set; }

        public ICollection<PersonalInformation> PersonalDetails { get; set; }
    }
}
