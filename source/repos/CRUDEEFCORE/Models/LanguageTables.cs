using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class LanguageTables
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public string TableName { get; set; }
        public string KeyValue { get; set; }
        public string DefaultText { get; set; }
        public string UserModifiedText { get; set; }
    }
}
