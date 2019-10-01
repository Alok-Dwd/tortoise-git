using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class UpsellMaster
    {
        public int Id { get; set; }
        public string LocationCode { get; set; }
        public string MenuCode { get; set; }
        public string SizeCode { get; set; }
        public string Description { get; set; }
        public int? Priority { get; set; }
        public bool? StatusCode { get; set; }
        public bool? Isdeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Added { get; set; }
        public string UserType { get; set; }
        public DateTime? AddedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual MenuItems MenuItems { get; set; }
    }
}
