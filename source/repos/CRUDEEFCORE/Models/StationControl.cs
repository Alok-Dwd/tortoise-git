using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class StationControl
    {
        public string LocationCode { get; set; }
        public short StationId { get; set; }
        public short? CreditCardId { get; set; }
    }
}
