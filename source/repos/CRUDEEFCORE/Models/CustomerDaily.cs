using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CustomerDaily
    {
        public string LocationCode { get; set; }
        public int CustomerCode { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneExt { get; set; }
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
        public string AddressType { get; set; }
        public short? SetDiscount { get; set; }
        public bool? TaxExempt1 { get; set; }
        public string TaxId1 { get; set; }
        public bool? TaxExempt2 { get; set; }
        public string TaxId2 { get; set; }
        public bool? TaxExempt3 { get; set; }
        public string TaxId3 { get; set; }
        public bool? TaxExempt4 { get; set; }
        public string TaxId4 { get; set; }
        public string PreDirection { get; set; }
        public string StreetName { get; set; }
        public string PostDirection { get; set; }
        public string CityName { get; set; }
        public float? TaxRate1 { get; set; }
        public float? TaxRate2 { get; set; }
        public string RegionName { get; set; }
        public string RegionAbbr { get; set; }
        public int? SectorKey { get; set; }
        public string CrossStreetName { get; set; }
        public string Plus4 { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
