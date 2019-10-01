using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class Vendor
    {
        public Vendor()
        {
            Deliveries = new HashSet<Deliveries>();
        }

        public string LocationCode { get; set; }
        public string VendorCode { get; set; }
        public short StatusCode { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
        public string VendorType { get; set; }

        public virtual ICollection<Deliveries> Deliveries { get; set; }
    }
}
