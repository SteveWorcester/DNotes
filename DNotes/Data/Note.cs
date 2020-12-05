using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DNotes.Data
{
    public class Note
    {
        public int Id { get; set; }
        public int ParentNoteId { get; set; }
        public List<int> SharedWithCharacterIds { get; set; }
        public string Text { get; set; }
        public string Shorthand { get; set; }
        public int AdminUserId { get; set; }
        public List<int> ChildrenNoteIds { get; set; }
        public int IconId { get; set; }
    }
}
