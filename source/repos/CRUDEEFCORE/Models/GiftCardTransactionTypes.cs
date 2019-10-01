using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class GiftCardTransactionTypes
    {
        public string LocationCode { get; set; }
        public byte TransactionType { get; set; }
        public string Description { get; set; }
    }
}
