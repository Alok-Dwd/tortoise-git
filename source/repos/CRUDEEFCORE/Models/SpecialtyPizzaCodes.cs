using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class SpecialtyPizzaCodes
    {
        public string LocationCode { get; set; }
        public string MenuCode { get; set; }
        public string SpecialtyPizzaCode { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
