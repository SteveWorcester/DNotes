using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNotes.Data
{
    public class Campaign
    {
        public int Id { get; set; }
        public Guid ShareGuid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<int> PendingCharacterIds { get; set; }
        public List<int> ActiveCharacterIds { get; set; }
        public List<int> NoteIds { get; set; }
    }
}
