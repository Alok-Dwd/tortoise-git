using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class TimeClock
    {
        public string LocationCode { get; set; }
        public string EmployeeCode { get; set; }
        public string PositionCode { get; set; }
        public DateTime SystemDate { get; set; }
        public byte PositionShiftNumber { get; set; }
        public byte DateShiftNumber { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public double? BeginOdometer { get; set; }
        public double? EndOdometer { get; set; }
        public decimal TillStartingAmount { get; set; }
        public decimal PayRate { get; set; }
        public decimal BonusPay { get; set; }
        public decimal Tips { get; set; }
        public decimal Collected { get; set; }
        public decimal MileageRate { get; set; }
        public int? MileageRateUsed { get; set; }
        public decimal RegularMileage { get; set; }
        public decimal BonusMileage { get; set; }
        public decimal ExcessMileage { get; set; }
        public decimal TotalPay { get; set; }
        public decimal ContractPay { get; set; }
        public float Hours15 { get; set; }
        public float Hours20 { get; set; }
        public float Hours25 { get; set; }
        public bool CarTop { get; set; }
        public bool PersonalCar { get; set; }
        public decimal? CreditCardTips { get; set; }
        public decimal AllocatedTips { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
