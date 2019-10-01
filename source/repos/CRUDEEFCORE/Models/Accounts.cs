using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class Accounts
    {
        public Accounts()
        {
            CreditCardAccounts = new HashSet<CreditCardAccounts>();
        }

        public string LocationCode { get; set; }
        public int AccountId { get; set; }
        public string AccountCode { get; set; }
        public string AccountDescription { get; set; }
        public byte AccountTypeCode { get; set; }
        public bool SystemAccount { get; set; }
        public byte PostingType { get; set; }
        public byte PostingDestination { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
        public virtual ICollection<CreditCardAccounts> CreditCardAccounts { get; set; }
    }
}
