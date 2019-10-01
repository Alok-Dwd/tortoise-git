using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class GiftCards
    {
        public string LocationCode { get; set; }
        public byte CreditCardId { get; set; }
        public string AccountNumber { get; set; }
        public DateTime ActivationDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal PresentAmount { get; set; }
        public string ActivationCode { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
