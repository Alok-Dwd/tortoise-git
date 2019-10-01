using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class RmpgetStreet
    {
        public string StreetId { get; set; }
        public int? StreetCode { get; set; }
        public string Sqlstreet { get; set; }
        public int? CityCode { get; set; }
        public string Rmpstreet { get; set; }
        public string RmpstreetCustFile { get; set; }
        public string CityName { get; set; }
    }
}
