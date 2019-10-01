using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class StationUpdateList
    {
        public string LocationCode { get; set; }
        public string StationName { get; set; }
        public string FileUpdateList { get; set; }
        public string CallingApp { get; set; }
        public bool IsExecuting { get; set; }
    }
}
