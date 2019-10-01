﻿using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class PosMessage
    {
        public int MessageId { get; set; }
        public string LocationCode { get; set; }
        public string Message { get; set; }
        public DateTime? MessageDate { get; set; }
        public string Apiresponse { get; set; }
        public string AddedBy { get; set; }
    }
}
