using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class SerialPorts
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public byte SerialPortCode { get; set; }
        public string EnglishTextDescription { get; set; }
        public string Description { get; set; }
    }
}
