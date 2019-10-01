using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class WorkstationPort
    {
        public int Id { get; set; }
        public int? Portno { get; set; }
        public string WorkstationName { get; set; }
    }
}
