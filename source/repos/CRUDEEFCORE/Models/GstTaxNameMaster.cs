using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class GstTaxNameMaster
    {
        public string LocationCode { get; set; }
        public string Tax1Name { get; set; }
        public string Tax2Name { get; set; }
        public string Tax3Name { get; set; }
        public string Tax4Name { get; set; }
        public bool Tax1On { get; set; }
        public bool Tax2On { get; set; }
        public bool Tax3On { get; set; }
        public bool Tax4On { get; set; }
        public bool Tax1DeliveryApply { get; set; }
        public bool Tax1CarryOutApply { get; set; }
        public bool Tax1DineInApply { get; set; }
        public bool Tax1Odcapply { get; set; }
        public bool Tax2DeliveryApply { get; set; }
        public bool Tax2CarryOutApply { get; set; }
        public bool Tax2DineInApply { get; set; }
        public bool Tax2Odcapply { get; set; }
        public bool Tax3DeliveryApply { get; set; }
        public bool Tax3CarryOutApply { get; set; }
        public bool Tax3DineInApply { get; set; }
        public bool Tax3Odcapply { get; set; }
        public bool Tax4DeliveryApply { get; set; }
        public bool Tax4CarryOutApply { get; set; }
        public bool Tax4DineInApply { get; set; }
        public bool Tax4Odcapply { get; set; }
        public DateTime? Added { get; set; }
        public DateTime? Updated { get; set; }
        public string AddedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
