using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarasDzivikPetProject.Domain.Entities
{
    public class UserBase
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LustName { get; set; }
        public string Status { get; set; }
        public string Group { get; set; }
        public string Course { get; set; }
        public int Rating { get; set; }
        public string Email { get; set; }
    }
}
