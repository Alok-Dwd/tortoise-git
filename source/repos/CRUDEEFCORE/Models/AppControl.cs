using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class AppControl
    {
        public string LocationCode { get; set; }
        public string Version { get; set; }
        public string Beta { get; set; }
        public string SerialNumber { get; set; }
        public string LicensedCompany { get; set; }
        public bool? DebugMode { get; set; }
        public bool? TechSupport { get; set; }
        public bool CallerId { get; set; }
        public bool? MultiLocations { get; set; }
        public string DefaultLocationCode { get; set; }
        public string DefaultCurrency { get; set; }
        public byte? StartDayOfWeek { get; set; }
        public string IconDirectory { get; set; }
        public bool? CityTax { get; set; }
        public byte? TaxStructure { get; set; }
        public byte? MultiTaxType { get; set; }
        public decimal? TaxLimit { get; set; }
        public string PhoneMask { get; set; }
        public string PostalCodeMask { get; set; }
        public int? DefaultCityCode { get; set; }
        public string DefaultPostalCode { get; set; }
        public string DefaultPhonePrefix { get; set; }
        public decimal? DefaultDriverTill { get; set; }
        public decimal? DefaultInsideTill { get; set; }
        public short? DefaultMvrCheckInterval { get; set; }
        public string DefaultMvrIntervalCode { get; set; }
        public bool DefaultCarTopUse { get; set; }
        public bool DefaultCarType { get; set; }
        public bool? LogOutAfterEachOrder { get; set; }
        public bool? NewOrderNumbersEachDay { get; set; }
        public bool? ShowCoupons { get; set; }
        public bool? ShowQuantity { get; set; }
        public bool? ShowCodesOnTicket { get; set; }
        public bool? AutoRouteCarryOut { get; set; }
        public bool? AutoRouteDineIn { get; set; }
        public bool? AutoRoutePickUp { get; set; }
        public short? PricingMethod { get; set; }
        public bool? ToppingSubstitutions { get; set; }
        public decimal? DeliveryFee { get; set; }
        public bool? FeesTaxable { get; set; }
        public bool? FeesInRoyalty { get; set; }
        public bool DeliveryChargesInFoodCost { get; set; }
        public byte FoodLaborCouponMileage { get; set; }
        public byte PercentagesOfTotalNetRoyalty { get; set; }
        public decimal MinAmountPricePerOrder { get; set; }
        public decimal MaxAmountPricePerOrder { get; set; }
        public short CarryOutLeadTime { get; set; }
        public short DeliveryLeadTime { get; set; }
        public short GoalOrderTime { get; set; }
        public short GoalLoadTime { get; set; }
        public short GoalRouteTime { get; set; }
        public short GoalDeliveryTime { get; set; }
        public float GoalFood { get; set; }
        public float GoalLabor { get; set; }
        public float GoalMileage { get; set; }
        public float GoalCoupons { get; set; }
        public float GoalActualVsIfc { get; set; }
        public int DaysToKeepOrderLinesHistory { get; set; }
        public int DaysToKeepCallerLog { get; set; }
        public int DaysToKeepCustomers { get; set; }
        public int DaysToKeepOrderHistory { get; set; }
        public string ReceiptMessageTop { get; set; }
        public string ReceiptMessageBottom { get; set; }
        public byte QuantityForSingleSlip { get; set; }
        public short? ItemsPerLabel { get; set; }
        public int HourlyMakeLineItems { get; set; }
        public int HourlyDeliveryItems { get; set; }
        public byte DriverMap { get; set; }
        public byte MarketingMap { get; set; }
        public bool Insight { get; set; }
        public byte GovernmentReceipt { get; set; }
        public DateTime? LastUpdated { get; set; }
        public int? DefaultCarryOutCityCode { get; set; }
        public string DefaultCarryOutPostalCode { get; set; }
        public float? CashTipPct { get; set; }
        public bool? DriverOutPassword { get; set; }
        public bool? StoreMonitor { get; set; }
        public bool? DoublesPricingOn { get; set; }
        public short? DoublesPricingPricingType { get; set; }
        public short? DoublesPricingCalcMethod { get; set; }
        public short? DoublesPricingType { get; set; }
        public int? ModifyOptions { get; set; }
        public int? DaysToKeepReprintBillLog { get; set; }

        public virtual CurrencyType CurrencyType { get; set; }
        public virtual LocationCodes DefaultLocationCodeNavigation { get; set; }
        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
