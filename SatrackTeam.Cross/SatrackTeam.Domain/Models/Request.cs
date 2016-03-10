using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatrackTeam.Domain.Models
{
    public class Request
    {
        public string id { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
        public string version { get; set; }
        public bool deleted { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string description { get; set; }
        public int priority { get; set; }
        public bool @checked { get; set; }
    }
}
