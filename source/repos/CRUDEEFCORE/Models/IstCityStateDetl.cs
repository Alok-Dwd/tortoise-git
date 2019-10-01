using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class IstCityStateDetl
    {
        public string LocationCode { get; set; }
        public string TransferLocationCode { get; set; }
        public string SenderCity { get; set; }
        public string ReceiverCity { get; set; }
        public string SenderState { get; set; }
        public string ReceiverState { get; set; }
    }
}
