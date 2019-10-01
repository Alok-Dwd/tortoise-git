using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class FormFields
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public string Form { get; set; }
        public string FieldName { get; set; }
        public string EnglishText { get; set; }
        public string ModifiedText { get; set; }
        public string EnglishToolTip { get; set; }
        public string ModifiedToolTip { get; set; }
    }
}
