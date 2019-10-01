using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class AuditGroup
    {
        public AuditGroup()
        {
            AuditAction = new HashSet<AuditAction>();
        }

        public string LocationCode { get; set; }
        public int GroupId { get; set; }
        public short LanguageCode { get; set; }
        public string DefaultGroupDescription { get; set; }
        public string ModifiedGroupDescription { get; set; }

        public virtual ICollection<AuditAction> AuditAction { get; set; }
    }
}
