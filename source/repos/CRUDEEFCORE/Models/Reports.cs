using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class Reports
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public short CategoryId { get; set; }
        public short ReportId { get; set; }
        public string EnglishTextDescription { get; set; }
        public string Description { get; set; }
        public bool LocationRequired { get; set; }
        public bool DateRangeRequired { get; set; }
        public bool? DisplayDateRange { get; set; }
        public short DisplayOrder { get; set; }
        public bool ModifyFields { get; set; }
        public bool ModifyOrder { get; set; }
        public byte LastDateType { get; set; }
        public bool? BatchReport { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int VbMenuItemId { get; set; }
        public bool IsSharedReport { get; set; }
    }
}
