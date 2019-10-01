using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class DailySummaryLogData
    {
        public string LocationCode { get; set; }
        public DateTime SystemDate { get; set; }
        public decimal MasterTotal { get; set; }
        public decimal VoidOrders { get; set; }
        public decimal BadOrders { get; set; }
        public decimal TotalSales { get; set; }
        public decimal SalesTax { get; set; }
        public decimal BottleDeposits { get; set; }
        public decimal NetSales { get; set; }
        public decimal Coupons { get; set; }
        public decimal NonRoyaltySales { get; set; }
        public decimal RoyaltySales { get; set; }
        public decimal DeliveryCompanyCar { get; set; }
        public decimal DeliveryPersonalCar { get; set; }
        public decimal CarryOut { get; set; }
        public decimal PickUp { get; set; }
        public decimal DineIn { get; set; }
        public decimal Food { get; set; }
        public decimal Labor { get; set; }
        public decimal Mileage { get; set; }
        public decimal FoodBought { get; set; }
        public decimal RaiseTill { get; set; }
        public decimal MileageAll { get; set; }
        public decimal ContractLabor { get; set; }
        public decimal TotalCpo { get; set; }
        public decimal FoodSold { get; set; }
        public decimal LowerTill { get; set; }
        public decimal TotalMrots { get; set; }
        public decimal BankDeposits { get; set; }
        public decimal TillOverride { get; set; }
        public decimal EndingTill { get; set; }
        public string Manager { get; set; }
        public int TotalOrders { get; set; }
        public int MinOrderNumber { get; set; }
        public int MaxOrderNumber { get; set; }
        public int OrdersInRange { get; set; }
        public decimal MinPricePerOrder { get; set; }
        public decimal MaxPricePerOrder { get; set; }
        public decimal AveragePrice { get; set; }
        public float AverageOrderTime { get; set; }
        public float AverageLoadTime { get; set; }
        public float AverageOtdTime { get; set; }
        public float AverageDeliveryTime { get; set; }
        public decimal InsideLabor { get; set; }
        public decimal OutsideLabor { get; set; }
        public decimal HourlyLabor { get; set; }
        public decimal SalaryLabor { get; set; }
        public decimal AdvertisedDiscounts { get; set; }
        public decimal ManagerDiscounts { get; set; }
        public decimal TotalDiscounts { get; set; }
        public int OnTimeOrderCount { get; set; }
        public int LateOrderCount { get; set; }
        public decimal Credits { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
        public DateTime? Logtime { get; set; }
        public decimal? Logtype { get; set; }
        public string EmpCode { get; set; }
    }
}
