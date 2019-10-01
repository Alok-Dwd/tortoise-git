using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class FileLocationCodes
    {
        public FileLocationCodes()
        {
            ControlledFiles = new HashSet<ControlledFiles>();
        }

        public string LocationCode { get; set; }
        public int FileLocationCode { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ControlledFiles> ControlledFiles { get; set; }
    }
}
