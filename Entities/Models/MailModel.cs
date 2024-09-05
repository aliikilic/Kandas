using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class MailModel
    {
        public string? To { get; set; }
        public string? From { get; } = "kandasdestek@gmail.com";
        public string? Subject { get; set; }
        public string? Body { get; set; }
        public DateTime SendTime { get; set; } = DateTime.Now;
    }
}
