using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class Streets
    {
        public Streets()
        {
            Customer = new HashSet<Customer>();
        }

        public string LocationCode { get; set; }
        public int StreetCode { get; set; }
        public string PreDirection { get; set; }
        public string StreetName { get; set; }
        public string PostDirection { get; set; }
        public int? CityCode { get; set; }
        public bool? AddedManually { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
    }
}
