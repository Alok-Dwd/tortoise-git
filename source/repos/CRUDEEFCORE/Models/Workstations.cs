using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class Workstations
    {
        public string LocationCode { get; set; }
        public int WorkstationId { get; set; }
        public string WorkstationName { get; set; }
        public string WorkstationDescription { get; set; }
        public bool Server { get; set; }
        public bool BackupServer { get; set; }
        public bool? CanRunEod { get; set; }
        public bool? Eodreboot { get; set; }
        public string PosOrderTypePreference { get; set; }
        public bool AcceptCreditCards { get; set; }
        public bool AcceptGiftCards { get; set; }
        public bool AttachedFpScanner { get; set; }
        public bool KdShowCodes { get; set; }
        public bool KdShowAddress { get; set; }
        public bool KdShowSummary { get; set; }
        public bool KdUseBumpBar { get; set; }
        public byte KdDisplayOrientation { get; set; }
        public short KdRefreshRate { get; set; }
        public short StartUpScreenCode { get; set; }
        public bool ShowOrderTakersOrdersOnly { get; set; }
        public byte WorkstationTypeCode { get; set; }
        public int DefaultMenuType { get; set; }
        public bool CopyRegistrySettings { get; set; }
        public bool? RequirePhonePickUp { get; set; }
        public bool ShowOrderStatusModifyScreen { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
