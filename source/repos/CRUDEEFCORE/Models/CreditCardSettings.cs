using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CreditCardSettings
    {
        public string LocationCode { get; set; }
        public byte CreditCardProcessing { get; set; }
        public string ThirdPartyDllFileLocation { get; set; }
        public string InFileLocation { get; set; }
        public string OutFileLocation { get; set; }
        public int DaysToKeepCcOrderHistory { get; set; }
        public string MerchantNumber { get; set; }
        public int MaxUnsettledDays { get; set; }
        public byte AvsSetting { get; set; }
        public byte Cvv2Setting { get; set; }
        public string Processor { get; set; }
        public string Ipaddress { get; set; }
        public string PortId { get; set; }
        public string UserName { get; set; }
        public byte[] Password { get; set; }
        public bool LogProcessorCommunications { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
