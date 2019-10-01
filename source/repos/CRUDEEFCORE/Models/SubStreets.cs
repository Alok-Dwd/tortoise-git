using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class SubStreets
    {
        public string LocationCode { get; set; }
        public int SequenceNumber { get; set; }
        public int? StreetCode { get; set; }
        public string PriLowerBound { get; set; }
        public string PriUpperBound { get; set; }
        public short? PriOddEven { get; set; }
        public string SecLowerBound { get; set; }
        public string SecUpperBound { get; set; }
        public short? SecOddEven { get; set; }
        public string CarRoute { get; set; }
        public string Zip4LowerBound { get; set; }
        public string Zip4UpperBound { get; set; }
        public string PostalCode { get; set; }
        public bool? AddedManually { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
