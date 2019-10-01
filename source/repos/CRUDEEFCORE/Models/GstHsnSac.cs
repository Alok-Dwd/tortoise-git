using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class GstHsnSac
    {
        public string LocationCode { get; set; }
        public string HsnSacCode { get; set; }
        public string HsnSacAbbr { get; set; }
        public string StatusCode { get; set; }
        public string Description { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
