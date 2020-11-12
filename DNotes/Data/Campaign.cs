using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNotes.Data
{
    public class Campaign
    {
        public Guid CampaignId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Character> AllCharacters { get; set; }
        public List<Note> TopLevelNotes { get; set; }
        public List<Note> AllNotes { get; set; }
    }
}
