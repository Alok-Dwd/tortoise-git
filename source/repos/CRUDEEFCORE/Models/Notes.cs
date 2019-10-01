using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class Notes
    {
        public string LocationCode { get; set; }
        public string NotesCode { get; set; }
        public string KeyField { get; set; }
        public DateTime EntryDate { get; set; }
        public int Sequence { get; set; }
        public string Notes1 { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Added { get; set; }
    }
}
