using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ReasonGroups
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public int ReasonGroupCode { get; set; }
        public string DefaultDescription { get; set; }
        public string ModifiedDescription { get; set; }
        public bool TrackingGroup { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
