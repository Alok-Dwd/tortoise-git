using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class Reasons
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public int ReasonId { get; set; }
        public int ReasonGroupCode { get; set; }
        public string SystemText { get; set; }
        public bool? Active { get; set; }
        public int DisplayOrder { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
