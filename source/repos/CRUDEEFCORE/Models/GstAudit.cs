using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class GstAudit
    {
        public string GstTaxCategoryMaster { get; set; }
        public string GstTaxCityMasterIst { get; set; }
        public string GstNonGstComplianceStoreMaster { get; set; }
        public string GstNonAcStoreMaster { get; set; }
        public string GstTaxCityMaster { get; set; }
        public string GstTaxNameMaster { get; set; }
        public string IstCityStateDetl { get; set; }
        public string GstMrpItemsBasePrice { get; set; }
        public string GstInventoryMaster { get; set; }
        public string GstApplicable { get; set; }
        public string UseUserDefinedTax1 { get; set; }
        public string UserDefinedTax1Description { get; set; }
        public string UserDefinedTax1Delivery { get; set; }
        public string UserDefinedTax1CarryOut { get; set; }
        public string UserDefinedTax1DineIn { get; set; }
        public string UserDefinedTax1Pickup { get; set; }
        public string UseUserDefinedTax2 { get; set; }
        public string UserDefinedTax2Description { get; set; }
        public string UserDefinedTax2Delivery { get; set; }
        public string UserDefinedTax2CarryOut { get; set; }
        public string UserDefinedTax2DineIn { get; set; }
        public string UserDefinedTax2Pickup { get; set; }
        public string UseUserDefinedTax3 { get; set; }
        public string UserDefinedTax3Description { get; set; }
        public string UserDefinedTax3Delivery { get; set; }
        public string UserDefinedTax3CarryOut { get; set; }
        public string UserDefinedTax3DineIn { get; set; }
        public string UserDefinedTax3Pickup { get; set; }
        public string UseUserDefinedTax4 { get; set; }
        public string UserDefinedTax4Description { get; set; }
        public string UserDefinedTax4Delivery { get; set; }
        public string UserDefinedTax4CarryOut { get; set; }
        public string UserDefinedTax4DineIn { get; set; }
        public string UserDefinedTax4Pickup { get; set; }
        public string TaxNameRecords { get; set; }
        public string ReceiptMessageTop { get; set; }
        public string ReceiptMessageBottom { get; set; }
        public string CategoriesCount { get; set; }
        public string CityCount { get; set; }
        public string RegionCount { get; set; }
        public string MenuTaxCount { get; set; }
        public string MenuTaxCountGstpreparedFood { get; set; }
        public string MenuTaxCountGstpreparedBeverages { get; set; }
        public string MenuTaxCountGstnonPreparedBeverages { get; set; }
        public string MenuTaxCountGstnonPreparedOthers { get; set; }
        public string InvTaxCount { get; set; }
        public string InvTaxCountGstinventory5Per { get; set; }
        public string InvTaxCountGstinventory12Per { get; set; }
        public string InvTaxCountGstinventory18Per { get; set; }
        public string InvTaxCountGstinventory28Per { get; set; }
        public string InvTaxCountGstinventory2812Per { get; set; }
    }
}
