using DNotes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNotes.Data
{
    public class Character
    {
        public Guid CharacterId { get; set; }
        public string CharacterName { get; set; }
        public CharacterClass Class { get; set; }
        public User Owner { get; set; }
    }
}
