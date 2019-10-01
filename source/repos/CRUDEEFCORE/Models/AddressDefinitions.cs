using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class AddressDefinitions
    {
        public string LocationCode { get; set; }
        public short AddressDefinitionCode { get; set; }
        public short Sequence { get; set; }
        public string Modifier1 { get; set; }
        public string AddressField { get; set; }
        public short? Length { get; set; }
        public string Modifier2 { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Added { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
