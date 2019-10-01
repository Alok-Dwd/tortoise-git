using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MobInOrderApiStatus
    {
        public int Id { get; set; }
        public string MobInOrderApiStatusId { get; set; }
        public string MobInOrderApiStatusDesc { get; set; }
        public string FkMobInOrderStatusCode { get; set; }
        public bool IsActive { get; set; }
        public DateTime AddedDate { get; set; }
        public string AddedBy { get; set; }
        public string FkVlmOrderApiStatusId { get; set; }
    }
}
