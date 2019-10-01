using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class RegModuleList
    {
        public string LocationCode { get; set; }
        public int KeyLocation { get; set; }
        public byte OnOffProd { get; set; }
        public string ProgramName { get; set; }
        public string ExeName { get; set; }
        public short VisionCore { get; set; }
    }
}
