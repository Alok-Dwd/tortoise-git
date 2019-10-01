using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class UpdateBehaviorCodes
    {
        public UpdateBehaviorCodes()
        {
            ControlledFiles = new HashSet<ControlledFiles>();
        }

        public string LocationCode { get; set; }
        public int UpdateBehaviorCode { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ControlledFiles> ControlledFiles { get; set; }
    }
}
