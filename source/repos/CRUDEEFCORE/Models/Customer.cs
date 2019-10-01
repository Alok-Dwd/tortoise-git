using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerProfileData = new HashSet<CustomerProfileData>();
        }

        public string LocationCode { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneExt { get; set; }
        public int CustomerCode { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string StreetNumber { get; set; }
        public int? StreetCode { get; set; }
        public int? CrossStreetCode { get; set; }
        public string Suite { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string MailingAddress { get; set; }
        public string PostalCode { get; set; }
        public string Plus4 { get; set; }
        public string Cart { get; set; }
        public string DeliveryPointCode { get; set; }
        public string WalkSequence { get; set; }
        public string AddressType { get; set; }
        public short SetDiscount { get; set; }
        public bool? TaxExempt1 { get; set; }
        public string TaxId1 { get; set; }
        public bool? TaxExempt2 { get; set; }
        public string TaxId2 { get; set; }
        public bool? TaxExempt3 { get; set; }
        public string TaxId3 { get; set; }
        public bool? TaxExempt4 { get; set; }
        public string TaxId4 { get; set; }
        public bool? AcceptChecks { get; set; }
        public bool? AcceptCreditCards { get; set; }
        public bool? AcceptGiftCards { get; set; }
        public bool AcceptChargeAccount { get; set; }
        public bool? AcceptCash { get; set; }
        public double FinanceChargeRate { get; set; }
        public int? PaymentTerms { get; set; }
        public decimal CreditLimit { get; set; }
        public DateTime? FirstOrderDate { get; set; }
        public DateTime LastOrderDate { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? AnniversaryDate { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
        public virtual Streets Streets { get; set; }
        public virtual ICollection<CustomerProfileData> CustomerProfileData { get; set; }
    }
}
