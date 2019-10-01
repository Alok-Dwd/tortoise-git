using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class Position
    {
        public string LocationCode { get; set; }
        public string PositionCode { get; set; }
        public string Position1 { get; set; }
        public bool? Driver { get; set; }
        public bool? Manager { get; set; }
        public bool? Inside { get; set; }
        public bool? RequireTill { get; set; }
        public decimal TillStartingAmount { get; set; }
        public bool? RequireFoodLicense { get; set; }
        public bool? RequireDl { get; set; }
        public bool? RequireCarRegistration { get; set; }
        public bool? RequireCarInspection { get; set; }
        public bool? RequireInsurance { get; set; }
        public bool? RequireMvr { get; set; }
        public short MvrCheckInterval { get; set; }
        public string MvrIntervalCode { get; set; }
        public bool? TextColor { get; set; }
        public bool? CalculateTips { get; set; }
        public byte[] PositionImage { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
