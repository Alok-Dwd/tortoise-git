using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class PcDevices
    {
        public string LocationCode { get; set; }
        public int DeviceId { get; set; }
        public int WorkstationId { get; set; }
        public string Description { get; set; }
        public byte DeviceTypeCode { get; set; }
        public int? ZebraHeatSetting { get; set; }
        public int NumberOfCopies { get; set; }
        public int ReceiptWidth { get; set; }
        public short PortTypeCode { get; set; }
        public string PortName { get; set; }
        public bool KpShowCodes { get; set; }
        public byte KpItemVisibility { get; set; }
        public bool KitchenReceipt { get; set; }
        public bool OrderReceipt { get; set; }
        public bool SignatureReceipt { get; set; }
        public bool MenuItemReceipt { get; set; }
        public bool TillReceipt { get; set; }
        public bool MapDirections { get; set; }
        public bool VoidBadReceipt { get; set; }
        public bool CashDropReceipt { get; set; }
        public bool CashOutReceipt { get; set; }
        public bool ShowDiscountsReceipt { get; set; }
        public bool ShowPrinterInformation { get; set; }
        public bool MenuItemLabel { get; set; }
        public bool VoidBadLabel { get; set; }
        public bool CashDropLabel { get; set; }
        public bool DriverLabel { get; set; }
        public bool TaxLabel { get; set; }
        public bool ShowCodesLabel { get; set; }
        public bool CustomerLabel { get; set; }
        public int? MakeLineCode { get; set; }
        public byte DeviceInterfaceTypeCode { get; set; }
        public bool NutritionalLabel { get; set; }
        public bool TimeClockConfirmation { get; set; }
        public bool PreparationLabel { get; set; }
        public bool PopDrawerChargeAccount { get; set; }
        public bool PopDrawerCheck { get; set; }
        public bool PopDrawerCreditCard { get; set; }
        public bool PopDrawerGiftCard { get; set; }
        public bool PreparationReceipt { get; set; }
        public bool CheckOutReceipt { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
        public bool AbandedReceipt { get; set; }
        public bool ReprintReceipt { get; set; }
    }
}
