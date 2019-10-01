using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class GiftCardSettings
    {
        public string LocationCode { get; set; }
        public byte GiftCardProcessing { get; set; }
        public string ThirdPartyDllFileLocation { get; set; }
        public string InFileLocation { get; set; }
        public string OutFileLocation { get; set; }
        public int DaysToKeepGiftOrderHistory { get; set; }
        public int RedemptionAccountId { get; set; }
        public int LoadAccountId { get; set; }
        public string Processor { get; set; }
        public string MerchantNumber { get; set; }
        public string Ipaddress { get; set; }
        public string PortId { get; set; }
        public bool? TipCreatesNewTransaction { get; set; }
        public string UserName { get; set; }
        public byte[] Password { get; set; }
        public decimal CashBackAllowance { get; set; }
        public bool ShowItemsOnSalesReports { get; set; }
        public bool LogProcessorCommunications { get; set; }
        public byte MinCardNumberLength { get; set; }
        public byte MaxCardNumberLength { get; set; }
        public bool ActivationOnVoid { get; set; }
    }
}
