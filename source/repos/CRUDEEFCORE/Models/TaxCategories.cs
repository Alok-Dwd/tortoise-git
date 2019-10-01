using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class TaxCategories
    {
        public string LocationCode { get; set; }
        public int TaxCategoryId { get; set; }
        public string TaxCategoryCode { get; set; }
        public string TaxCategoryDescription { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
