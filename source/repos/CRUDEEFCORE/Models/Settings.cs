using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class Settings
    {
        public int Id { get; set; }
        public string LocationCode { get; set; }
        public int? WorkstationId { get; set; }
        public string SettingName { get; set; }
        public string SettingValue { get; set; }
    }
}
