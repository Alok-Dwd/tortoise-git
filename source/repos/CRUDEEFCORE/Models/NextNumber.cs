using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class NextNumber
    {
        public string LocationCode { get; set; }
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public int NextNum { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
