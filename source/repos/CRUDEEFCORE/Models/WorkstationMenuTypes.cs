using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class WorkstationMenuTypes
    {
        public string LocationCode { get; set; }
        public int WorkstationId { get; set; }
        public int MenuTypeId { get; set; }
        public short DisplayOrder { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
