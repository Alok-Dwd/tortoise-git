using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class WastageMaster
    {
        public string LocationCodes { get; set; }
        public int Id { get; set; }
        public string WastageName { get; set; }
        public bool? Active { get; set; }
    }
}
