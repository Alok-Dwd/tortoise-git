using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ApplicationUpdateHistory
    {
        public string LocationCode { get; set; }
        public int WorkstationId { get; set; }
        public string VersionNumber { get; set; }
        public string HotFixNumber { get; set; }
        public string UpdateDescription { get; set; }
        public string FilesAffected { get; set; }
        public DateTime UpdateTime { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
