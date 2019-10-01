using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ReportCategories
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public short CategoryId { get; set; }
        public string EnglishTextDescription { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public short? ParentId { get; set; }
    }
}
