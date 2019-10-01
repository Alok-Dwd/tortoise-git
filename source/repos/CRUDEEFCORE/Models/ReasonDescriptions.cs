using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ReasonDescriptions
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public int ReasonDescriptionId { get; set; }
        public int ReasonId { get; set; }
        public string UserText { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
