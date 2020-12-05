using DNotes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNotes.Data
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IconId { get; set; }
        public CharacterClass Class { get; set; }
        public int OwnerUserId { get; set; }
    }
}
