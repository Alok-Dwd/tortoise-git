using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class Errors
    {
        public string LocationCode { get; set; }
        public int SequenceNumber { get; set; }
        public string Source { get; set; }
        public string Object { get; set; }
        public string SubRoutine { get; set; }
        public int? Error { get; set; }
        public DateTime Added { get; set; }
        public string Description { get; set; }
    }
}
