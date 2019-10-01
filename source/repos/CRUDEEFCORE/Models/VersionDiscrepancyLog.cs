﻿using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class VersionDiscrepancyLog
    {
        public string LocationCode { get; set; }
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string SubType { get; set; }
        public string OldVersion { get; set; }
        public string NewVersion { get; set; }
        public DateTime AddedDate { get; set; }
        public string AddedBy { get; set; }
        public DateTime SetupModifiedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedIpAddress { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsResolved { get; set; }
        public DateTime LastAlertDate { get; set; }
    }
}
