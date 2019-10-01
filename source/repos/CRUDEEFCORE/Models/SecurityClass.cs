using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class SecurityClass
    {
        public string LocationCode { get; set; }
        public string SecurityClassCode { get; set; }
        public string SecurityClassDescription { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
