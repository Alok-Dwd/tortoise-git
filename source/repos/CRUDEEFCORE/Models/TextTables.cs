using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class TextTables
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public int Id { get; set; }
        public string TableName { get; set; }
        public string EnglishTableName { get; set; }
        public string DisplayTableName { get; set; }
        public string TableOrder { get; set; }
    }
}
