using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class AuditAction
    {
        public string LocationCode { get; set; }
        public int ActionId { get; set; }
        public short LanguageCode { get; set; }
        public string DefaultActionDescription { get; set; }
        public string ModifiedActionDescription { get; set; }
        public string FieldList { get; set; }
        public int GroupId { get; set; }

        public virtual AuditGroup AuditGroup { get; set; }
    }
}
