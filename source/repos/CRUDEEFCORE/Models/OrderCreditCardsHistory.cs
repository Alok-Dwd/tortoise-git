using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OrderCreditCardsHistory
    {
        public string LocationCode { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public int PaymentLineNumber { get; set; }
        public byte Sequence { get; set; }
        public byte CreditCardId { get; set; }
        public byte CreditCardTransactionType { get; set; }
        public byte[] CreditCardAccount { get; set; }
        public byte[] CreditCardExpiration { get; set; }
        public decimal CreditCardAmount { get; set; }
        public decimal CreditCardTip { get; set; }
        public string CreditCardApproval { get; set; }
        public string TransactionNumber { get; set; }
        public string NameOnCard { get; set; }
        public string AvsStreet { get; set; }
        public string PostalCode { get; set; }
        public string SecurityCode { get; set; }
        public byte CreditLoss { get; set; }
        public byte EntryMethod { get; set; }
        public DateTime? SettlementDate { get; set; }
        public byte ActionCode { get; set; }
        public string ReturnCode { get; set; }
        public string ResponseCode { get; set; }
        public string ReferenceNumber { get; set; }
        public string BatchNumber { get; set; }
        public string RetrievalReferenceCode { get; set; }
        public string AvsResultCode { get; set; }
        public string CardPresentValue { get; set; }
        public string ResponseText { get; set; }
        public string Comment { get; set; }
        public string InternalSeqNumber { get; set; }
        public int? TransItemNumber { get; set; }
        public string Aci { get; set; }
        public decimal? EstTipAmount { get; set; }
        public string ResultCode { get; set; }
        public string NetId { get; set; }
        public string CardIdCode { get; set; }
        public string AcctDataSource { get; set; }
        public string Cvv2ResultCode { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
