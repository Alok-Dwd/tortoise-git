using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ReportFields
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public short ReportId { get; set; }
        public string FieldName { get; set; }
        public byte Section { get; set; }
        public string EnglishText { get; set; }
        public string ModifiedText { get; set; }
        public byte ViewOrder { get; set; }
        public int DefaultField { get; set; }
        public bool? FieldList { get; set; }
        public bool? Removable { get; set; }
        public byte SortOrder { get; set; }
        public bool Descending { get; set; }
    }
}
