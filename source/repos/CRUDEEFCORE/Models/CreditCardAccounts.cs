using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CreditCardAccounts
    {
        public string LocationCode { get; set; }
        public byte CreditCardId { get; set; }
        public int AccountId { get; set; }
        public decimal SignatureRequiredAmount { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }

        public virtual Accounts Accounts { get; set; }
        public virtual CreditCards CreditCards { get; set; }
        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
