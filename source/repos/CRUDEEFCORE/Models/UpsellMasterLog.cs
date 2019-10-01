﻿using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class UpsellMasterLog
    {
        public int Id { get; set; }
        public int FkIdUsm { get; set; }
        public string LocationCode { get; set; }
        public string MenuCode { get; set; }
        public string SizeCode { get; set; }
        public string Description { get; set; }
        public int? Priority { get; set; }
        public bool? StatusCode { get; set; }
        public bool? IsDeleted { get; set; }
        public string UserType { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Added { get; set; }
        public DateTime? AddedDate { get; set; }
    }
}
