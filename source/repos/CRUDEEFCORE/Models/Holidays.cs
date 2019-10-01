using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class Holidays
    {
        public string LocationCode { get; set; }
        public DateTime HolidayDate { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Added { get; set; }
    }
}
