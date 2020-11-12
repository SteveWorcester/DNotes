using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNotes.Data
{
    public class User
    {
        public Guid UserId { get; set; }
        public List<Campaign> Campaigns { get; set; }
        public List<Character> Characters { get; set; }
        public string PlayerName { get; set; }
        public string Email { get; set; }
    }
}
