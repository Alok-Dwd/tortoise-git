using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ViewTimeClockLog
    {
        public string LocationCode { get; set; }
        public int Id { get; set; }
        public byte FromTo { get; set; }
        public string EmployeeCode { get; set; }
        public string PositionCode { get; set; }
        public DateTime SystemDate { get; set; }
        public byte PositionShiftNumber { get; set; }
        public byte DateShiftNumber { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public double? BeginOdometer { get; set; }
        public double? EndOdometer { get; set; }
        public decimal? BonusPay { get; set; }
        public decimal? Tips { get; set; }
        public decimal? Collected { get; set; }
        public decimal? MileageRate { get; set; }
        public int? MileageRateUsed { get; set; }
        public decimal? BonusMileage { get; set; }
        public decimal? TotalPay { get; set; }
        public bool CarTop { get; set; }
        public bool PersonalCar { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
