using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CorporateCustomer
    {
        public string LocationCode { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string Gstinno { get; set; }
        public string CompanyAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Extn { get; set; }
        public decimal? CreditAmount { get; set; }
        public int? PaymentTerm { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? Added { get; set; }
        public string AddedBy { get; set; }
        public string AddressType { get; set; }
    }
}
