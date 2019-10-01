using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ProductOsgs
    {
        public string LocationCode { get; set; }
        public string ProdCatCode { get; set; }
        public string ProdOsgCode { get; set; }
        public int ProdOsgDisplaySeq { get; set; }
        public bool ProdOsgIsActive { get; set; }
        public string ProdOsgDescText { get; set; }
        public string ProdOsgShortDescText { get; set; }
        public string ProdOsgPosDescText { get; set; }
        public bool ProdOsgIsAllowSubstitutions { get; set; }
        public string PrOsgTypeCode { get; set; }
    }
}
