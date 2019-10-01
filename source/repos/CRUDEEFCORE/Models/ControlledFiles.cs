using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ControlledFiles
    {
        public string LocationCode { get; set; }
        public string FileName { get; set; }
        public string DescriptionLong { get; set; }
        public string DescrptionShort { get; set; }
        public DateTime FileDate { get; set; }
        public int FileSize { get; set; }
        public string Version { get; set; }
        public bool RegistryUpdate { get; set; }
        public string Guid { get; set; }
        public bool MandantoryUpdate { get; set; }
        public int FileLocationCode { get; set; }
        public string MasterSourcePath { get; set; }
        public string StandardDestinationPath { get; set; }
        public int? UpdateBehaviorCode { get; set; }

        public virtual FileLocationCodes FileLocationCodes { get; set; }
        public virtual LocationCodes LocationCodeNavigation { get; set; }
        public virtual UpdateBehaviorCodes UpdateBehaviorCodes { get; set; }
    }
}
