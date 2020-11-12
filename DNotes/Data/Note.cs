using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNotes.Data
{
    public class Note
    {
        public Guid NoteId { get; set; }
        public Note ParentNote { get; set; }
        public List<Character> SharedWith { get; set; }
        public string NoteText { get; set; }
        public string Shorthand { get; set; }
        public Guid AdminId { get; set; }
        public List<Note> ChildNotes { get; set; }

        // public Bitmap Icon { get; set; }
    }
}
