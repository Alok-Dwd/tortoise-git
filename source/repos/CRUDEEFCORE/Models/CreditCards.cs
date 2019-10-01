using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CreditCards
    {
        public CreditCards()
        {
            CreditCardsDescriptions = new HashSet<CreditCardsDescriptions>();
        }

        public string LocationCode { get; set; }
        public byte CreditCardId { get; set; }
        public string Description { get; set; }
        public byte? GiftCard { get; set; }
        public int? PayType { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
        public virtual CreditCardAccounts CreditCardAccounts { get; set; }
        public virtual ICollection<CreditCardsDescriptions> CreditCardsDescriptions { get; set; }
    }
}
