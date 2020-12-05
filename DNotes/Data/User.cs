using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNotes.Data
{
    public class User
    {
        public int Id { get; set; }
        public Guid RecoveryGuid { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public List<int> CampaignIds { get; set; }
        public List<int> CharacterIds { get; set; }
    }
}
