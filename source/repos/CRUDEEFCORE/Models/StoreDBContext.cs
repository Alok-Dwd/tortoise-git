using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CRUDEEFCORE.Models
{
    public partial class StoreDBContext : DbContext
    {
        public StoreDBContext()
        {
        }

        public StoreDBContext(DbContextOptions<StoreDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountSubHead> AccountSubHead { get; set; }
        public virtual DbSet<AccountTypes> AccountTypes { get; set; }
        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<AccountsExpLimit> AccountsExpLimit { get; set; }
        public virtual DbSet<AddressDefinitionType> AddressDefinitionType { get; set; }
        public virtual DbSet<AddressDefinitions> AddressDefinitions { get; set; }
        public virtual DbSet<AddressLookup> AddressLookup { get; set; }
        public virtual DbSet<AddressTypes> AddressTypes { get; set; }
        public virtual DbSet<AdminLevelCodes> AdminLevelCodes { get; set; }
        public virtual DbSet<AodLog> AodLog { get; set; }
        public virtual DbSet<AodTimeMapping> AodTimeMapping { get; set; }
        public virtual DbSet<AppControl> AppControl { get; set; }
        public virtual DbSet<ApplicationUpdateHistory> ApplicationUpdateHistory { get; set; }
        public virtual DbSet<ArAgingMethodTypes> ArAgingMethodTypes { get; set; }
        public virtual DbSet<ArAgingMethodTypesDescriptions> ArAgingMethodTypesDescriptions { get; set; }
        public virtual DbSet<ArSettings> ArSettings { get; set; }
        public virtual DbSet<ArTermTypes> ArTermTypes { get; set; }
        public virtual DbSet<ArTermTypesDescriptions> ArTermTypesDescriptions { get; set; }
        public virtual DbSet<ArTransactionStatusTypes> ArTransactionStatusTypes { get; set; }
        public virtual DbSet<ArTransactionStatusTypesDescriptions> ArTransactionStatusTypesDescriptions { get; set; }
        public virtual DbSet<ArTransactionTypes> ArTransactionTypes { get; set; }
        public virtual DbSet<ArTransactionTypesDescriptions> ArTransactionTypesDescriptions { get; set; }
        public virtual DbSet<ArTransactions> ArTransactions { get; set; }
        public virtual DbSet<ArTransactionsDetail> ArTransactionsDetail { get; set; }
        public virtual DbSet<AttributeGroupAttributes> AttributeGroupAttributes { get; set; }
        public virtual DbSet<AttributeGroups> AttributeGroups { get; set; }
        public virtual DbSet<Attributes> Attributes { get; set; }
        public virtual DbSet<AuditAction> AuditAction { get; set; }
        public virtual DbSet<AuditEvents> AuditEvents { get; set; }
        public virtual DbSet<AuditGroup> AuditGroup { get; set; }
        public virtual DbSet<AuditTrail> AuditTrail { get; set; }
        public virtual DbSet<AuditTrailReportOptions> AuditTrailReportOptions { get; set; }
        public virtual DbSet<AvgOrd> AvgOrd { get; set; }
        public virtual DbSet<BaanDataTmp> BaanDataTmp { get; set; }
        public virtual DbSet<BatchInstallerLogs> BatchInstallerLogs { get; set; }
        public virtual DbSet<BeatsOrderLine> BeatsOrderLine { get; set; }
        public virtual DbSet<BioForceLog> BioForceLog { get; set; }
        public virtual DbSet<BumpBarKey> BumpBarKey { get; set; }
        public virtual DbSet<CallCenterMessage> CallCenterMessage { get; set; }
        public virtual DbSet<CallSmdr> CallSmdr { get; set; }
        public virtual DbSet<CallerId> CallerId { get; set; }
        public virtual DbSet<CallerIdConnectionTypes> CallerIdConnectionTypes { get; set; }
        public virtual DbSet<CallerIdCustSetting> CallerIdCustSetting { get; set; }
        public virtual DbSet<CallerIdLog> CallerIdLog { get; set; }
        public virtual DbSet<CallerIdPhoneNo> CallerIdPhoneNo { get; set; }
        public virtual DbSet<CallerIdSettings> CallerIdSettings { get; set; }
        public virtual DbSet<CashDrawerAudit> CashDrawerAudit { get; set; }
        public virtual DbSet<CheckMultipleOrders> CheckMultipleOrders { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<ColumnDescriptions> ColumnDescriptions { get; set; }
        public virtual DbSet<ControlProperties> ControlProperties { get; set; }
        public virtual DbSet<ControlledFiles> ControlledFiles { get; set; }
        public virtual DbSet<CorporateCustomer> CorporateCustomer { get; set; }
        public virtual DbSet<CountType> CountType { get; set; }
        public virtual DbSet<CouponAppledRule> CouponAppledRule { get; set; }
        public virtual DbSet<CouponAppliedDay> CouponAppliedDay { get; set; }
        public virtual DbSet<CouponBogo> CouponBogo { get; set; }
        public virtual DbSet<CouponDayMaster> CouponDayMaster { get; set; }
        public virtual DbSet<CouponHappyHour> CouponHappyHour { get; set; }
        public virtual DbSet<CouponRuleEngine> CouponRuleEngine { get; set; }
        public virtual DbSet<CouponTypes> CouponTypes { get; set; }
        public virtual DbSet<Coupons> Coupons { get; set; }
        public virtual DbSet<CouponsCapping> CouponsCapping { get; set; }
        public virtual DbSet<CouponsExemptedItems> CouponsExemptedItems { get; set; }
        public virtual DbSet<CreditCardAccounts> CreditCardAccounts { get; set; }
        public virtual DbSet<CreditCardActionCodes> CreditCardActionCodes { get; set; }
        public virtual DbSet<CreditCardActionCodesDescriptions> CreditCardActionCodesDescriptions { get; set; }
        public virtual DbSet<CreditCardEntryMethods> CreditCardEntryMethods { get; set; }
        public virtual DbSet<CreditCardEntryMethodsDescriptions> CreditCardEntryMethodsDescriptions { get; set; }
        public virtual DbSet<CreditCardNumberRanges> CreditCardNumberRanges { get; set; }
        public virtual DbSet<CreditCardProcessingTypes> CreditCardProcessingTypes { get; set; }
        public virtual DbSet<CreditCardSettings> CreditCardSettings { get; set; }
        public virtual DbSet<CreditCardTransaction> CreditCardTransaction { get; set; }
        public virtual DbSet<CreditCardTransactionTypes> CreditCardTransactionTypes { get; set; }
        public virtual DbSet<CreditCardTransactionTypesDescriptions> CreditCardTransactionTypesDescriptions { get; set; }
        public virtual DbSet<CreditCardVendor> CreditCardVendor { get; set; }
        public virtual DbSet<CreditCards> CreditCards { get; set; }
        public virtual DbSet<CreditCardsDescriptions> CreditCardsDescriptions { get; set; }
        public virtual DbSet<CurrencyCommonBills> CurrencyCommonBills { get; set; }
        public virtual DbSet<CurrencyExchange> CurrencyExchange { get; set; }
        public virtual DbSet<CurrencyType> CurrencyType { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerDaily> CustomerDaily { get; set; }
        public virtual DbSet<CustomerGstin> CustomerGstin { get; set; }
        public virtual DbSet<CustomerLookup> CustomerLookup { get; set; }
        public virtual DbSet<CustomerLookupTypes> CustomerLookupTypes { get; set; }
        public virtual DbSet<CustomerProfileData> CustomerProfileData { get; set; }
        public virtual DbSet<CustomerProfileTypes> CustomerProfileTypes { get; set; }
        public virtual DbSet<DailyBackup> DailyBackup { get; set; }
        public virtual DbSet<DailyInventory> DailyInventory { get; set; }
        public virtual DbSet<DailyInventoryBad> DailyInventoryBad { get; set; }
        public virtual DbSet<DailyInventoryDetail> DailyInventoryDetail { get; set; }
        public virtual DbSet<DailyInventoryLog> DailyInventoryLog { get; set; }
        public virtual DbSet<DailyInventoryPrep> DailyInventoryPrep { get; set; }
        public virtual DbSet<DailyInventoryPrepDetail> DailyInventoryPrepDetail { get; set; }
        public virtual DbSet<DailySummary> DailySummary { get; set; }
        public virtual DbSet<DailySummaryLogData> DailySummaryLogData { get; set; }
        public virtual DbSet<DailySummaryLogData1> DailySummaryLogData1 { get; set; }
        public virtual DbSet<DatabaseEventLog> DatabaseEventLog { get; set; }
        public virtual DbSet<DateIntervalTypes> DateIntervalTypes { get; set; }
        public virtual DbSet<DayOfWeekValues> DayOfWeekValues { get; set; }
        public virtual DbSet<DbManagerLogger> DbManagerLogger { get; set; }
        public virtual DbSet<DefaultCurrencyHistory> DefaultCurrencyHistory { get; set; }
        public virtual DbSet<Deliveries> Deliveries { get; set; }
        public virtual DbSet<DeliveriesTmp> DeliveriesTmp { get; set; }
        public virtual DbSet<DeliveryAmount> DeliveryAmount { get; set; }
        public virtual DbSet<DeliveryAmountTmp> DeliveryAmountTmp { get; set; }
        public virtual DbSet<DeliveryFee> DeliveryFee { get; set; }
        public virtual DbSet<DeliveryFeeExemptedItem> DeliveryFeeExemptedItem { get; set; }
        public virtual DbSet<DeliveryFeeMov> DeliveryFeeMov { get; set; }
        public virtual DbSet<DeliveryTypeCodes> DeliveryTypeCodes { get; set; }
        public virtual DbSet<DeviceInterfaceTypes> DeviceInterfaceTypes { get; set; }
        public virtual DbSet<DriverTpeLog> DriverTpeLog { get; set; }
        public virtual DbSet<DriverTrackExeInfo> DriverTrackExeInfo { get; set; }
        public virtual DbSet<DriverTrackId> DriverTrackId { get; set; }
        public virtual DbSet<DriverTrackOrderNumber> DriverTrackOrderNumber { get; set; }
        public virtual DbSet<DriverTrackOrderNumberDetails> DriverTrackOrderNumberDetails { get; set; }
        public virtual DbSet<DriverTrackReturnOrderNumber> DriverTrackReturnOrderNumber { get; set; }
        public virtual DbSet<DriverTrackReturnOrderNumberDetails> DriverTrackReturnOrderNumberDetails { get; set; }
        public virtual DbSet<Dual> Dual { get; set; }
        public virtual DbSet<DuplicatePrint> DuplicatePrint { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeCashDrop> EmployeeCashDrop { get; set; }
        public virtual DbSet<EmployeeClass> EmployeeClass { get; set; }
        public virtual DbSet<EmployeeClassOverride> EmployeeClassOverride { get; set; }
        public virtual DbSet<EmployeeFingerprint> EmployeeFingerprint { get; set; }
        public virtual DbSet<EmployeePosition> EmployeePosition { get; set; }
        public virtual DbSet<EodDataSyncLog> EodDataSyncLog { get; set; }
        public virtual DbSet<EodDataSyncMailfailover> EodDataSyncMailfailover { get; set; }
        public virtual DbSet<EodError> EodError { get; set; }
        public virtual DbSet<EodLog> EodLog { get; set; }
        public virtual DbSet<EodprocessLog> EodprocessLog { get; set; }
        public virtual DbSet<EodpromptMessage> EodpromptMessage { get; set; }
        public virtual DbSet<EodvarianceLog> EodvarianceLog { get; set; }
        public virtual DbSet<Errors> Errors { get; set; }
        public virtual DbSet<ExtraScriptDday> ExtraScriptDday { get; set; }
        public virtual DbSet<ExtraScriptLog> ExtraScriptLog { get; set; }
        public virtual DbSet<FileLocationCodes> FileLocationCodes { get; set; }
        public virtual DbSet<FinancialReportDataSources> FinancialReportDataSources { get; set; }
        public virtual DbSet<FinancialReportDataSourcesDescriptions> FinancialReportDataSourcesDescriptions { get; set; }
        public virtual DbSet<FinancialReportDesignDetails> FinancialReportDesignDetails { get; set; }
        public virtual DbSet<FinancialReportDesigns> FinancialReportDesigns { get; set; }
        public virtual DbSet<FinancialReportDetails> FinancialReportDetails { get; set; }
        public virtual DbSet<FinancialReportFormatTypes> FinancialReportFormatTypes { get; set; }
        public virtual DbSet<FinancialReportFormatTypesDescriptions> FinancialReportFormatTypesDescriptions { get; set; }
        public virtual DbSet<FinancialReportLineTypes> FinancialReportLineTypes { get; set; }
        public virtual DbSet<FinancialReportLineTypesDescriptions> FinancialReportLineTypesDescriptions { get; set; }
        public virtual DbSet<FinancialReportLinks> FinancialReportLinks { get; set; }
        public virtual DbSet<FinancialReportTypes> FinancialReportTypes { get; set; }
        public virtual DbSet<FinancialReportTypesDescriptions> FinancialReportTypesDescriptions { get; set; }
        public virtual DbSet<FinancialReports> FinancialReports { get; set; }
        public virtual DbSet<FormFields> FormFields { get; set; }
        public virtual DbSet<GiftCardSettings> GiftCardSettings { get; set; }
        public virtual DbSet<GiftCardTransactionTypes> GiftCardTransactionTypes { get; set; }
        public virtual DbSet<GiftCardTransactionTypesDescriptions> GiftCardTransactionTypesDescriptions { get; set; }
        public virtual DbSet<GiftCards> GiftCards { get; set; }
        public virtual DbSet<GovernmentReceipts> GovernmentReceipts { get; set; }
        public virtual DbSet<GstAudit> GstAudit { get; set; }
        public virtual DbSet<GstCity> GstCity { get; set; }
        public virtual DbSet<GstHsnSac> GstHsnSac { get; set; }
        public virtual DbSet<GstHsnSacMenuItem> GstHsnSacMenuItem { get; set; }
        public virtual DbSet<GstHsnSacMenuItemSizes> GstHsnSacMenuItemSizes { get; set; }
        public virtual DbSet<GstInventoryItemsDomFinal> GstInventoryItemsDomFinal { get; set; }
        public virtual DbSet<GstInventoryItemsTaxHsn> GstInventoryItemsTaxHsn { get; set; }
        public virtual DbSet<GstInventoryMaster> GstInventoryMaster { get; set; }
        public virtual DbSet<GstMrpItemsBasePrice> GstMrpItemsBasePrice { get; set; }
        public virtual DbSet<GstNonAcStoreMaster> GstNonAcStoreMaster { get; set; }
        public virtual DbSet<GstNonGstComplianceStoreMaster> GstNonGstComplianceStoreMaster { get; set; }
        public virtual DbSet<GstRegions> GstRegions { get; set; }
        public virtual DbSet<GstSacMaster> GstSacMaster { get; set; }
        public virtual DbSet<GstStoreCityMaster> GstStoreCityMaster { get; set; }
        public virtual DbSet<GstStoreStateCity> GstStoreStateCity { get; set; }
        public virtual DbSet<GstTaxCategoryMaster> GstTaxCategoryMaster { get; set; }
        public virtual DbSet<GstTaxCityMaster> GstTaxCityMaster { get; set; }
        public virtual DbSet<GstTaxCityMasterIst> GstTaxCityMasterIst { get; set; }
        public virtual DbSet<GstTaxNameMaster> GstTaxNameMaster { get; set; }
        public virtual DbSet<HalfToppingPricingCodes> HalfToppingPricingCodes { get; set; }
        public virtual DbSet<Holidays> Holidays { get; set; }
        public virtual DbSet<Hours> Hours { get; set; }
        public virtual DbSet<HrisShiftPasswordResetLog> HrisShiftPasswordResetLog { get; set; }
        public virtual DbSet<HustleRegistration> HustleRegistration { get; set; }
        public virtual DbSet<IfcRecalculateCall> IfcRecalculateCall { get; set; }
        public virtual DbSet<InstallVariables> InstallVariables { get; set; }
        public virtual DbSet<InventoryItemNutritionalValues> InventoryItemNutritionalValues { get; set; }
        public virtual DbSet<InventoryItemRecipeIngredients> InventoryItemRecipeIngredients { get; set; }
        public virtual DbSet<InventoryItemRecipeYieldItems> InventoryItemRecipeYieldItems { get; set; }
        public virtual DbSet<InventoryItemToppingCodes> InventoryItemToppingCodes { get; set; }
        public virtual DbSet<InventoryItemTypeCodes> InventoryItemTypeCodes { get; set; }
        public virtual DbSet<InventoryItems> InventoryItems { get; set; }
        public virtual DbSet<InventoryToppingPercentages> InventoryToppingPercentages { get; set; }
        public virtual DbSet<InventoryType> InventoryType { get; set; }
        public virtual DbSet<InventoryVariance> InventoryVariance { get; set; }
        public virtual DbSet<InvoiceNumber> InvoiceNumber { get; set; }
        public virtual DbSet<InvoiceNumberJune2018> InvoiceNumberJune2018 { get; set; }
        public virtual DbSet<IstCityStateDetl> IstCityStateDetl { get; set; }
        public virtual DbSet<IstEodCheckLog> IstEodCheckLog { get; set; }
        public virtual DbSet<IstInvoiceNumber> IstInvoiceNumber { get; set; }
        public virtual DbSet<IstReceiptTransaction> IstReceiptTransaction { get; set; }
        public virtual DbSet<IstStateGstin> IstStateGstin { get; set; }
        public virtual DbSet<IstStnDataDetl> IstStnDataDetl { get; set; }
        public virtual DbSet<IstStnDataHdr> IstStnDataHdr { get; set; }
        public virtual DbSet<IstTax> IstTax { get; set; }
        public virtual DbSet<IstTaxDetails> IstTaxDetails { get; set; }
        public virtual DbSet<IstTaxTmp> IstTaxTmp { get; set; }
        public virtual DbSet<IstTmpTax> IstTmpTax { get; set; }
        public virtual DbSet<IstTransactionDetl> IstTransactionDetl { get; set; }
        public virtual DbSet<IstTransactionHdr> IstTransactionHdr { get; set; }
        public virtual DbSet<ItemVisibilityTypes> ItemVisibilityTypes { get; set; }
        public virtual DbSet<JflOneCustomerDv> JflOneCustomerDv { get; set; }
        public virtual DbSet<KeyboardLayout> KeyboardLayout { get; set; }
        public virtual DbSet<KitchenDelayPrint> KitchenDelayPrint { get; set; }
        public virtual DbSet<LabelConfig> LabelConfig { get; set; }
        public virtual DbSet<LanguageCodes> LanguageCodes { get; set; }
        public virtual DbSet<LanguageTables> LanguageTables { get; set; }
        public virtual DbSet<LanpcExe> LanpcExe { get; set; }
        public virtual DbSet<LocationCodes> LocationCodes { get; set; }
        public virtual DbSet<LogError> LogError { get; set; }
        public virtual DbSet<LogPosSheet> LogPosSheet { get; set; }
        public virtual DbSet<MakeLineDisplay> MakeLineDisplay { get; set; }
        public virtual DbSet<MakeLineDisplayRemoteOrders> MakeLineDisplayRemoteOrders { get; set; }
        public virtual DbSet<MarketingCouponAnalysisTemp> MarketingCouponAnalysisTemp { get; set; }
        public virtual DbSet<MarketingCouponsTemp> MarketingCouponsTemp { get; set; }
        public virtual DbSet<MarketingCustomQueryFields> MarketingCustomQueryFields { get; set; }
        public virtual DbSet<MarketingFields> MarketingFields { get; set; }
        public virtual DbSet<MarketingLabelTypes> MarketingLabelTypes { get; set; }
        public virtual DbSet<MarketingOperators> MarketingOperators { get; set; }
        public virtual DbSet<MarketingOutputChoices> MarketingOutputChoices { get; set; }
        public virtual DbSet<MarketingQueryCodes> MarketingQueryCodes { get; set; }
        public virtual DbSet<MarketingQuerys> MarketingQuerys { get; set; }
        public virtual DbSet<MarketingSectorsTemp> MarketingSectorsTemp { get; set; }
        public virtual DbSet<MarketingVariableType> MarketingVariableType { get; set; }
        public virtual DbSet<MarketingVtOc> MarketingVtOc { get; set; }
        public virtual DbSet<MasterType> MasterType { get; set; }
        public virtual DbSet<MatchOrderLines> MatchOrderLines { get; set; }
        public virtual DbSet<MenuCategory> MenuCategory { get; set; }
        public virtual DbSet<MenuComboItemSizes> MenuComboItemSizes { get; set; }
        public virtual DbSet<MenuComboItems> MenuComboItems { get; set; }
        public virtual DbSet<MenuItemAttributeGroups> MenuItemAttributeGroups { get; set; }
        public virtual DbSet<MenuItemCategories> MenuItemCategories { get; set; }
        public virtual DbSet<MenuItemCoupons> MenuItemCoupons { get; set; }
        public virtual DbSet<MenuItemDisCoupons> MenuItemDisCoupons { get; set; }
        public virtual DbSet<MenuItemIfc> MenuItemIfc { get; set; }
        public virtual DbSet<MenuItemIfcToppings> MenuItemIfcToppings { get; set; }
        public virtual DbSet<MenuItemKitchenDevices> MenuItemKitchenDevices { get; set; }
        public virtual DbSet<MenuItemOptionGroups> MenuItemOptionGroups { get; set; }
        public virtual DbSet<MenuItemOptionsDetails> MenuItemOptionsDetails { get; set; }
        public virtual DbSet<MenuItemSizes> MenuItemSizes { get; set; }
        public virtual DbSet<MenuItemSizesTaxCategory> MenuItemSizesTaxCategory { get; set; }
        public virtual DbSet<MenuItemTypes> MenuItemTypes { get; set; }
        public virtual DbSet<MenuItemTypes1> MenuItemTypes1 { get; set; }
        public virtual DbSet<MenuItems> MenuItems { get; set; }
        public virtual DbSet<MenuOptionGroups> MenuOptionGroups { get; set; }
        public virtual DbSet<MenuOptionPriceByItem> MenuOptionPriceByItem { get; set; }
        public virtual DbSet<MenuOptionPriceByNumber> MenuOptionPriceByNumber { get; set; }
        public virtual DbSet<MenuOptionPriceDuplicateToppings> MenuOptionPriceDuplicateToppings { get; set; }
        public virtual DbSet<MenuOptionsGroupMenuOptions> MenuOptionsGroupMenuOptions { get; set; }
        public virtual DbSet<MenuTypes> MenuTypes { get; set; }
        public virtual DbSet<MenuTypesCategories> MenuTypesCategories { get; set; }
        public virtual DbSet<MileageControl> MileageControl { get; set; }
        public virtual DbSet<MileageTypeSalesRanges> MileageTypeSalesRanges { get; set; }
        public virtual DbSet<MisCallerId> MisCallerId { get; set; }
        public virtual DbSet<MobInEmployee> MobInEmployee { get; set; }
        public virtual DbSet<MobInEmployeeLog> MobInEmployeeLog { get; set; }
        public virtual DbSet<MobInHeartBeatStatus> MobInHeartBeatStatus { get; set; }
        public virtual DbSet<MobInHeartBeatStatusLog> MobInHeartBeatStatusLog { get; set; }
        public virtual DbSet<MobInOrderApiStatus> MobInOrderApiStatus { get; set; }
        public virtual DbSet<MobInOrderCancel> MobInOrderCancel { get; set; }
        public virtual DbSet<MobInOrderStatus> MobInOrderStatus { get; set; }
        public virtual DbSet<MobInOrders> MobInOrders { get; set; }
        public virtual DbSet<MobInOrdersLog> MobInOrdersLog { get; set; }
        public virtual DbSet<Months> Months { get; set; }
        public virtual DbSet<MuGroupDetail> MuGroupDetail { get; set; }
        public virtual DbSet<NextNumber> NextNumber { get; set; }
        public virtual DbSet<NoSaleTransactions> NoSaleTransactions { get; set; }
        public virtual DbSet<NoteCodes> NoteCodes { get; set; }
        public virtual DbSet<Notes> Notes { get; set; }
        public virtual DbSet<NutritionalItems> NutritionalItems { get; set; }
        public virtual DbSet<OddEvenTypes> OddEvenTypes { get; set; }
        public virtual DbSet<OfflineLog> OfflineLog { get; set; }
        public virtual DbSet<OfflineLogReason> OfflineLogReason { get; set; }
        public virtual DbSet<OloOrders> OloOrders { get; set; }
        public virtual DbSet<OloOrdersSyncLog> OloOrdersSyncLog { get; set; }
        public virtual DbSet<OloOts> OloOts { get; set; }
        public virtual DbSet<OloRefundOrder> OloRefundOrder { get; set; }
        public virtual DbSet<OloSyncServiceError> OloSyncServiceError { get; set; }
        public virtual DbSet<OlocancelorderLog> OlocancelorderLog { get; set; }
        public virtual DbSet<OnsCoupons> OnsCoupons { get; set; }
        public virtual DbSet<OnsInventoryItems> OnsInventoryItems { get; set; }
        public virtual DbSet<OnsMenuItemCategories> OnsMenuItemCategories { get; set; }
        public virtual DbSet<OnsMenuItemCoupons> OnsMenuItemCoupons { get; set; }
        public virtual DbSet<OnsMenuItemIfc> OnsMenuItemIfc { get; set; }
        public virtual DbSet<OnsMenuItemIfcToppings> OnsMenuItemIfcToppings { get; set; }
        public virtual DbSet<OnsMenuItemSizes> OnsMenuItemSizes { get; set; }
        public virtual DbSet<OnsMenuItemSizesTaxCategory> OnsMenuItemSizesTaxCategory { get; set; }
        public virtual DbSet<OnsMenuItems> OnsMenuItems { get; set; }
        public virtual DbSet<OnsMenuOptionPriceByItem> OnsMenuOptionPriceByItem { get; set; }
        public virtual DbSet<OnsVendor> OnsVendor { get; set; }
        public virtual DbSet<OrderCoupons> OrderCoupons { get; set; }
        public virtual DbSet<OrderCreditCards> OrderCreditCards { get; set; }
        public virtual DbSet<OrderCreditCardsHistory> OrderCreditCardsHistory { get; set; }
        public virtual DbSet<OrderDigitalPayment> OrderDigitalPayment { get; set; }
        public virtual DbSet<OrderDriverShiftLog> OrderDriverShiftLog { get; set; }
        public virtual DbSet<OrderGiftCards> OrderGiftCards { get; set; }
        public virtual DbSet<OrderGiftCardsHistory> OrderGiftCardsHistory { get; set; }
        public virtual DbSet<OrderLineAttributes> OrderLineAttributes { get; set; }
        public virtual DbSet<OrderLineCoupons> OrderLineCoupons { get; set; }
        public virtual DbSet<OrderLineGiftCards> OrderLineGiftCards { get; set; }
        public virtual DbSet<OrderLineIfc> OrderLineIfc { get; set; }
        public virtual DbSet<OrderLineOptions> OrderLineOptions { get; set; }
        public virtual DbSet<OrderLineReasons> OrderLineReasons { get; set; }
        public virtual DbSet<OrderLineSpecialtyPizzas> OrderLineSpecialtyPizzas { get; set; }
        public virtual DbSet<OrderLineUserDefinedTax> OrderLineUserDefinedTax { get; set; }
        public virtual DbSet<OrderLines> OrderLines { get; set; }
        public virtual DbSet<OrderPayTypeCodes> OrderPayTypeCodes { get; set; }
        public virtual DbSet<OrderPayTypeHdr> OrderPayTypeHdr { get; set; }
        public virtual DbSet<OrderPaymentSavedMode> OrderPaymentSavedMode { get; set; }
        public virtual DbSet<OrderPayments> OrderPayments { get; set; }
        public virtual DbSet<OrderReasons> OrderReasons { get; set; }
        public virtual DbSet<OrderTransaction> OrderTransaction { get; set; }
        public virtual DbSet<OrderTransactionRefund> OrderTransactionRefund { get; set; }
        public virtual DbSet<OrderTypeCodes> OrderTypeCodes { get; set; }
        public virtual DbSet<OrderTypeOptions> OrderTypeOptions { get; set; }
        public virtual DbSet<OrderUserDefinedTax> OrderUserDefinedTax { get; set; }
        public virtual DbSet<OrderWallet> OrderWallet { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OvenDescription> OvenDescription { get; set; }
        public virtual DbSet<OvertimeConditions> OvertimeConditions { get; set; }
        public virtual DbSet<ParityTypes> ParityTypes { get; set; }
        public virtual DbSet<PayType> PayType { get; set; }
        public virtual DbSet<PayrollControl> PayrollControl { get; set; }
        public virtual DbSet<PayrollType> PayrollType { get; set; }
        public virtual DbSet<PcDeviceOrderTypes> PcDeviceOrderTypes { get; set; }
        public virtual DbSet<PcDeviceQueue> PcDeviceQueue { get; set; }
        public virtual DbSet<PcDeviceQueueDaily> PcDeviceQueueDaily { get; set; }
        public virtual DbSet<PcDeviceTypes> PcDeviceTypes { get; set; }
        public virtual DbSet<PcDevices> PcDevices { get; set; }
        public virtual DbSet<Period> Period { get; set; }
        public virtual DbSet<PizzaPart> PizzaPart { get; set; }
        public virtual DbSet<PortTypes> PortTypes { get; set; }
        public virtual DbSet<PosMasterReport> PosMasterReport { get; set; }
        public virtual DbSet<PosMessage> PosMessage { get; set; }
        public virtual DbSet<Posdatabackupperiod> Posdatabackupperiod { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<PostalCodes> PostalCodes { get; set; }
        public virtual DbSet<PostingDestinations> PostingDestinations { get; set; }
        public virtual DbSet<PostingTypes> PostingTypes { get; set; }
        public virtual DbSet<PosupdateLogs> PosupdateLogs { get; set; }
        public virtual DbSet<PreparedItemsAdjustment> PreparedItemsAdjustment { get; set; }
        public virtual DbSet<PrgVer> PrgVer { get; set; }
        public virtual DbSet<PrintEventTypes> PrintEventTypes { get; set; }
        public virtual DbSet<PriorityCustomerCategory> PriorityCustomerCategory { get; set; }
        public virtual DbSet<PriorityCustomers> PriorityCustomers { get; set; }
        public virtual DbSet<PriorityCustomersNotification> PriorityCustomersNotification { get; set; }
        public virtual DbSet<ProcessorTrackingLog> ProcessorTrackingLog { get; set; }
        public virtual DbSet<ProductOsgs> ProductOsgs { get; set; }
        public virtual DbSet<ProductPricingTablePrices> ProductPricingTablePrices { get; set; }
        public virtual DbSet<Products2> Products2 { get; set; }
        public virtual DbSet<ProductsText> ProductsText { get; set; }
        public virtual DbSet<ProfileControlTypes> ProfileControlTypes { get; set; }
        public virtual DbSet<PulseApiErrorLog> PulseApiErrorLog { get; set; }
        public virtual DbSet<PulseApiorderData> PulseApiorderData { get; set; }
        public virtual DbSet<PulseApiorderDataDtl> PulseApiorderDataDtl { get; set; }
        public virtual DbSet<PulseMappingSequence> PulseMappingSequence { get; set; }
        public virtual DbSet<PulseTableMapping> PulseTableMapping { get; set; }
        public virtual DbSet<ReasonDescriptions> ReasonDescriptions { get; set; }
        public virtual DbSet<ReasonDetails> ReasonDetails { get; set; }
        public virtual DbSet<ReasonGroups> ReasonGroups { get; set; }
        public virtual DbSet<Reasons> Reasons { get; set; }
        public virtual DbSet<RegAppRunning> RegAppRunning { get; set; }
        public virtual DbSet<RegModuleList> RegModuleList { get; set; }
        public virtual DbSet<Regions> Regions { get; set; }
        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<Remarks> Remarks { get; set; }
        public virtual DbSet<RemoteOrderAvailabilityTypes> RemoteOrderAvailabilityTypes { get; set; }
        public virtual DbSet<ReportCategories> ReportCategories { get; set; }
        public virtual DbSet<ReportDateRanges> ReportDateRanges { get; set; }
        public virtual DbSet<ReportDateSecurityItems> ReportDateSecurityItems { get; set; }
        public virtual DbSet<ReportFields> ReportFields { get; set; }
        public virtual DbSet<ReportGroupDetail> ReportGroupDetail { get; set; }
        public virtual DbSet<Reports> Reports { get; set; }
        public virtual DbSet<RmpgetStreet> RmpgetStreet { get; set; }
        public virtual DbSet<RoaLog> RoaLog { get; set; }
        public virtual DbSet<RouteStationSettings> RouteStationSettings { get; set; }
        public virtual DbSet<SaleReport> SaleReport { get; set; }
        public virtual DbSet<SalesPeriodHours> SalesPeriodHours { get; set; }
        public virtual DbSet<SalesPeriods> SalesPeriods { get; set; }
        public virtual DbSet<ScaleWeightUnits> ScaleWeightUnits { get; set; }
        public virtual DbSet<SdpPaymentModeDetails> SdpPaymentModeDetails { get; set; }
        public virtual DbSet<SdpVoucherDetails> SdpVoucherDetails { get; set; }
        public virtual DbSet<Sectors> Sectors { get; set; }
        public virtual DbSet<SecurityClass> SecurityClass { get; set; }
        public virtual DbSet<SecurityClassAccess> SecurityClassAccess { get; set; }
        public virtual DbSet<SecurityClassAssignableClasses> SecurityClassAssignableClasses { get; set; }
        public virtual DbSet<SerialPorts> SerialPorts { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<SortOrder> SortOrder { get; set; }
        public virtual DbSet<SpecialtyPizzaCodes> SpecialtyPizzaCodes { get; set; }
        public virtual DbSet<SrsReconcileDetl> SrsReconcileDetl { get; set; }
        public virtual DbSet<SrsReconcileHdr> SrsReconcileHdr { get; set; }
        public virtual DbSet<SrsReconcileOrderDetails> SrsReconcileOrderDetails { get; set; }
        public virtual DbSet<StartUpScreenTypes> StartUpScreenTypes { get; set; }
        public virtual DbSet<StationControl> StationControl { get; set; }
        public virtual DbSet<StationUpdateList> StationUpdateList { get; set; }
        public virtual DbSet<StationUpdateListUpdateFiles> StationUpdateListUpdateFiles { get; set; }
        public virtual DbSet<StatusCodes> StatusCodes { get; set; }
        public virtual DbSet<StnDataLog> StnDataLog { get; set; }
        public virtual DbSet<StnErrorLog> StnErrorLog { get; set; }
        public virtual DbSet<StoreHours> StoreHours { get; set; }
        public virtual DbSet<Streets> Streets { get; set; }
        public virtual DbSet<SubStreets> SubStreets { get; set; }
        public virtual DbSet<SystemAccountsSql> SystemAccountsSql { get; set; }
        public virtual DbSet<SystemPasswords> SystemPasswords { get; set; }
        public virtual DbSet<TaxCalculationCodes> TaxCalculationCodes { get; set; }
        public virtual DbSet<TaxCategories> TaxCategories { get; set; }
        public virtual DbSet<TaxName> TaxName { get; set; }
        public virtual DbSet<TaxType> TaxType { get; set; }
        public virtual DbSet<TempComputer> TempComputer { get; set; }
        public virtual DbSet<TempDbobjects> TempDbobjects { get; set; }
        public virtual DbSet<TempFooter> TempFooter { get; set; }
        public virtual DbSet<TempIstStnData> TempIstStnData { get; set; }
        public virtual DbSet<TempOrderLineUdt> TempOrderLineUdt { get; set; }
        public virtual DbSet<TempOrderLines> TempOrderLines { get; set; }
        public virtual DbSet<TempOrderPayments> TempOrderPayments { get; set; }
        public virtual DbSet<TempRecap> TempRecap { get; set; }
        public virtual DbSet<TempZero> TempZero { get; set; }
        public virtual DbSet<Text1> Text1 { get; set; }
        public virtual DbSet<TextTables> TextTables { get; set; }
        public virtual DbSet<TimeClock> TimeClock { get; set; }
        public virtual DbSet<TimeClockBiometric> TimeClockBiometric { get; set; }
        public virtual DbSet<TimeClockLog> TimeClockLog { get; set; }
        public virtual DbSet<Tmp> Tmp { get; set; }
        public virtual DbSet<TmpMakeLineDisplay> TmpMakeLineDisplay { get; set; }
        public virtual DbSet<ToppingAmountCodes> ToppingAmountCodes { get; set; }
        public virtual DbSet<ToppingPercentages> ToppingPercentages { get; set; }
        public virtual DbSet<TransactionPaymentTypes> TransactionPaymentTypes { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }
        public virtual DbSet<UdtorderPayments1> UdtorderPayments1 { get; set; }
        public virtual DbSet<UpdateBehaviorCodes> UpdateBehaviorCodes { get; set; }
        public virtual DbSet<UpsellHistory> UpsellHistory { get; set; }
        public virtual DbSet<UpsellMaster> UpsellMaster { get; set; }
        public virtual DbSet<UpsellMasterLog> UpsellMasterLog { get; set; }
        public virtual DbSet<UserDefinedTaxRates> UserDefinedTaxRates { get; set; }
        public virtual DbSet<UserDefinedTaxRatesDetails> UserDefinedTaxRatesDetails { get; set; }
        public virtual DbSet<UsrIndentPushLog> UsrIndentPushLog { get; set; }
        public virtual DbSet<UsrPushPullStat> UsrPushPullStat { get; set; }
        public virtual DbSet<UsrTaxInfo> UsrTaxInfo { get; set; }
        public virtual DbSet<UtilityVersion> UtilityVersion { get; set; }
        public virtual DbSet<VbMenuItems> VbMenuItems { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<VendorOrders> VendorOrders { get; set; }
        public virtual DbSet<VendorOrdersDetails> VendorOrdersDetails { get; set; }
        public virtual DbSet<VersionControl> VersionControl { get; set; }
        public virtual DbSet<VersionControlAppFile> VersionControlAppFile { get; set; }
        public virtual DbSet<VersionControlExceptionalFile> VersionControlExceptionalFile { get; set; }
        public virtual DbSet<VersionControlHistory> VersionControlHistory { get; set; }
        public virtual DbSet<VersionControlWatcherDirectoryPath> VersionControlWatcherDirectoryPath { get; set; }
        public virtual DbSet<VersionDiscrepancyLog> VersionDiscrepancyLog { get; set; }
        public virtual DbSet<VersionInfo> VersionInfo { get; set; }
        public virtual DbSet<VersionSetupDbobjects> VersionSetupDbobjects { get; set; }
        public virtual DbSet<ViewAddressSample> ViewAddressSample { get; set; }
        public virtual DbSet<ViewGetSrsReconciliationDetails> ViewGetSrsReconciliationDetails { get; set; }
        public virtual DbSet<ViewIfctoppingCount> ViewIfctoppingCount { get; set; }
        public virtual DbSet<ViewIfctoppings> ViewIfctoppings { get; set; }
        public virtual DbSet<ViewInventoryVendors> ViewInventoryVendors { get; set; }
        public virtual DbSet<ViewOloadvanceSales> ViewOloadvanceSales { get; set; }
        public virtual DbSet<ViewRoutedriverReturnTimes> ViewRoutedriverReturnTimes { get; set; }
        public virtual DbSet<ViewRouteorderLabels> ViewRouteorderLabels { get; set; }
        public virtual DbSet<ViewSecurityClassAccess> ViewSecurityClassAccess { get; set; }
        public virtual DbSet<ViewSecurityClassOverride> ViewSecurityClassOverride { get; set; }
        public virtual DbSet<ViewTimeClock> ViewTimeClock { get; set; }
        public virtual DbSet<ViewTimeClockLog> ViewTimeClockLog { get; set; }
        public virtual DbSet<ViewTimeClockPerDay> ViewTimeClockPerDay { get; set; }
        public virtual DbSet<ViewTimeClockPerShift> ViewTimeClockPerShift { get; set; }
        public virtual DbSet<ViewUsrMissedCall> ViewUsrMissedCall { get; set; }
        public virtual DbSet<VlmOrderStatus> VlmOrderStatus { get; set; }
        public virtual DbSet<VlmPartner> VlmPartner { get; set; }
        public virtual DbSet<VlmPartnerOrders> VlmPartnerOrders { get; set; }
        public virtual DbSet<VlmPartnerUnAssignReason> VlmPartnerUnAssignReason { get; set; }
        public virtual DbSet<VsMetrix> VsMetrix { get; set; }
        public virtual DbSet<VsMetrixScenarios> VsMetrixScenarios { get; set; }
        public virtual DbSet<VsMetrixTemplate> VsMetrixTemplate { get; set; }
        public virtual DbSet<VsMetrixWindowControls> VsMetrixWindowControls { get; set; }
        public virtual DbSet<VsMetrixWindows> VsMetrixWindows { get; set; }
        public virtual DbSet<VsThresholdAlerts> VsThresholdAlerts { get; set; }
        public virtual DbSet<VsThresholdConditions> VsThresholdConditions { get; set; }
        public virtual DbSet<VsThresholdConjunctions> VsThresholdConjunctions { get; set; }
        public virtual DbSet<VsThresholdOperators> VsThresholdOperators { get; set; }
        public virtual DbSet<VsThresholds> VsThresholds { get; set; }
        public virtual DbSet<WastageDetail> WastageDetail { get; set; }
        public virtual DbSet<WastageMaster> WastageMaster { get; set; }
        public virtual DbSet<WorkStationInformation> WorkStationInformation { get; set; }
        public virtual DbSet<WorkStationRights> WorkStationRights { get; set; }
        public virtual DbSet<WorkstationDevices> WorkstationDevices { get; set; }
        public virtual DbSet<WorkstationKdOrderSort> WorkstationKdOrderSort { get; set; }
        public virtual DbSet<WorkstationMenuTypes> WorkstationMenuTypes { get; set; }
        public virtual DbSet<WorkstationOrderTypeDisplay> WorkstationOrderTypeDisplay { get; set; }
        public virtual DbSet<WorkstationOrderTypes> WorkstationOrderTypes { get; set; }
        public virtual DbSet<WorkstationPort> WorkstationPort { get; set; }
        public virtual DbSet<WorkstationRemoteSettings> WorkstationRemoteSettings { get; set; }
        public virtual DbSet<WorkstationTypes> WorkstationTypes { get; set; }
        public virtual DbSet<Workstations> Workstations { get; set; }
        public virtual DbSet<YesNoTypes> YesNoTypes { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=172.40.24.45;Database=StoreDB;UID=import;PWD=import;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountSubHead>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.AccountId, e.SubAccountCode })
                    .HasName("PK_Account_Sub_Head_1");

                entity.ToTable("Account_Sub_Head");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AccountId).HasColumnName("Account_ID");

                entity.Property(e => e.SubAccountCode)
                    .HasColumnName("Sub_Account_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AccountCode)
                    .IsRequired()
                    .HasColumnName("Account_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SubAccountCodeDescription)
                    .HasColumnName("Sub_Account_Code_Description")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccountTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.AccountTypeCode });

                entity.ToTable("Account_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AccountTypeCode).HasColumnName("Account_Type_Code");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .IsRequired()
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.AccountTypes)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Account_Types_Location_Codes");
            });

            modelBuilder.Entity<Accounts>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.AccountId })
                    .IsClustered(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AccountId).HasColumnName("Account_ID");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("Account_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AccountDescription)
                    .HasColumnName("Account_Description")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AccountTypeCode).HasColumnName("Account_Type_Code");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDestination)
                    .HasColumnName("Posting_Destination")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PostingType)
                    .HasColumnName("Posting_Type")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SystemAccount).HasColumnName("System_Account");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Accounts_Location_Codes");
            });

            modelBuilder.Entity<AccountsExpLimit>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.AccountId });

                entity.ToTable("Accounts_Exp_Limit");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AccountId).HasColumnName("Account_ID");

                entity.Property(e => e.AccountCode)
                    .IsRequired()
                    .HasColumnName("Account_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DailyLimit).HasColumnName("Daily_Limit");

                entity.Property(e => e.MonthlyLimit).HasColumnName("Monthly_Limit");

                entity.Property(e => e.WeeklyLimit).HasColumnName("Weekly_Limit");

                entity.Property(e => e.YearlyLimit).HasColumnName("Yearly_Limit");
            });

            modelBuilder.Entity<AddressDefinitionType>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.AddressDefinitionCode });

                entity.ToTable("Address_Definition_Type");

                entity.HasIndex(e => e.AddressDefinitionCode)
                    .HasName("Address_Definition_Code");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AddressDefinitionCode).HasColumnName("Address_Definition_Code");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.AddressDefinitionType)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_Definition_Type_Location_Codes");
            });

            modelBuilder.Entity<AddressDefinitions>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.AddressDefinitionCode, e.Sequence })
                    .IsClustered(false);

                entity.ToTable("Address_Definitions");

                entity.HasIndex(e => e.AddressDefinitionCode)
                    .HasName("Address_Definition_TypeAddress_Definitions");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AddressDefinitionCode).HasColumnName("Address_Definition_Code");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AddressField)
                    .HasColumnName("Address_Field")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Length).HasDefaultValueSql("((0))");

                entity.Property(e => e.Modifier1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modifier2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.AddressDefinitions)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_Definitions_Location_Codes");
            });

            modelBuilder.Entity<AddressLookup>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.Type, e.Code })
                    .IsClustered(false);

                entity.ToTable("Address_Lookup");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.AddressLookup)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_Lookup_Location_Codes");
            });

            modelBuilder.Entity<AddressTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.AddressType });

                entity.ToTable("Address_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AddressType)
                    .HasColumnName("Address_Type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("Display_Order")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EnglishTextDescription)
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.AddressTypes)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_Types_Location_Codes");
            });

            modelBuilder.Entity<AdminLevelCodes>(entity =>
            {
                entity.HasKey(e => e.AdminLevel)
                    .IsClustered(false);

                entity.ToTable("Admin_Level_Codes");

                entity.Property(e => e.AdminLevel)
                    .HasColumnName("Admin_Level")
                    .ValueGeneratedNever();

                entity.Property(e => e.LevelDesc)
                    .IsRequired()
                    .HasColumnName("Level_Desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AodLog>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderDate, e.OrderNumber, e.CouponCode, e.Sequence })
                    .HasName("AOD_Log_PK");

                entity.ToTable("AOD_Log");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.CouponCode)
                    .HasColumnName("Coupon_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CouponAmount)
                    .HasColumnName("Coupon_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.DynamicCouponCode)
                    .HasColumnName("Dynamic_Coupon_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.AodLog)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AOD_Log_Location_Codes");

                entity.HasOne(d => d.Orders)
                    .WithMany(p => p.AodLog)
                    .HasForeignKey(d => new { d.LocationCode, d.OrderDate, d.OrderNumber })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AOD_Log_Orders");
            });

            modelBuilder.Entity<AodTimeMapping>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.StartTime, e.EndTime, e.Day, e.DineIn, e.Delivery, e.Odc, e.CarryOut, e.LateDiscount, e.Tsg });

                entity.ToTable("AOD_TimeMapping");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Day)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Odc).HasColumnName("ODC");

                entity.Property(e => e.LateDiscount).HasColumnName("Late_Discount");

                entity.Property(e => e.Tsg).HasColumnName("TSG");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppControl>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.Version })
                    .IsClustered(false);

                entity.ToTable("App_Control");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AutoRouteCarryOut)
                    .HasColumnName("AutoRoute_Carry_Out")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AutoRouteDineIn)
                    .HasColumnName("AutoRoute_Dine_In")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AutoRoutePickUp)
                    .HasColumnName("AutoRoute_Pick_Up")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Beta)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CallerId).HasColumnName("Caller_ID");

                entity.Property(e => e.CarryOutLeadTime).HasColumnName("CarryOut_Lead_Time");

                entity.Property(e => e.CashTipPct)
                    .HasColumnName("Cash_Tip_Pct")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CityTax)
                    .HasColumnName("City_Tax")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DaysToKeepCallerLog)
                    .HasColumnName("Days_To_Keep_Caller_Log")
                    .HasDefaultValueSql("((7))");

                entity.Property(e => e.DaysToKeepCustomers)
                    .HasColumnName("Days_To_Keep_Customers")
                    .HasDefaultValueSql("((180))");

                entity.Property(e => e.DaysToKeepOrderHistory)
                    .HasColumnName("Days_To_Keep_Order_History")
                    .HasDefaultValueSql("((180))");

                entity.Property(e => e.DaysToKeepOrderLinesHistory)
                    .HasColumnName("Days_To_Keep_Order_Lines_History")
                    .HasDefaultValueSql("((180))");

                entity.Property(e => e.DaysToKeepReprintBillLog).HasColumnName("Days_To_Keep_ReprintBill_Log");

                entity.Property(e => e.DebugMode)
                    .HasColumnName("Debug_Mode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DefaultCarTopUse).HasColumnName("Default_Car_Top_Use");

                entity.Property(e => e.DefaultCarType).HasColumnName("Default_Car_Type");

                entity.Property(e => e.DefaultCarryOutCityCode)
                    .HasColumnName("Default_Carry_Out_City_Code")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DefaultCarryOutPostalCode)
                    .HasColumnName("Default_Carry_Out_Postal_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultCityCode)
                    .HasColumnName("Default_City_Code")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DefaultCurrency)
                    .HasColumnName("Default_Currency")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultDriverTill)
                    .HasColumnName("Default_Driver_Till")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((20))");

                entity.Property(e => e.DefaultInsideTill)
                    .HasColumnName("Default_Inside_Till")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((50))");

                entity.Property(e => e.DefaultLocationCode)
                    .HasColumnName("Default_Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultMvrCheckInterval)
                    .HasColumnName("Default_MVR_Check_Interval")
                    .HasDefaultValueSql("((6))");

                entity.Property(e => e.DefaultMvrIntervalCode)
                    .HasColumnName("Default_MVR_Interval_Code")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.DefaultPhonePrefix)
                    .HasColumnName("Default_Phone_Prefix")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultPostalCode)
                    .HasColumnName("Default_Postal_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryChargesInFoodCost).HasColumnName("Delivery_Charges_In_Food_Cost");

                entity.Property(e => e.DeliveryFee)
                    .HasColumnName("Delivery_Fee")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeliveryLeadTime).HasColumnName("Delivery_Lead_Time");

                entity.Property(e => e.DoublesPricingCalcMethod)
                    .HasColumnName("Doubles_Pricing_Calc_Method")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DoublesPricingOn)
                    .HasColumnName("Doubles_Pricing_On")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DoublesPricingPricingType)
                    .HasColumnName("Doubles_Pricing_Pricing_Type")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DoublesPricingType)
                    .HasColumnName("Doubles_Pricing_Type")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DriverMap).HasColumnName("Driver_Map");

                entity.Property(e => e.DriverOutPassword).HasColumnName("Driver_Out_Password");

                entity.Property(e => e.FeesInRoyalty)
                    .HasColumnName("Fees_In_Royalty")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FeesTaxable)
                    .HasColumnName("Fees_Taxable")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FoodLaborCouponMileage).HasColumnName("Food_Labor_Coupon_Mileage");

                entity.Property(e => e.GoalActualVsIfc).HasColumnName("Goal_Actual_VS_IFC");

                entity.Property(e => e.GoalCoupons).HasColumnName("Goal_Coupons");

                entity.Property(e => e.GoalDeliveryTime).HasColumnName("Goal_Delivery_Time");

                entity.Property(e => e.GoalFood).HasColumnName("Goal_Food");

                entity.Property(e => e.GoalLabor).HasColumnName("Goal_Labor");

                entity.Property(e => e.GoalLoadTime).HasColumnName("Goal_Load_Time");

                entity.Property(e => e.GoalMileage).HasColumnName("Goal_Mileage");

                entity.Property(e => e.GoalOrderTime).HasColumnName("Goal_Order_Time");

                entity.Property(e => e.GoalRouteTime).HasColumnName("Goal_Route_Time");

                entity.Property(e => e.GovernmentReceipt).HasColumnName("Government_Receipt");

                entity.Property(e => e.HourlyDeliveryItems)
                    .HasColumnName("Hourly_Delivery_Items")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.HourlyMakeLineItems)
                    .HasColumnName("Hourly_MakeLine_Items")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IconDirectory)
                    .HasColumnName("Icon_Directory")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ItemsPerLabel)
                    .HasColumnName("Items_Per_Label")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("Last_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.LicensedCompany)
                    .HasColumnName("Licensed_Company")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogOutAfterEachOrder)
                    .HasColumnName("Log_Out_After_Each_Order")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MarketingMap).HasColumnName("Marketing_Map");

                entity.Property(e => e.MaxAmountPricePerOrder)
                    .HasColumnName("Max_Amount_Price_Per_Order")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((99999999999999.99))");

                entity.Property(e => e.MinAmountPricePerOrder)
                    .HasColumnName("Min_Amount_Price_Per_Order")
                    .HasColumnType("money");

                entity.Property(e => e.ModifyOptions)
                    .HasColumnName("Modify_Options")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MultiLocations)
                    .HasColumnName("Multi_Locations")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MultiTaxType).HasDefaultValueSql("((1))");

                entity.Property(e => e.NewOrderNumbersEachDay)
                    .HasColumnName("New_Order_Numbers_Each_Day")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PercentagesOfTotalNetRoyalty).HasColumnName("Percentages_of_Total_Net_Royalty");

                entity.Property(e => e.PhoneMask)
                    .HasColumnName("Phone_Mask")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCodeMask)
                    .HasColumnName("Postal_Code_Mask")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PricingMethod)
                    .HasColumnName("Pricing_Method")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuantityForSingleSlip).HasColumnName("Quantity_for_Single_Slip");

                entity.Property(e => e.ReceiptMessageBottom)
                    .HasColumnName("Receipt_Message_Bottom")
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptMessageTop)
                    .HasColumnName("Receipt_Message_Top")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .HasColumnName("Serial_Number")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ShowCodesOnTicket)
                    .HasColumnName("Show_Codes_On_Ticket")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowCoupons)
                    .HasColumnName("Show_Coupons")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShowQuantity)
                    .HasColumnName("Show_Quantity")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDayOfWeek)
                    .HasColumnName("Start_Day_Of_Week")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StoreMonitor)
                    .HasColumnName("Store_Monitor")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxLimit)
                    .HasColumnName("Tax_Limit")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxStructure)
                    .HasColumnName("Tax_Structure")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TechSupport)
                    .HasColumnName("Tech_Support")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ToppingSubstitutions)
                    .HasColumnName("Topping_Substitutions")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.DefaultLocationCodeNavigation)
                    .WithMany(p => p.AppControlDefaultLocationCodeNavigation)
                    .HasForeignKey(d => d.DefaultLocationCode)
                    .HasConstraintName("FK_App_Control_Location_Codes1");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.AppControlLocationCodeNavigation)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_App_Control_Location_Codes2");

                entity.HasOne(d => d.CurrencyType)
                    .WithMany(p => p.AppControl)
                    .HasForeignKey(d => new { d.LocationCode, d.DefaultCurrency })
                    .HasConstraintName("FK_App_Control_Currency_Type");
            });

            modelBuilder.Entity<ApplicationUpdateHistory>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.WorkstationId, e.VersionNumber, e.HotFixNumber });

                entity.ToTable("Application_Update_History");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.WorkstationId).HasColumnName("Workstation_ID");

                entity.Property(e => e.VersionNumber)
                    .HasColumnName("Version_Number")
                    .HasMaxLength(10);

                entity.Property(e => e.HotFixNumber)
                    .HasColumnName("Hot_Fix_Number")
                    .HasMaxLength(10);

                entity.Property(e => e.FilesAffected)
                    .IsRequired()
                    .HasColumnName("Files_Affected")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateDescription)
                    .IsRequired()
                    .HasColumnName("Update_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("Update_Time")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.ApplicationUpdateHistory)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Application_Update_History_Location_Codes");
            });

            modelBuilder.Entity<ArAgingMethodTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MethodTypeCode });

                entity.ToTable("AR_Aging_Method_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MethodTypeCode).HasColumnName("Method_Type_Code");

                entity.Property(e => e.MethodDescription)
                    .IsRequired()
                    .HasColumnName("Method_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MethodValue)
                    .IsRequired()
                    .HasColumnName("Method_Value")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.ArAgingMethodTypes)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_Aging_Method_Location_Codes");
            });

            modelBuilder.Entity<ArAgingMethodTypesDescriptions>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.MethodTypeCode });

                entity.ToTable("AR_Aging_Method_Types_Descriptions");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.MethodTypeCode).HasColumnName("Method_Type_Code");

                entity.Property(e => e.DefaultDescription)
                    .IsRequired()
                    .HasColumnName("Default_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDescription)
                    .IsRequired()
                    .HasColumnName("Modified_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.ArAgingMethodTypesDescriptions)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_Aging_Method_Types_Descriptions_Location_Codes");

                entity.HasOne(d => d.ArAgingMethodTypes)
                    .WithMany(p => p.ArAgingMethodTypesDescriptions)
                    .HasForeignKey(d => new { d.LocationCode, d.MethodTypeCode })
                    .HasConstraintName("FK_AR_Aging_Method_Types_Descriptions");
            });

            modelBuilder.Entity<ArSettings>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.SettingName });

                entity.ToTable("AR_Settings");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SettingName)
                    .HasColumnName("Setting_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SettingValue)
                    .HasColumnName("Setting_Value")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArTermTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.TermTypeCode });

                entity.ToTable("AR_Term_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TermTypeCode).HasColumnName("Term_Type_Code");

                entity.Property(e => e.TermDescription)
                    .IsRequired()
                    .HasColumnName("Term_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TermValue).HasColumnName("Term_Value");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.ArTermTypes)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_Term_Types_Location_Codes");
            });

            modelBuilder.Entity<ArTermTypesDescriptions>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.TermTypeCode });

                entity.ToTable("AR_Term_Types_Descriptions");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.TermTypeCode).HasColumnName("Term_Type_Code");

                entity.Property(e => e.DefaultDescription)
                    .IsRequired()
                    .HasColumnName("Default_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDescription)
                    .IsRequired()
                    .HasColumnName("Modified_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.ArTermTypesDescriptions)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_Term_Types_Descriptions_Location_Codes");

                entity.HasOne(d => d.ArTermTypes)
                    .WithMany(p => p.ArTermTypesDescriptions)
                    .HasForeignKey(d => new { d.LocationCode, d.TermTypeCode })
                    .HasConstraintName("FK_AR_Term_Types_Descriptions");
            });

            modelBuilder.Entity<ArTransactionStatusTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.TransactionStatusTypeCode });

                entity.ToTable("AR_Transaction_Status_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionStatusTypeCode).HasColumnName("Transaction_Status_Type_Code");

                entity.Property(e => e.TransactionStatusDescription)
                    .IsRequired()
                    .HasColumnName("Transaction_Status_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.ArTransactionStatusTypes)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_Transaction_Status_Types_Location_Codes");
            });

            modelBuilder.Entity<ArTransactionStatusTypesDescriptions>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.TransactionStatusTypeCode });

                entity.ToTable("AR_Transaction_Status_Types_Descriptions");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.TransactionStatusTypeCode).HasColumnName("Transaction_Status_Type_Code");

                entity.Property(e => e.DefaultDescription)
                    .IsRequired()
                    .HasColumnName("Default_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDescription)
                    .IsRequired()
                    .HasColumnName("Modified_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.ArTransactionStatusTypesDescriptions)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_Transaction_Status_Types_Descriptions_Location_Codes");

                entity.HasOne(d => d.ArTransactionStatusTypes)
                    .WithMany(p => p.ArTransactionStatusTypesDescriptions)
                    .HasForeignKey(d => new { d.LocationCode, d.TransactionStatusTypeCode })
                    .HasConstraintName("FK_AR_Transaction_Status_Types_Descriptions");
            });

            modelBuilder.Entity<ArTransactionTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.TransactionTypeCode });

                entity.ToTable("AR_Transaction_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionTypeCode).HasColumnName("Transaction_Type_Code");

                entity.Property(e => e.TransactionDescription)
                    .IsRequired()
                    .HasColumnName("Transaction_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.ArTransactionTypes)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_Transaction_Types_Location_Codes");
            });

            modelBuilder.Entity<ArTransactionTypesDescriptions>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.TransactionTypeCode });

                entity.ToTable("AR_Transaction_Types_Descriptions");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.TransactionTypeCode).HasColumnName("Transaction_Type_Code");

                entity.Property(e => e.DefaultDescription)
                    .IsRequired()
                    .HasColumnName("Default_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDescription)
                    .IsRequired()
                    .HasColumnName("Modified_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.ArTransactionTypesDescriptions)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_Transaction_Types_Descriptions_Location_Codes");

                entity.HasOne(d => d.ArTransactionTypes)
                    .WithMany(p => p.ArTransactionTypesDescriptions)
                    .HasForeignKey(d => new { d.LocationCode, d.TransactionTypeCode })
                    .HasConstraintName("FK_AR_Transaction_Types_Descriptions");
            });

            modelBuilder.Entity<ArTransactions>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.TransactionId });

                entity.ToTable("AR_Transactions");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId).HasColumnName("Transaction_ID");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CheckCreditNumber)
                    .HasColumnName("Check_Credit_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasColumnName("Company_Code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreditAmount)
                    .HasColumnName("Credit_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.CreditPaymentType).HasColumnName("Credit_Payment_Type");

                entity.Property(e => e.CreditTransactionId).HasColumnName("Credit_Transaction_Id");

                entity.Property(e => e.CurrencyAmount)
                    .HasColumnName("Currency_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("Currency_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode).HasColumnName("Customer_Code");

                entity.Property(e => e.DebitAmount)
                    .HasColumnName("Debit_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EventName)
                    .HasColumnName("Event_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EventVenue)
                    .HasColumnName("Event_Venue")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsAdvance).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.PaymentDate)
                    .HasColumnName("Payment_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaymentLineNumber).HasColumnName("Payment_Line_Number");

                entity.Property(e => e.TransactionDate)
                    .HasColumnName("Transaction_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TransactionNumber)
                    .HasColumnName("Transaction_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.TransactionStatus)
                    .HasColumnName("Transaction_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TransactionType).HasColumnName("Transaction_Type");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.ArTransactions)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_Transactions_Location_Codes");

                entity.HasOne(d => d.ArTransactionTypes)
                    .WithMany(p => p.ArTransactions)
                    .HasForeignKey(d => new { d.LocationCode, d.TransactionType })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_Transactions_AR_Transaction_Types");
            });

            modelBuilder.Entity<ArTransactionsDetail>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.TransactionDetailId });

                entity.ToTable("AR_Transactions_Detail");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDetailId).HasColumnName("Transaction_Detail_ID");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AmountApplied)
                    .HasColumnName("Amount_Applied")
                    .HasColumnType("money");

                entity.Property(e => e.ReferenceId).HasColumnName("Reference_ID");

                entity.Property(e => e.TransactionId).HasColumnName("Transaction_ID");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.ArTransactionsDetail)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_Transactions_Detail_Location_Codes");

                entity.HasOne(d => d.ArTransactions)
                    .WithMany(p => p.ArTransactionsDetailArTransactions)
                    .HasForeignKey(d => new { d.LocationCode, d.ReferenceId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_Transactions_Detail_AR_Transactions_Reference");

                entity.HasOne(d => d.ArTransactionsNavigation)
                    .WithMany(p => p.ArTransactionsDetailArTransactionsNavigation)
                    .HasForeignKey(d => new { d.LocationCode, d.TransactionId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_Transactions_Detail_AR_Transactions");
            });

            modelBuilder.Entity<AttributeGroupAttributes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.AttributeGroupCode, e.AttributeCode })
                    .IsClustered(false);

                entity.HasIndex(e => e.AttributeCode)
                    .HasName("Attribute_Code");

                entity.HasIndex(e => e.AttributeGroupCode)
                    .HasName("Attribute_Group_Code");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => new { e.LocationCode, e.AttributeCode })
                    .HasName("AttributesAttributeGroupAttributes");

                entity.HasIndex(e => new { e.LocationCode, e.AttributeGroupCode })
                    .HasName("Attribute_GroupsAttributeGroupAttributes");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AttributeGroupCode)
                    .HasColumnName("Attribute_Group_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AttributeCode)
                    .HasColumnName("Attribute_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("Display_Order")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.AttributeGroupAttributes)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AttributeGroupAttributes_Location_Codes");

                entity.HasOne(d => d.Attributes)
                    .WithMany(p => p.AttributeGroupAttributes)
                    .HasForeignKey(d => new { d.LocationCode, d.AttributeCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AttributeGroupAttributes_Attributes");

                entity.HasOne(d => d.AttributeGroups)
                    .WithMany(p => p.AttributeGroupAttributes)
                    .HasForeignKey(d => new { d.LocationCode, d.AttributeGroupCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AttributeGroupAttributes_Attribute_Groups");
            });

            modelBuilder.Entity<AttributeGroups>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.AttributeGroupCode })
                    .IsClustered(false);

                entity.ToTable("Attribute_Groups");

                entity.HasIndex(e => e.AttributeGroupCode)
                    .HasName("Menu_Type_ID");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => e.MaximumNumber)
                    .HasName("Number_To_Choose");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AttributeGroupCode)
                    .HasColumnName("Attribute_Group_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("Display_Order")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaximumNumber)
                    .HasColumnName("Maximum_Number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MinimumNumber)
                    .HasColumnName("Minimum_Number")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.AttributeGroups)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Attribute_Groups_Location_Codes");
            });

            modelBuilder.Entity<Attributes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.AttributeCode })
                    .IsClustered(false);

                entity.HasIndex(e => e.AttributeCode)
                    .HasName("Menu_Code")
                    .IsUnique();

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AttributeCode)
                    .HasColumnName("Attribute_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("Display_Order")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.Attributes)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Attributes_Location_Codes");
            });

            modelBuilder.Entity<AuditAction>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.ActionId, e.LanguageCode });

                entity.ToTable("Audit_Action");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ActionId).HasColumnName("Action_ID");

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.DefaultActionDescription)
                    .IsRequired()
                    .HasColumnName("Default_Action_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldList)
                    .IsRequired()
                    .HasColumnName("Field_List")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId).HasColumnName("Group_ID");

                entity.Property(e => e.ModifiedActionDescription)
                    .IsRequired()
                    .HasColumnName("Modified_Action_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AuditGroup)
                    .WithMany(p => p.AuditAction)
                    .HasForeignKey(d => new { d.LocationCode, d.GroupId, d.LanguageCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Audit_Action_Audit_Group");
            });

            modelBuilder.Entity<AuditEvents>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DatabaseName).HasMaxLength(255);

                entity.Property(e => e.EventDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EventDdl).HasColumnName("EventDDL");

                entity.Property(e => e.EventType).HasMaxLength(64);

                entity.Property(e => e.EventXml)
                    .HasColumnName("EventXML")
                    .HasColumnType("xml");

                entity.Property(e => e.HostName)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LoginName).HasMaxLength(255);

                entity.Property(e => e.ObjectName).HasMaxLength(255);

                entity.Property(e => e.ProgramName).HasMaxLength(255);

                entity.Property(e => e.SchemaName).HasMaxLength(255);
            });

            modelBuilder.Entity<AuditGroup>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.GroupId, e.LanguageCode });

                entity.ToTable("Audit_Group");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId).HasColumnName("Group_ID");

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.DefaultGroupDescription)
                    .IsRequired()
                    .HasColumnName("Default_Group_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedGroupDescription)
                    .IsRequired()
                    .HasColumnName("Modified_Group_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuditTrail>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.Id })
                    .IsClustered(false);

                entity.ToTable("Audit_Trail");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessDenied).HasColumnName("Access_Denied");

                entity.Property(e => e.ActionId).HasColumnName("Action_ID");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AddedPositionCode)
                    .HasColumnName("Added_Position_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NewValue)
                    .HasColumnName("New_Value")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalValue)
                    .HasColumnName("Original_Value")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VbMenuItemId).HasColumnName("VB_Menu_Item_ID");
            });

            modelBuilder.Entity<AuditTrailReportOptions>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OptionId, e.LanguageCode });

                entity.ToTable("Audit_Trail_Report_Options");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OptionId).HasColumnName("Option_ID");

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.DefaultDescription)
                    .HasColumnName("Default_Description")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GroupByOption).HasColumnName("Group_By_Option");

                entity.Property(e => e.ModifiedDescription)
                    .HasColumnName("Modified_Description")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SortByOption).HasColumnName("Sort_By_Option");
            });

            modelBuilder.Entity<AvgOrd>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Added)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DayOfWeek).HasColumnType("money");

                entity.Property(e => e.Dpinum)
                    .HasColumnName("dpinum")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasColumnName("End_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("location_code")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrdTyp)
                    .HasColumnName("ord_typ")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OrderCnt).HasColumnType("money");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderHour).HasColumnType("money");

                entity.Property(e => e.StartDate)
                    .HasColumnName("Start_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SysDate)
                    .HasColumnName("sys_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<BaanDataTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BAAN_DATA_TMP");

                entity.Property(e => e.CurDate)
                    .HasColumnName("CUR_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DelyCode)
                    .HasColumnName("DELY_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DelyType)
                    .HasColumnName("DELY_TYPE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvDate)
                    .HasColumnName("INV_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvNo)
                    .HasColumnName("INV_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCode)
                    .HasColumnName("ITEM_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemQty)
                    .HasColumnName("ITEM_QTY")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.ItemRate)
                    .HasColumnName("ITEM_RATE")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LocnCode)
                    .HasColumnName("LOCN_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldRate)
                    .HasColumnName("OLD_RATE")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PosCode)
                    .HasColumnName("POS_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PosQty)
                    .HasColumnName("POS_QTY")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.PosRate)
                    .HasColumnName("POS_RATE")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RecNo).HasColumnName("REC_NO");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VendCode)
                    .HasColumnName("VEND_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BatchInstallerLogs>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("BatchInstaller_Logs");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.ActionId)
                    .HasColumnName("ActionID")
                    .HasMaxLength(50);

                entity.Property(e => e.Discription)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.LogName).HasMaxLength(300);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<BeatsOrderLine>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderDate, e.OrderNumber, e.LineNumber, e.Sequence })
                    .IsClustered(false);

                entity.ToTable("Beats_Order_Line");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.LineNumber).HasColumnName("Line_Number");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AddedDate)
                    .HasColumnName("Added_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MenuCategoryCode)
                    .HasColumnName("Menu_Category_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderLineNoTaxDiscount)
                    .HasColumnName("Order_Line_No_Tax_Discount")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTax1)
                    .HasColumnName("Order_Line_Tax1")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTaxDiscount)
                    .HasColumnName("Order_Line_Tax_Discount")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTaxableSale1)
                    .HasColumnName("Order_Line_Taxable_Sale1")
                    .HasColumnType("money");

                entity.Property(e => e.OvenTime)
                    .HasColumnName("Oven_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.SizeCode)
                    .HasColumnName("Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("Updated_Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<BioForceLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BioForce_Log");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.EmpCode)
                    .HasColumnName("Emp_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MgrId)
                    .HasColumnName("Mgr_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Reason).IsUnicode(false);

                entity.Property(e => e.ReasonId).HasColumnName("Reason_id");

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeIn)
                    .HasColumnName("Time_In")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<BumpBarKey>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.BumpBarKey1 })
                    .IsClustered(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BumpBarKey1).HasColumnName("BumpBarKey");

                entity.Property(e => e.AssignedKeyDesc)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BumpBarDesc)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.BumpBarKey)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BumpBarKey_Location_Codes");
            });

            modelBuilder.Entity<CallCenterMessage>(entity =>
            {
                entity.HasKey(e => new { e.MessageId, e.LocationCode })
                    .HasName("PK__CallCent__662979BE188BD872");

                entity.ToTable("CallCenter_Message");

                entity.Property(e => e.MessageId)
                    .HasColumnName("MessageID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.MessageDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CallSmdr>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AgentId)
                    .HasColumnName("AgentID")
                    .HasMaxLength(20);

                entity.Property(e => e.CallDateTime).HasColumnType("datetime");

                entity.Property(e => e.CalledId).HasMaxLength(50);

                entity.Property(e => e.CallerId)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ClearDateTime).HasColumnType("datetime");

                entity.Property(e => e.ConnectId).HasMaxLength(50);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer_name")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IfNoRemarks).HasMaxLength(50);

                entity.Property(e => e.IfYesAmount).HasColumnType("money");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("location_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber).HasColumnName("Order_number");

                entity.Property(e => e.Origin).HasMaxLength(50);

                entity.Property(e => e.PortId).HasMaxLength(10);

                entity.Property(e => e.Reason).HasMaxLength(50);

                entity.Property(e => e.RedirectingId).HasMaxLength(50);

                entity.Property(e => e.RedirectionId).HasMaxLength(50);

                entity.Property(e => e.StoreCode).HasMaxLength(50);
            });

            modelBuilder.Entity<CallerId>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.Line })
                    .IsClustered(false);

                entity.ToTable("Caller_ID");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Line)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CallDate)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CallTime)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasColumnName("Customer_Name")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnName("Phone_Number")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneSystemUniqueId)
                    .HasColumnName("Phone_System_Unique_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.CallerId)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Caller_ID_Location_Codes");
            });

            modelBuilder.Entity<CallerIdConnectionTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.CallerIdConnectionTypeCode });

                entity.ToTable("Caller_ID_Connection_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CallerIdConnectionTypeCode).HasColumnName("Caller_ID_Connection_Type_Code");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.CallerIdConnectionTypes)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Caller_ID_Connection_Types_Location_Codes");
            });

            modelBuilder.Entity<CallerIdCustSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Caller_ID_Cust_Setting");

                entity.Property(e => e.CustFrom).HasDefaultValueSql("((30))");

                entity.Property(e => e.CustTo).HasDefaultValueSql("((10))");
            });

            modelBuilder.Entity<CallerIdLog>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.Line, e.Added })
                    .IsClustered(false);

                entity.ToTable("Caller_ID_Log");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Line)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CallDate)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CallTime)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasColumnName("Customer_Name")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnName("Phone_Number")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.CallerIdLog)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Caller_ID_Log_Location_Codes");
            });

            modelBuilder.Entity<CallerIdPhoneNo>(entity =>
            {
                entity.HasKey(e => e.FromPhoneNo);

                entity.ToTable("Caller_ID_Phone_No");

                entity.Property(e => e.FromPhoneNo)
                    .HasColumnName("From_Phone_No")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelephoneNo)
                    .IsRequired()
                    .HasColumnName("Telephone_no")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ToPhoneNo)
                    .IsRequired()
                    .HasColumnName("To_Phone_No")
                    .HasMaxLength(14)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CallerIdSettings>(entity =>
            {
                entity.HasKey(e => e.LocationCode)
                    .IsClustered(false);

                entity.ToTable("Caller_ID_Settings");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BaudRate).HasColumnName("Baud_Rate");

                entity.Property(e => e.CallerIdConnectionTypeCode)
                    .HasColumnName("Caller_ID_Connection_Type_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Channel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataBits).HasColumnName("Data_Bits");

                entity.Property(e => e.HostName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NetworkPort)
                    .HasColumnName("Network_Port")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfLines).HasColumnName("Number_Of_Lines");

                entity.Property(e => e.ParityTypeCode).HasColumnName("Parity_Type_Code");

                entity.Property(e => e.SerialPortCode).HasColumnName("Serial_Port_Code");

                entity.Property(e => e.StopBits).HasColumnName("Stop_Bits");

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UseRemotely).HasColumnName("Use_Remotely");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithOne(p => p.CallerIdSettings)
                    .HasForeignKey<CallerIdSettings>(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Caller_ID_Settings_Location_Codes");
            });

            modelBuilder.Entity<CashDrawerAudit>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderDate, e.WorkstationId, e.Sequence });

                entity.ToTable("Cash_Drawer_Audit");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.WorkstationId).HasColumnName("Workstation_ID");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ArSalesTotal)
                    .HasColumnName("AR_Sales_Total")
                    .HasColumnType("money");

                entity.Property(e => e.CashSalesTotal)
                    .HasColumnName("Cash_Sales_Total")
                    .HasColumnType("money");

                entity.Property(e => e.CheckSalesTotal)
                    .HasColumnName("Check_Sales_Total")
                    .HasColumnType("money");

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasColumnName("Computer_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardSalesTotal)
                    .HasColumnName("Credit_Card_Sales_Total")
                    .HasColumnType("money");

                entity.Property(e => e.EndTime)
                    .HasColumnName("End_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.GiftCardSalesTotal)
                    .HasColumnName("Gift_Card_Sales_Total")
                    .HasColumnType("money");

                entity.Property(e => e.OrderPayments)
                    .HasColumnName("Order_Payments")
                    .HasColumnType("money");

                entity.Property(e => e.StartTillAmount)
                    .HasColumnName("Start_Till_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.StartTime)
                    .HasColumnName("Start_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.TillToAccount)
                    .HasColumnName("Till_To_Account")
                    .HasColumnType("money");

                entity.Property(e => e.TipTotal)
                    .HasColumnName("Tip_Total")
                    .HasColumnType("money");

                entity.Property(e => e.TotalOrderPayments)
                    .HasColumnName("Total_Order_Payments")
                    .HasColumnType("money");

                entity.Property(e => e.TotalPayments)
                    .HasColumnName("Total_Payments")
                    .HasColumnType("money");

                entity.Property(e => e.VoidedOrderPayments)
                    .HasColumnName("Voided_Order_Payments")
                    .HasColumnType("money");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.CashDrawerAudit)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cash_Drawer_Audit_Location_Codes");
            });

            modelBuilder.Entity<CheckMultipleOrders>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("check_multiple_orders");

                entity.HasIndex(e => new { e.TentNumber, e.OrderDate })
                    .HasName("uq_multiple_order")
                    .IsUnique();

                entity.Property(e => e.AddedDatetime)
                    .HasColumnName("Added_Datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.OrderStatus).HasColumnName("Order_Status");

                entity.Property(e => e.TentNumber)
                    .HasColumnName("Tent_Number")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.CityCode })
                    .IsClustered(false);

                entity.HasIndex(e => e.RegionCode)
                    .HasName("RegionsCity");

                entity.HasIndex(e => new { e.LocationCode, e.CityName, e.RegionCode })
                    .HasName("IX_City_Name")
                    .IsUnique();

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CityCode).HasColumnName("City_Code");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("City_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegionCode).HasColumnName("Region_Code");

                entity.Property(e => e.TaxRate1).HasColumnName("Tax_Rate1");

                entity.Property(e => e.TaxRate2).HasColumnName("Tax_Rate2");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_City_Location_Codes");

                entity.HasOne(d => d.Regions)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => new { d.LocationCode, d.RegionCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_City_Regions");
            });

            modelBuilder.Entity<ColumnDescriptions>(entity =>
            {
                entity.HasKey(e => new { e.TableName, e.ColumnName })
                    .IsClustered(false);

                entity.ToTable("Column_Descriptions");

                entity.Property(e => e.TableName)
                    .HasColumnName("Table_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColumnName)
                    .HasColumnName("Column_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ControlProperties>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.Form, e.Control })
                    .HasName("aaaaaControl_Properties_PK")
                    .IsClustered(false);

                entity.ToTable("Control_Properties");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Form).HasMaxLength(50);

                entity.Property(e => e.Control).HasMaxLength(50);

                entity.Property(e => e.LabelName)
                    .HasColumnName("Label_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.TabOrder).HasColumnName("Tab_Order");

                entity.Property(e => e.XLeft).HasColumnName("X_Left");

                entity.Property(e => e.YTop).HasColumnName("Y_Top");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.ControlProperties)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Control_Properties_Location_Codes");
            });

            modelBuilder.Entity<ControlledFiles>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.FileName });

                entity.ToTable("Controlled_Files");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasColumnName("File_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionLong)
                    .HasColumnName("Description_Long")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescrptionShort)
                    .HasColumnName("Descrption_Short")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FileDate)
                    .HasColumnName("File_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileLocationCode).HasColumnName("File_Location_Code");

                entity.Property(e => e.FileSize).HasColumnName("File_Size");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MandantoryUpdate).HasColumnName("Mandantory_Update");

                entity.Property(e => e.MasterSourcePath)
                    .HasColumnName("Master_Source_Path")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegistryUpdate).HasColumnName("Registry_Update");

                entity.Property(e => e.StandardDestinationPath)
                    .HasColumnName("Standard_Destination_Path")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateBehaviorCode)
                    .HasColumnName("Update_Behavior_Code")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.ControlledFiles)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Controlled_Files_Location_Codes");

                entity.HasOne(d => d.FileLocationCodes)
                    .WithMany(p => p.ControlledFiles)
                    .HasForeignKey(d => new { d.LocationCode, d.FileLocationCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Controlled_Files_File_Location_Type");

                entity.HasOne(d => d.UpdateBehaviorCodes)
                    .WithMany(p => p.ControlledFiles)
                    .HasForeignKey(d => new { d.LocationCode, d.UpdateBehaviorCode })
                    .HasConstraintName("FK_Controlled_Files_Update_Behavior_Type");
            });

            modelBuilder.Entity<CorporateCustomer>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.CompanyCode });

                entity.ToTable("Corporate_Customer");

                entity.HasIndex(e => e.CompanyName)
                    .HasName("UQ__Corporat__9BCE05DC6882C53E")
                    .IsUnique();

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_by")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddressType)
                    .HasColumnName("address_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddress)
                    .HasColumnName("Company_Address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditAmount)
                    .HasColumnName("Credit_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.EndDate)
                    .HasColumnName("End_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Extn)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gstinno)
                    .HasColumnName("GSTINNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTerm).HasColumnName("Payment_Term");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("Phone_Number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .HasColumnName("Start_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CountType>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.CountTypeCode });

                entity.ToTable("Count_Type");

                entity.HasIndex(e => e.CountTypeCode)
                    .HasName("Count_Type_ID");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CountTypeCode).HasColumnName("Count_Type_Code");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.CountType)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Count_Type_Location_Codes");
            });

            modelBuilder.Entity<CouponAppledRule>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.CouponCode });

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.CouponCode)
                    .HasColumnName("Coupon_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.CouponTypeCode).HasColumnName("Coupon_type_code");

                entity.Property(e => e.FreeCount).HasColumnName("Free_Count");

                entity.Property(e => e.IsMinItem).HasColumnName("Is_Min_Item");

                entity.Property(e => e.TotalItemCount).HasColumnName("Total_Item_Count");
            });

            modelBuilder.Entity<CouponAppliedDay>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasColumnName("Coupon_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.SequenceNumber).HasColumnName("Sequence_Number");
            });

            modelBuilder.Entity<CouponBogo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CouponBOGO");

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasColumnName("Coupon_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.FreeCount).HasColumnName("Free_Count");

                entity.Property(e => e.IsMinItem).HasColumnName("Is_Min_Item");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TotalItemCount).HasColumnName("Total_Item_Count");
            });

            modelBuilder.Entity<CouponDayMaster>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DayName)
                    .HasColumnName("Day_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.SequenceNumber).HasColumnName("Sequence_Number");
            });

            modelBuilder.Entity<CouponHappyHour>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BeginTime)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasColumnName("Coupon_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<CouponRuleEngine>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.CouponCode });

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CouponCode)
                    .HasColumnName("Coupon_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AnyItem).HasColumnName("Any_item");

                entity.Property(e => e.DiscountItemCount).HasColumnName("Discount_Item_Count");

                entity.Property(e => e.DiscountItemCountLimit).HasColumnName("Discount_Item_Count_Limit");

                entity.Property(e => e.DiscountType).HasColumnName("Discount_Type");

                entity.Property(e => e.PrimaryItemCount).HasColumnName("Primary_item_Count");
            });

            modelBuilder.Entity<CouponTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.CouponTypeCode });

                entity.ToTable("Coupon_Types");

                entity.HasIndex(e => e.CouponTypeCode)
                    .HasName("Coupon_Type_Code");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CouponTypeCode).HasColumnName("Coupon_Type_Code");

                entity.Property(e => e.Description)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.CouponTypes)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Coupon_Types_Location_Codes");
            });

            modelBuilder.Entity<Coupons>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.CouponCode });

                entity.HasIndex(e => e.CouponCode)
                    .HasName("Coupon_Code");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => e.StatusCode)
                    .HasName("Status_Code");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CouponCode)
                    .HasColumnName("Coupon_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Adjustment).HasDefaultValueSql("((0))");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.AnyItem)
                    .HasColumnName("Any_Item")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BeginDate)
                    .HasColumnName("Begin_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CouponTypeCode).HasColumnName("Coupon_Type_Code");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");

                entity.Property(e => e.EndDate)
                    .HasColumnName("End_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EntireOrder)
                    .HasColumnName("Entire_Order")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GiftCardActivationDiscount).HasColumnName("Gift_Card_Activation_Discount");

                entity.Property(e => e.MinPrice)
                    .HasColumnName("Min_Price")
                    .HasColumnType("money");

                entity.Property(e => e.ProtectCoupon).HasColumnName("Protect_Coupon");

                entity.Property(e => e.RemoteOrderAvailability)
                    .HasColumnName("Remote_Order_Availability")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.StatusCode).HasColumnName("Status_Code");

                entity.Property(e => e.Taxable).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.Coupons)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Coupons_Location_Codes");
            });

            modelBuilder.Entity<CouponsCapping>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.CouponCode });

                entity.ToTable("Coupons_Capping");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CouponCode)
                    .HasColumnName("Coupon_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ApplyCarryOut).HasColumnName("Apply_CarryOut");

                entity.Property(e => e.ApplyCombo).HasColumnName("Apply_Combo");

                entity.Property(e => e.ApplyDelivery).HasColumnName("Apply_Delivery");

                entity.Property(e => e.ApplyDineIn).HasColumnName("Apply_DineIn");

                entity.Property(e => e.ApplyOdc).HasColumnName("Apply_ODC");

                entity.Property(e => e.CappingStatus).HasColumnName("Capping_Status");

                entity.Property(e => e.LastModify)
                    .HasColumnName("Last_Modify")
                    .HasColumnType("datetime");

                entity.Property(e => e.LineCouponExcluded).HasColumnName("Line_Coupon_Excluded");

                entity.Property(e => e.MaxCouponAmount)
                    .HasColumnName("Max_Coupon_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.MinOrderAmount)
                    .HasColumnName("Min_Order_Amount")
                    .HasColumnType("money");

                entity.HasOne(d => d.Coupons)
                    .WithOne(p => p.CouponsCapping)
                    .HasForeignKey<CouponsCapping>(d => new { d.LocationCode, d.CouponCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Coupons_Capping_coupons");
            });

            modelBuilder.Entity<CouponsExemptedItems>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.CouponCode, e.MenuCode, e.SizeCode });

                entity.ToTable("Coupons_Exempted_items");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CouponCode)
                    .HasColumnName("Coupon_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SizeCode)
                    .HasColumnName("Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ExemptedStatus).HasColumnName("Exempted_Status");

                entity.Property(e => e.OrderValueExempted).HasColumnName("Order_Value_Exempted");
            });

            modelBuilder.Entity<CreditCardAccounts>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.CreditCardId })
                    .IsClustered(false);

                entity.ToTable("Credit_Card_Accounts");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardId).HasColumnName("Credit_Card_ID");

                entity.Property(e => e.AccountId).HasColumnName("Account_ID");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_by")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SignatureRequiredAmount)
                    .HasColumnName("Signature_Required_Amount")
                    .HasColumnType("money");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.CreditCardAccounts)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Credit_Card_Accounts_Location_Codes");

                entity.HasOne(d => d.Accounts)
                    .WithMany(p => p.CreditCardAccounts)
                    .HasForeignKey(d => new { d.LocationCode, d.AccountId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Credit_Card_Accounts_Accounts");

                entity.HasOne(d => d.CreditCards)
                    .WithOne(p => p.CreditCardAccounts)
                    .HasForeignKey<CreditCardAccounts>(d => new { d.LocationCode, d.CreditCardId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Credit_Card_Accounts_Credit_Cards");
            });

            modelBuilder.Entity<CreditCardActionCodes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.ActionCode })
                    .IsClustered(false);

                entity.ToTable("Credit_Card_Action_Codes");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ActionCode).HasColumnName("Action_Code");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.CreditCardActionCodes)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Credit_Card_Action_Codes_Location_Codes");
            });

            modelBuilder.Entity<CreditCardActionCodesDescriptions>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.ActionCode })
                    .IsClustered(false);

                entity.ToTable("Credit_Card_Action_Codes_Descriptions");

                entity.HasIndex(e => new { e.LocationCode, e.LanguageCode })
                    .HasName("IX_Credit_Card_Action_Codes_Descriptions");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.ActionCode).HasColumnName("Action_Code");

                entity.Property(e => e.DefaultDescription)
                    .IsRequired()
                    .HasColumnName("Default_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDescription)
                    .IsRequired()
                    .HasColumnName("Modified_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.CreditCardActionCodesDescriptions)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Credit_Card_Action_Codes_Descriptions_Location_Codes");

                entity.HasOne(d => d.CreditCardActionCodes)
                    .WithMany(p => p.CreditCardActionCodesDescriptions)
                    .HasForeignKey(d => new { d.LocationCode, d.ActionCode })
                    .HasConstraintName("FK_Credit_Card_Action_Codes_Descriptions");
            });

            modelBuilder.Entity<CreditCardEntryMethods>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.EntryMethod })
                    .IsClustered(false);

                entity.ToTable("Credit_Card_Entry_Methods");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EntryMethod).HasColumnName("Entry_Method");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.CreditCardEntryMethods)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Credit_Card_Entry_Methods_Location_Codes");
            });

            modelBuilder.Entity<CreditCardEntryMethodsDescriptions>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.EntryMethod })
                    .IsClustered(false);

                entity.ToTable("Credit_Card_Entry_Methods_Descriptions");

                entity.HasIndex(e => new { e.LocationCode, e.LanguageCode })
                    .HasName("IX_Credit_Card_Entry_Methods_Descriptions");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.EntryMethod).HasColumnName("Entry_Method");

                entity.Property(e => e.DefaultDescription)
                    .IsRequired()
                    .HasColumnName("Default_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDescription)
                    .IsRequired()
                    .HasColumnName("Modified_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.CreditCardEntryMethodsDescriptions)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Credit_Card_Entry_Methods_Descriptions_Location_Codes");

                entity.HasOne(d => d.CreditCardEntryMethods)
                    .WithMany(p => p.CreditCardEntryMethodsDescriptions)
                    .HasForeignKey(d => new { d.LocationCode, d.EntryMethod })
                    .HasConstraintName("FK_Credit_Card_Entry_Methods_Descriptions");
            });

            modelBuilder.Entity<CreditCardNumberRanges>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.CardRangeId });

                entity.ToTable("Credit_Card_Number_Ranges");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CardRangeId).HasColumnName("Card_Range_ID");

                entity.Property(e => e.CardBeginRange).HasColumnName("Card_Begin_Range");

                entity.Property(e => e.CardDescription)
                    .IsRequired()
                    .HasColumnName("Card_Description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CardEndRange).HasColumnName("Card_End_Range");

                entity.Property(e => e.CardLength).HasColumnName("Card_Length");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.CreditCardNumberRanges)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Credit_Card_Number_Ranges_Location_Codes");
            });

            modelBuilder.Entity<CreditCardProcessingTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.CreditCardProcessing })
                    .IsClustered(false);

                entity.ToTable("Credit_Card_Processing_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.CreditCardProcessing).HasColumnName("Credit_Card_Processing");

                entity.Property(e => e.DefaultDescription)
                    .IsRequired()
                    .HasColumnName("Default_Description")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDescription)
                    .IsRequired()
                    .HasColumnName("Modified_Description")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.CreditCardProcessingTypes)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Credit_Card_Processing_Types_Location_Codes");
            });

            modelBuilder.Entity<CreditCardSettings>(entity =>
            {
                entity.HasKey(e => e.LocationCode);

                entity.ToTable("Credit_Card_Settings");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AvsSetting).HasColumnName("AVS_Setting");

                entity.Property(e => e.CreditCardProcessing).HasColumnName("Credit_Card_Processing");

                entity.Property(e => e.Cvv2Setting).HasColumnName("CVV2_Setting");

                entity.Property(e => e.DaysToKeepCcOrderHistory).HasColumnName("Days_To_Keep_CC_Order_History");

                entity.Property(e => e.InFileLocation)
                    .HasColumnName("In_File_Location")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LogProcessorCommunications).HasColumnName("Log_Processor_Communications");

                entity.Property(e => e.MaxUnsettledDays).HasColumnName("Max_Unsettled_Days");

                entity.Property(e => e.MerchantNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OutFileLocation)
                    .HasColumnName("Out_File_Location")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password).HasMaxLength(3000);

                entity.Property(e => e.PortId)
                    .HasColumnName("PortID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Processor)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ThirdPartyDllFileLocation)
                    .HasColumnName("Third_Party_DLL_File_Location")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithOne(p => p.CreditCardSettings)
                    .HasForeignKey<CreditCardSettings>(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Credit_Card_Settings_Location_Codes");
            });

            modelBuilder.Entity<CreditCardTransaction>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.TransactionId, e.OrderDate, e.OrderNumber });

                entity.ToTable("Credit_Card_Transaction");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId).HasColumnName("Transaction_ID");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],'19010101',(0)))");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasColumnName("Address_Line_2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine3)
                    .HasColumnName("Address_Line_3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine4)
                    .HasColumnName("Address_Line_4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CancelAmount).HasColumnType("money");

                entity.Property(e => e.CancelMessage)
                    .HasColumnName("Cancel_Message")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CancelTransactionStatusCode).HasColumnName("Cancel_Transaction_Status_Code");

                entity.Property(e => e.CancelTransactionTime).HasColumnName("Cancel_Transaction_Time");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComputerName)
                    .HasColumnName("Computer_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardId).HasColumnName("Credit_Card_ID");

                entity.Property(e => e.CrossStreetCode).HasColumnName("Cross_Street_Code");

                entity.Property(e => e.CustomerCode).HasColumnName("Customer_Code");

                entity.Property(e => e.EdcrefId)
                    .HasColumnName("EDCRefID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddress)
                    .HasColumnName("Mailing_Address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderAmount)
                    .HasColumnName("Order_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.OrderTakerId)
                    .HasColumnName("Order_Taker_ID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTypeCode)
                    .HasColumnName("Order_Type_Code")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PayNow).HasColumnName("Pay_Now");

                entity.Property(e => e.PhoneExt)
                    .HasColumnName("Phone_Ext")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("Phone_Number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("Postal_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RefundAmount).HasColumnType("money");

                entity.Property(e => e.RefundMessage)
                    .HasColumnName("Refund_Message")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RefundTransactionStatusCode).HasColumnName("Refund_Transaction_Status_Code");

                entity.Property(e => e.RefundTransactionTime).HasColumnName("Refund_Transaction_Time");

                entity.Property(e => e.StreetCode).HasColumnName("Street_Code");

                entity.Property(e => e.StreetNumber)
                    .HasColumnName("Street_Number")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Suite)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate)
                    .HasColumnName("Transaction_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TransactionStatusCode).HasColumnName("Transaction_Status_Code");

                entity.Property(e => e.TransactionTime).HasColumnName("Transaction_Time");

                entity.Property(e => e.WorkstationId).HasColumnName("Workstation_ID");
            });

            modelBuilder.Entity<CreditCardTransactionTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.TransactionType })
                    .IsClustered(false);

                entity.ToTable("Credit_Card_Transaction_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType).HasColumnName("Transaction_Type");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.CreditCardTransactionTypes)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Credit_Card_Transaction_Types_Location_Codes");
            });

            modelBuilder.Entity<CreditCardTransactionTypesDescriptions>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.TransactionType })
                    .IsClustered(false);

                entity.ToTable("Credit_Card_Transaction_Types_Descriptions");

                entity.HasIndex(e => new { e.LocationCode, e.LanguageCode })
                    .HasName("IX_Credit_Card_Transaction_Types_Descriptions");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.TransactionType).HasColumnName("Transaction_Type");

                entity.Property(e => e.DefaultDescription)
                    .IsRequired()
                    .HasColumnName("Default_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDescription)
                    .IsRequired()
                    .HasColumnName("Modified_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.CreditCardTransactionTypesDescriptions)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Credit_Card_Transaction_Types_Descriptions_Location_Codes");

                entity.HasOne(d => d.CreditCardTransactionTypes)
                    .WithMany(p => p.CreditCardTransactionTypesDescriptions)
                    .HasForeignKey(d => new { d.LocationCode, d.TransactionType })
                    .HasConstraintName("FK_Credit_Card_Transaction_Types_Descriptions");
            });

            modelBuilder.Entity<CreditCardVendor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Credit_Card_Vendor");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardId).HasColumnName("Credit_Card_ID");

                entity.Property(e => e.ExeName)
                    .HasColumnName("Exe_Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FieldFilter)
                    .HasColumnName("Field_Filter")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TimeOut).HasColumnName("Time_Out");
            });

            modelBuilder.Entity<CreditCards>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.CreditCardId })
                    .IsClustered(false);

                entity.ToTable("Credit_Cards");

                entity.HasIndex(e => new { e.LocationCode, e.Description })
                    .HasName("IX_Credit_Cards")
                    .IsUnique();

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardId).HasColumnName("Credit_Card_ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GiftCard)
                    .HasColumnName("Gift_Card")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PayType).HasColumnName("Pay_type");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.CreditCards)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Credit_Cards_Location_Codes");
            });

            modelBuilder.Entity<CreditCardsDescriptions>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.CreditCardId })
                    .IsClustered(false);

                entity.ToTable("Credit_Cards_Descriptions");

                entity.HasIndex(e => new { e.LocationCode, e.LanguageCode })
                    .HasName("IX_Credit_Cards_Descriptions");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.CreditCardId).HasColumnName("Credit_Card_ID");

                entity.Property(e => e.DefaultDescription)
                    .IsRequired()
                    .HasColumnName("Default_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDescription)
                    .IsRequired()
                    .HasColumnName("Modified_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.CreditCardsDescriptions)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Credit_Cards_Descriptions_Location_Codes");

                entity.HasOne(d => d.CreditCards)
                    .WithMany(p => p.CreditCardsDescriptions)
                    .HasForeignKey(d => new { d.LocationCode, d.CreditCardId })
                    .HasConstraintName("FK_Credit_Cards_Descriptions");
            });

            modelBuilder.Entity<CurrencyCommonBills>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.CurrencyCode, e.BillCode })
                    .IsClustered(false);

                entity.ToTable("Currency_Common_Bills");

                entity.HasIndex(e => e.BillCode)
                    .HasName("Bill_Code");

                entity.HasIndex(e => e.CurrencyCode)
                    .HasName("Currency_TypeCurrency_Common_Bills");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("Currency_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BillCode)
                    .HasColumnName("Bill_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");

                entity.Property(e => e.OrderDescription)
                    .IsRequired()
                    .HasColumnName("Order_Description")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.CurrencyCommonBills)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Currency_Common_Bills_Location_Codes");

                entity.HasOne(d => d.CurrencyType)
                    .WithMany(p => p.CurrencyCommonBills)
                    .HasForeignKey(d => new { d.LocationCode, d.CurrencyCode })
                    .HasConstraintName("FK_Currency_Common_Bills_Currency_Type");
            });

            modelBuilder.Entity<CurrencyExchange>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.SystemDate, e.CurrencyCode })
                    .IsClustered(false);

                entity.ToTable("Currency_Exchange");

                entity.HasIndex(e => e.CurrencyCode)
                    .HasName("CurrencyCurrency_Exchange");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("System_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("Currency_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnName("Exchange_Rate");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.CurrencyExchange)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Currency_Exchange_Location_Codes");

                entity.HasOne(d => d.CurrencyType)
                    .WithMany(p => p.CurrencyExchange)
                    .HasForeignKey(d => new { d.LocationCode, d.CurrencyCode })
                    .HasConstraintName("FK_Currency_Exchange_Currency_Type");
            });

            modelBuilder.Entity<CurrencyType>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.CurrencyCode });

                entity.ToTable("Currency_Type");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("Currency_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyImage).HasColumnName("Currency_Image");

                entity.Property(e => e.Decimal)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DecimalPlaces)
                    .HasColumnName("Decimal_Places")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DigitsInGroup)
                    .HasColumnName("Digits_in_Group")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");

                entity.Property(e => e.GroupingSymbol)
                    .HasColumnName("Grouping_Symbol")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NegativeFormat)
                    .HasColumnName("Negative_Format")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDescription)
                    .HasColumnName("Order_Description")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PositiveFormat)
                    .HasColumnName("Positive_Format")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Symbol)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TextColor)
                    .HasColumnName("Text_Color")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.CurrencyType)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Currency_Type_Location_Codes");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.PhoneNumber, e.PhoneExt })
                    .HasName("aaaaaCustomer_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.AddressType)
                    .HasName("Address_TypesCustomer");

                entity.HasIndex(e => e.CrossStreetCode)
                    .HasName("StreetsCustomer1");

                entity.HasIndex(e => e.PhoneExt)
                    .HasName("Phone_Ext");

                entity.HasIndex(e => e.PhoneNumber)
                    .HasName("Phone_Number");

                entity.HasIndex(e => e.Plus4)
                    .HasName("Plus4");

                entity.HasIndex(e => e.PostalCode)
                    .HasName("Postal_Code");

                entity.HasIndex(e => e.StreetCode)
                    .HasName("StreetsCustomer");

                entity.HasIndex(e => new { e.LocationCode, e.CustomerCode })
                    .HasName("Customer_Code")
                    .IsUnique();

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("Phone_Number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneExt)
                    .HasColumnName("Phone_Ext")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AcceptCash)
                    .IsRequired()
                    .HasColumnName("Accept_Cash")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AcceptChargeAccount).HasColumnName("Accept_Charge_Account");

                entity.Property(e => e.AcceptChecks)
                    .HasColumnName("Accept_Checks")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AcceptCreditCards)
                    .IsRequired()
                    .HasColumnName("Accept_Credit_Cards")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AcceptGiftCards)
                    .IsRequired()
                    .HasColumnName("Accept_Gift_Cards")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasColumnName("Address_Line_2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine3)
                    .HasColumnName("Address_Line_3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine4)
                    .HasColumnName("Address_Line_4")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddressType)
                    .IsRequired()
                    .HasColumnName("Address_Type")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('R')");

                entity.Property(e => e.AnniversaryDate)
                    .HasColumnName("anniversary_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cart)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditLimit)
                    .HasColumnName("Credit_Limit")
                    .HasColumnType("money");

                entity.Property(e => e.CrossStreetCode).HasColumnName("Cross_Street_Code");

                entity.Property(e => e.CustomerCode).HasColumnName("Customer_Code");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("date_of_birth")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeliveryPointCode)
                    .HasColumnName("Delivery_Point_Code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FinanceChargeRate).HasColumnName("Finance_Charge_Rate");

                entity.Property(e => e.FirstOrderDate)
                    .HasColumnName("First_Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastOrderDate)
                    .HasColumnName("Last_Order_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MailingAddress)
                    .HasColumnName("Mailing_Address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTerms)
                    .HasColumnName("Payment_Terms")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Plus4)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("Postal_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SetDiscount).HasColumnName("Set_Discount");

                entity.Property(e => e.StreetCode).HasColumnName("Street_Code");

                entity.Property(e => e.StreetNumber)
                    .HasColumnName("Street_Number")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Suite)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TaxExempt1)
                    .HasColumnName("Tax_Exempt1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxExempt2)
                    .HasColumnName("Tax_Exempt2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxExempt3)
                    .HasColumnName("Tax_Exempt3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxExempt4)
                    .HasColumnName("Tax_Exempt4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxId1)
                    .HasColumnName("Tax_ID1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxId2)
                    .HasColumnName("Tax_ID2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxId3)
                    .HasColumnName("Tax_ID3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxId4)
                    .HasColumnName("Tax_ID4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WalkSequence)
                    .HasColumnName("Walk_Sequence")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_Location_Codes");

                entity.HasOne(d => d.Streets)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => new { d.LocationCode, d.StreetCode })
                    .HasConstraintName("FK_Customer_Streets");
            });

            modelBuilder.Entity<CustomerDaily>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.CustomerCode })
                    .IsClustered(false);

                entity.ToTable("Customer_Daily");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode).HasColumnName("Customer_Code");

                entity.Property(e => e.AddressLine2)
                    .HasColumnName("Address_Line_2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine3)
                    .HasColumnName("Address_Line_3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine4)
                    .HasColumnName("Address_Line_4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressType)
                    .HasColumnName("Address_Type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CityName)
                    .HasColumnName("City_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrossStreetCode).HasColumnName("Cross_Street_Code");

                entity.Property(e => e.CrossStreetName)
                    .HasColumnName("Cross_Street_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddress)
                    .HasColumnName("Mailing_Address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneExt)
                    .HasColumnName("Phone_Ext")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("Phone_Number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Plus4)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PostDirection)
                    .HasColumnName("Post_Direction")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("Postal_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PreDirection)
                    .HasColumnName("Pre_Direction")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RegionAbbr)
                    .HasColumnName("Region_Abbr")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RegionName)
                    .HasColumnName("Region_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SectorKey).HasColumnName("Sector_Key");

                entity.Property(e => e.SetDiscount).HasColumnName("Set_Discount");

                entity.Property(e => e.StreetCode).HasColumnName("Street_Code");

                entity.Property(e => e.StreetName)
                    .HasColumnName("Street_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StreetNumber)
                    .HasColumnName("Street_Number")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Suite)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TaxExempt1).HasColumnName("Tax_Exempt1");

                entity.Property(e => e.TaxExempt2).HasColumnName("Tax_Exempt2");

                entity.Property(e => e.TaxExempt3).HasColumnName("Tax_Exempt3");

                entity.Property(e => e.TaxExempt4).HasColumnName("Tax_Exempt4");

                entity.Property(e => e.TaxId1)
                    .HasColumnName("Tax_ID1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxId2)
                    .HasColumnName("Tax_ID2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxId3)
                    .HasColumnName("Tax_ID3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxId4)
                    .HasColumnName("Tax_ID4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxRate1).HasColumnName("Tax_Rate1");

                entity.Property(e => e.TaxRate2).HasColumnName("Tax_Rate2");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.CustomerDaily)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_Daily_Location_Codes");
            });

            modelBuilder.Entity<CustomerGstin>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.PhoneNumber, e.PhoneExt });

                entity.ToTable("Customer_GSTIN");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("Phone_Number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneExt)
                    .HasColumnName("Phone_Ext")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode).HasColumnName("Customer_Code");

                entity.Property(e => e.DataPoint1)
                    .HasColumnName("Data_point1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DataPoint2)
                    .HasColumnName("Data_point2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DataPoint3)
                    .HasColumnName("Data_point3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DataPoint4)
                    .HasColumnName("Data_point4")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DataPoint5)
                    .HasColumnName("Data_point5")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PanNumber)
                    .HasColumnName("Pan_Number")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerLookup>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.CustomerCode, e.CustomerLookupId })
                    .IsClustered(false);

                entity.ToTable("Customer_Lookup");

                entity.HasIndex(e => e.CustomerCode)
                    .HasName("Customer_Code");

                entity.HasIndex(e => e.CustomerLookupTypeCode)
                    .HasName("Customer_Lookup_Type_Code");

                entity.HasIndex(e => new { e.LocationCode, e.CustomerLookupData })
                    .HasName("Customer_Lookup_Data")
                    .IsUnique();

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode).HasColumnName("Customer_Code");

                entity.Property(e => e.CustomerLookupId).HasColumnName("Customer_Lookup_ID");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerLookupData)
                    .IsRequired()
                    .HasColumnName("Customer_Lookup_Data")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerLookupTypeCode).HasColumnName("Customer_Lookup_Type_Code");
            });

            modelBuilder.Entity<CustomerLookupTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.CustomerLookupTypeCode })
                    .IsClustered(false);

                entity.ToTable("Customer_Lookup_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.CustomerLookupTypeCode).HasColumnName("Customer_Lookup_Type_Code");

                entity.Property(e => e.DefaultDescription)
                    .IsRequired()
                    .HasColumnName("Default_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDescription)
                    .IsRequired()
                    .HasColumnName("Modified_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerProfileData>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.CustomerCode, e.CustomerProfileTypeId })
                    .IsClustered(false);

                entity.ToTable("Customer_Profile_Data");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode).HasColumnName("Customer_Code");

                entity.Property(e => e.CustomerProfileTypeId).HasColumnName("Customer_Profile_Type_ID");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerProfileValue)
                    .IsRequired()
                    .HasColumnName("Customer_Profile_Value")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.CustomerProfileData)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_Profile_Data_Location_Codes");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerProfileData)
                    .HasPrincipalKey(p => new { p.LocationCode, p.CustomerCode })
                    .HasForeignKey(d => new { d.LocationCode, d.CustomerCode })
                    .HasConstraintName("FK_Customer_Profile_Data_Customer");

                entity.HasOne(d => d.CustomerProfileTypes)
                    .WithMany(p => p.CustomerProfileData)
                    .HasForeignKey(d => new { d.LocationCode, d.CustomerProfileTypeId })
                    .HasConstraintName("FK_Customer_Profile_Data_Customer_Profile_Types");
            });

            modelBuilder.Entity<CustomerProfileTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.CustomerProfileTypeId })
                    .IsClustered(false);

                entity.ToTable("Customer_Profile_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerProfileTypeId).HasColumnName("Customer_Profile_Type_ID");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultValue)
                    .IsRequired()
                    .HasColumnName("Default_Value")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");

                entity.Property(e => e.MaxLength).HasColumnName("Max_Length");

                entity.Property(e => e.ProfileControlTypeCode).HasColumnName("Profile_Control_Type_Code");

                entity.Property(e => e.ProfileDescription)
                    .IsRequired()
                    .HasColumnName("Profile_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequiredProfile).HasColumnName("Required_Profile");

                entity.Property(e => e.StatusCode).HasColumnName("Status_Code");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.CustomerProfileTypes)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_Profile_Types_Location_Codes");
            });

            modelBuilder.Entity<DailyBackup>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BackType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.LastBackup).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Ver)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DailyInventory>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.InventoryCode, e.EiDate })
                    .IsClustered(false);

                entity.ToTable("Daily_Inventory");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryCode)
                    .HasColumnName("Inventory_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EiDate)
                    .HasColumnName("EI_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CountOrder).HasColumnName("Count_Order");

                entity.Property(e => e.EiOverrideFlag).HasColumnName("EI_Override_Flag");

                entity.Property(e => e.EiPrice)
                    .HasColumnName("EI_Price")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EiQty)
                    .HasColumnName("EI_Qty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ifc)
                    .HasColumnName("IFC")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderQty)
                    .HasColumnName("Order_Qty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Waste).HasColumnType("money");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.DailyInventory)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Daily_Inventory_Location_Codes");

                entity.HasOne(d => d.InventoryItems)
                    .WithMany(p => p.DailyInventory)
                    .HasForeignKey(d => new { d.LocationCode, d.InventoryCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Daily_Inventory_Inventory_Items");
            });

            modelBuilder.Entity<DailyInventoryBad>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("daily_inventory_bad");

                entity.Property(e => e.CountOrder).HasColumnName("Count_Order");

                entity.Property(e => e.EiDate)
                    .HasColumnName("EI_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EiOverrideFlag).HasColumnName("EI_Override_Flag");

                entity.Property(e => e.EiPrice)
                    .HasColumnName("EI_Price")
                    .HasColumnType("money");

                entity.Property(e => e.EiQty)
                    .HasColumnName("EI_Qty")
                    .HasColumnType("money");

                entity.Property(e => e.Ifc)
                    .HasColumnName("IFC")
                    .HasColumnType("money");

                entity.Property(e => e.InventoryCode)
                    .IsRequired()
                    .HasColumnName("Inventory_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderQty)
                    .HasColumnName("Order_Qty")
                    .HasColumnType("money");

                entity.Property(e => e.Waste).HasColumnType("money");
            });

            modelBuilder.Entity<DailyInventoryDetail>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.InventoryCode, e.EiDate })
                    .IsClustered(false);

                entity.ToTable("Daily_Inventory_Detail");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryCode)
                    .HasColumnName("Inventory_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EiDate)
                    .HasColumnName("EI_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CountOrder).HasColumnName("Count_Order");

                entity.Property(e => e.CountUnit)
                    .IsRequired()
                    .HasColumnName("Count_Unit")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EndingCountCount).HasColumnName("Ending_Count_Count");

                entity.Property(e => e.EndingOrderCount).HasColumnName("Ending_Order_Count");

                entity.Property(e => e.EndingPortionCount).HasColumnName("Ending_Portion_Count");

                entity.Property(e => e.OrderUnit)
                    .IsRequired()
                    .HasColumnName("Order_Unit")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PortionCount).HasColumnName("Portion_Count");

                entity.Property(e => e.PortionUnit)
                    .IsRequired()
                    .HasColumnName("Portion_Unit")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.WasteCountCount).HasColumnName("Waste_Count_Count");

                entity.Property(e => e.WasteOrderCount).HasColumnName("Waste_Order_Count");

                entity.Property(e => e.WastePortionCount).HasColumnName("Waste_Portion_Count");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.DailyInventoryDetail)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Daily_Inventory_Detail_Location_Codes");

                entity.HasOne(d => d.InventoryItems)
                    .WithMany(p => p.DailyInventoryDetail)
                    .HasForeignKey(d => new { d.LocationCode, d.InventoryCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Daily_Inventory_Detail_Inventory_Items");
            });

            modelBuilder.Entity<DailyInventoryLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Daily_Inventory_Log");

                entity.Property(e => e.CountOrder).HasColumnName("Count_Order");

                entity.Property(e => e.EiDate)
                    .HasColumnName("EI_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EiOverrideFlag).HasColumnName("EI_Override_Flag");

                entity.Property(e => e.EiPrice)
                    .HasColumnName("EI_Price")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EiQty)
                    .HasColumnName("EI_Qty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasColumnType("numeric(2, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ifc)
                    .HasColumnName("IFC")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InventoryCode)
                    .IsRequired()
                    .HasColumnName("Inventory_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderQty)
                    .HasColumnName("Order_Qty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Waste).HasColumnType("money");
            });

            modelBuilder.Entity<DailyInventoryPrep>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.PrepId })
                    .IsClustered(false);

                entity.ToTable("Daily_Inventory_Prep");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PrepId).HasColumnName("Prep_ID");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CompletedDate)
                    .HasColumnName("Completed_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnName("Expiration_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InventoryCode)
                    .IsRequired()
                    .HasColumnName("Inventory_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryDescription)
                    .IsRequired()
                    .HasColumnName("Inventory_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderUnit)
                    .IsRequired()
                    .HasColumnName("Order_Unit")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PrepAmount).HasColumnName("Prep_Amount");

                entity.Property(e => e.PrepDays).HasColumnName("Prep_Days");

                entity.Property(e => e.PrepHours).HasColumnName("Prep_Hours");

                entity.Property(e => e.PrepMinutes).HasColumnName("Prep_Minutes");

                entity.Property(e => e.PreparedBy)
                    .IsRequired()
                    .HasColumnName("Prepared_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ProductReceived)
                    .HasColumnName("Product_Received")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReadyDate)
                    .HasColumnName("Ready_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReadyDays).HasColumnName("Ready_Days");

                entity.Property(e => e.ReadyHours).HasColumnName("Ready_Hours");

                entity.Property(e => e.ReadyMinutes).HasColumnName("Ready_Minutes");

                entity.Property(e => e.RecipeCost)
                    .HasColumnName("Recipe_Cost")
                    .HasColumnType("money");

                entity.Property(e => e.ShelfLifeDays).HasColumnName("Shelf_Life_Days");

                entity.Property(e => e.ShelfLifeHours).HasColumnName("Shelf_Life_Hours");

                entity.Property(e => e.ShelfLifeMinutes).HasColumnName("Shelf_Life_Minutes");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("System_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.YieldValue)
                    .HasColumnName("Yield_Value")
                    .HasColumnType("money");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.DailyInventoryPrep)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Daily_Inventory_Prep_Location_Codes");

                entity.HasOne(d => d.InventoryItems)
                    .WithMany(p => p.DailyInventoryPrep)
                    .HasForeignKey(d => new { d.LocationCode, d.InventoryCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Daily_Inventory_Prep_Inventory_Items");
            });

            modelBuilder.Entity<DailyInventoryPrepDetail>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.PrepId, e.SubInventoryCode, e.Ingredient })
                    .IsClustered(false);

                entity.ToTable("Daily_Inventory_Prep_Detail");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PrepId).HasColumnName("Prep_ID");

                entity.Property(e => e.SubInventoryCode)
                    .HasColumnName("Sub_Inventory_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CountOrder).HasColumnName("Count_Order");

                entity.Property(e => e.CountUnit)
                    .IsRequired()
                    .HasColumnName("Count_Unit")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryUnit)
                    .HasColumnName("Inventory_Unit")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.OrderUnit)
                    .IsRequired()
                    .HasColumnName("Order_Unit")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PortionCount).HasColumnName("Portion_Count");

                entity.Property(e => e.PortionUnit)
                    .IsRequired()
                    .HasColumnName("Portion_Unit")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SubInventoryDescription)
                    .IsRequired()
                    .HasColumnName("Sub_Inventory_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost)
                    .HasColumnName("Unit_Cost")
                    .HasColumnType("money");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.DailyInventoryPrepDetail)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Daily_Inventory_Prep_Detail_Location_Codes");

                entity.HasOne(d => d.DailyInventoryPrep)
                    .WithMany(p => p.DailyInventoryPrepDetail)
                    .HasForeignKey(d => new { d.LocationCode, d.PrepId })
                    .HasConstraintName("FK_Daily_Inventory_Prep_Detail_Daily_Inventory_Prep");

                entity.HasOne(d => d.InventoryItems)
                    .WithMany(p => p.DailyInventoryPrepDetail)
                    .HasForeignKey(d => new { d.LocationCode, d.SubInventoryCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Daily_Inventory_Prep_Detail_Inventory_Items");
            });

            modelBuilder.Entity<DailySummary>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.SystemDate })
                    .IsClustered(false);

                entity.ToTable("Daily_Summary");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("System_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AdvertisedDiscounts)
                    .HasColumnName("Advertised_Discounts")
                    .HasColumnType("money");

                entity.Property(e => e.AverageDeliveryTime).HasColumnName("Average_Delivery_Time");

                entity.Property(e => e.AverageLoadTime).HasColumnName("Average_Load_Time");

                entity.Property(e => e.AverageOrderTime).HasColumnName("Average_Order_Time");

                entity.Property(e => e.AverageOtdTime).HasColumnName("Average_OTD_Time");

                entity.Property(e => e.AveragePrice)
                    .HasColumnName("Average_Price")
                    .HasColumnType("money");

                entity.Property(e => e.BadOrders)
                    .HasColumnName("Bad_Orders")
                    .HasColumnType("money");

                entity.Property(e => e.BankDeposits)
                    .HasColumnName("Bank_Deposits")
                    .HasColumnType("money");

                entity.Property(e => e.BottleDeposits)
                    .HasColumnName("Bottle_Deposits")
                    .HasColumnType("money");

                entity.Property(e => e.CarryOut)
                    .HasColumnName("Carry_Out")
                    .HasColumnType("money");

                entity.Property(e => e.ContractLabor)
                    .HasColumnName("Contract_Labor")
                    .HasColumnType("money");

                entity.Property(e => e.Coupons).HasColumnType("money");

                entity.Property(e => e.Credits).HasColumnType("money");

                entity.Property(e => e.DeliveryCompanyCar)
                    .HasColumnName("Delivery_Company_Car")
                    .HasColumnType("money");

                entity.Property(e => e.DeliveryPersonalCar)
                    .HasColumnName("Delivery_Personal_Car")
                    .HasColumnType("money");

                entity.Property(e => e.DineIn)
                    .HasColumnName("Dine_In")
                    .HasColumnType("money");

                entity.Property(e => e.EndingTill)
                    .HasColumnName("Ending_Till")
                    .HasColumnType("money");

                entity.Property(e => e.Food).HasColumnType("money");

                entity.Property(e => e.FoodBought)
                    .HasColumnName("Food_Bought")
                    .HasColumnType("money");

                entity.Property(e => e.FoodSold)
                    .HasColumnName("Food_Sold")
                    .HasColumnType("money");

                entity.Property(e => e.HourlyLabor)
                    .HasColumnName("Hourly_Labor")
                    .HasColumnType("money");

                entity.Property(e => e.InsideLabor)
                    .HasColumnName("Inside_Labor")
                    .HasColumnType("money");

                entity.Property(e => e.Labor).HasColumnType("money");

                entity.Property(e => e.LateOrderCount).HasColumnName("Late_Order_Count");

                entity.Property(e => e.LowerTill)
                    .HasColumnName("Lower_Till")
                    .HasColumnType("money");

                entity.Property(e => e.Manager)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerDiscounts)
                    .HasColumnName("Manager_Discounts")
                    .HasColumnType("money");

                entity.Property(e => e.MasterTotal)
                    .HasColumnName("Master_Total")
                    .HasColumnType("money");

                entity.Property(e => e.MaxOrderNumber).HasColumnName("Max_Order_Number");

                entity.Property(e => e.MaxPricePerOrder)
                    .HasColumnName("Max_Price_Per_Order")
                    .HasColumnType("money");

                entity.Property(e => e.Mileage).HasColumnType("money");

                entity.Property(e => e.MileageAll)
                    .HasColumnName("Mileage_All")
                    .HasColumnType("money");

                entity.Property(e => e.MinOrderNumber).HasColumnName("Min_Order_Number");

                entity.Property(e => e.MinPricePerOrder)
                    .HasColumnName("Min_Price_Per_Order")
                    .HasColumnType("money");

                entity.Property(e => e.NetSales)
                    .HasColumnName("Net_Sales")
                    .HasColumnType("money");

                entity.Property(e => e.NonRoyaltySales)
                    .HasColumnName("Non_Royalty_Sales")
                    .HasColumnType("money");

                entity.Property(e => e.OnTimeOrderCount).HasColumnName("OnTime_Order_Count");

                entity.Property(e => e.OrdersInRange).HasColumnName("Orders_In_Range");

                entity.Property(e => e.OutsideLabor)
                    .HasColumnName("Outside_Labor")
                    .HasColumnType("money");

                entity.Property(e => e.PickUp)
                    .HasColumnName("Pick_Up")
                    .HasColumnType("money");

                entity.Property(e => e.RaiseTill)
                    .HasColumnName("Raise_Till")
                    .HasColumnType("money");

                entity.Property(e => e.RoyaltySales)
                    .HasColumnName("Royalty_Sales")
                    .HasColumnType("money");

                entity.Property(e => e.SalaryLabor)
                    .HasColumnName("Salary_Labor")
                    .HasColumnType("money");

                entity.Property(e => e.SalesTax)
                    .HasColumnName("Sales_Tax")
                    .HasColumnType("money");

                entity.Property(e => e.TillOverride)
                    .HasColumnName("Till_Override")
                    .HasColumnType("money");

                entity.Property(e => e.TotalCpo)
                    .HasColumnName("Total_CPO")
                    .HasColumnType("money");

                entity.Property(e => e.TotalDiscounts)
                    .HasColumnName("Total_Discounts")
                    .HasColumnType("money");

                entity.Property(e => e.TotalMrots)
                    .HasColumnName("Total_MROTS")
                    .HasColumnType("money");

                entity.Property(e => e.TotalOrders).HasColumnName("Total_Orders");

                entity.Property(e => e.TotalSales)
                    .HasColumnName("Total_Sales")
                    .HasColumnType("money");

                entity.Property(e => e.VoidOrders)
                    .HasColumnName("Void_Orders")
                    .HasColumnType("money");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.DailySummary)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Daily_Summary_Location_Codes");
            });

            modelBuilder.Entity<DailySummaryLogData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("daily_summary_log_data");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AdvertisedDiscounts)
                    .HasColumnName("Advertised_Discounts")
                    .HasColumnType("money");

                entity.Property(e => e.AverageDeliveryTime).HasColumnName("Average_Delivery_Time");

                entity.Property(e => e.AverageLoadTime).HasColumnName("Average_Load_Time");

                entity.Property(e => e.AverageOrderTime).HasColumnName("Average_Order_Time");

                entity.Property(e => e.AverageOtdTime).HasColumnName("Average_OTD_Time");

                entity.Property(e => e.AveragePrice)
                    .HasColumnName("Average_Price")
                    .HasColumnType("money");

                entity.Property(e => e.BadOrders)
                    .HasColumnName("Bad_Orders")
                    .HasColumnType("money");

                entity.Property(e => e.BankDeposits)
                    .HasColumnName("Bank_Deposits")
                    .HasColumnType("money");

                entity.Property(e => e.BottleDeposits)
                    .HasColumnName("Bottle_Deposits")
                    .HasColumnType("money");

                entity.Property(e => e.CarryOut)
                    .HasColumnName("Carry_Out")
                    .HasColumnType("money");

                entity.Property(e => e.ContractLabor)
                    .HasColumnName("Contract_Labor")
                    .HasColumnType("money");

                entity.Property(e => e.Coupons).HasColumnType("money");

                entity.Property(e => e.Credits).HasColumnType("money");

                entity.Property(e => e.DeliveryCompanyCar)
                    .HasColumnName("Delivery_Company_Car")
                    .HasColumnType("money");

                entity.Property(e => e.DeliveryPersonalCar)
                    .HasColumnName("Delivery_Personal_Car")
                    .HasColumnType("money");

                entity.Property(e => e.DineIn)
                    .HasColumnName("Dine_In")
                    .HasColumnType("money");

                entity.Property(e => e.EmpCode)
                    .HasColumnName("EMP_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EndingTill)
                    .HasColumnName("Ending_Till")
                    .HasColumnType("money");

                entity.Property(e => e.Food).HasColumnType("money");

                entity.Property(e => e.FoodBought)
                    .HasColumnName("Food_Bought")
                    .HasColumnType("money");

                entity.Property(e => e.FoodSold)
                    .HasColumnName("Food_Sold")
                    .HasColumnType("money");

                entity.Property(e => e.HourlyLabor)
                    .HasColumnName("Hourly_Labor")
                    .HasColumnType("money");

                entity.Property(e => e.InsideLabor)
                    .HasColumnName("Inside_Labor")
                    .HasColumnType("money");

                entity.Property(e => e.Labor).HasColumnType("money");

                entity.Property(e => e.LateOrderCount).HasColumnName("Late_Order_Count");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Logtime)
                    .HasColumnName("LOGTIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Logtype)
                    .HasColumnName("LOGTYPE")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.LowerTill)
                    .HasColumnName("Lower_Till")
                    .HasColumnType("money");

                entity.Property(e => e.Manager)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerDiscounts)
                    .HasColumnName("Manager_Discounts")
                    .HasColumnType("money");

                entity.Property(e => e.MasterTotal)
                    .HasColumnName("Master_Total")
                    .HasColumnType("money");

                entity.Property(e => e.MaxOrderNumber).HasColumnName("Max_Order_Number");

                entity.Property(e => e.MaxPricePerOrder)
                    .HasColumnName("Max_Price_Per_Order")
                    .HasColumnType("money");

                entity.Property(e => e.Mileage).HasColumnType("money");

                entity.Property(e => e.MileageAll)
                    .HasColumnName("Mileage_All")
                    .HasColumnType("money");

                entity.Property(e => e.MinOrderNumber).HasColumnName("Min_Order_Number");

                entity.Property(e => e.MinPricePerOrder)
                    .HasColumnName("Min_Price_Per_Order")
                    .HasColumnType("money");

                entity.Property(e => e.NetSales)
                    .HasColumnName("Net_Sales")
                    .HasColumnType("money");

                entity.Property(e => e.NonRoyaltySales)
                    .HasColumnName("Non_Royalty_Sales")
                    .HasColumnType("money");

                entity.Property(e => e.OnTimeOrderCount).HasColumnName("OnTime_Order_Count");

                entity.Property(e => e.OrdersInRange).HasColumnName("Orders_In_Range");

                entity.Property(e => e.OutsideLabor)
                    .HasColumnName("Outside_Labor")
                    .HasColumnType("money");

                entity.Property(e => e.PickUp)
                    .HasColumnName("Pick_Up")
                    .HasColumnType("money");

                entity.Property(e => e.RaiseTill)
                    .HasColumnName("Raise_Till")
                    .HasColumnType("money");

                entity.Property(e => e.RoyaltySales)
                    .HasColumnName("Royalty_Sales")
                    .HasColumnType("money");

                entity.Property(e => e.SalaryLabor)
                    .HasColumnName("Salary_Labor")
                    .HasColumnType("money");

                entity.Property(e => e.SalesTax)
                    .HasColumnName("Sales_Tax")
                    .HasColumnType("money");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("System_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TillOverride)
                    .HasColumnName("Till_Override")
                    .HasColumnType("money");

                entity.Property(e => e.TotalCpo)
                    .HasColumnName("Total_CPO")
                    .HasColumnType("money");

                entity.Property(e => e.TotalDiscounts)
                    .HasColumnName("Total_Discounts")
                    .HasColumnType("money");

                entity.Property(e => e.TotalMrots)
                    .HasColumnName("Total_MROTS")
                    .HasColumnType("money");

                entity.Property(e => e.TotalOrders).HasColumnName("Total_Orders");

                entity.Property(e => e.TotalSales)
                    .HasColumnName("Total_Sales")
                    .HasColumnType("money");

                entity.Property(e => e.VoidOrders)
                    .HasColumnName("Void_Orders")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<DailySummaryLogData1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("daily_summary_log_data1");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AdvertisedDiscounts)
                    .HasColumnName("Advertised_Discounts")
                    .HasColumnType("money");

                entity.Property(e => e.AverageDeliveryTime).HasColumnName("Average_Delivery_Time");

                entity.Property(e => e.AverageLoadTime).HasColumnName("Average_Load_Time");

                entity.Property(e => e.AverageOrderTime).HasColumnName("Average_Order_Time");

                entity.Property(e => e.AverageOtdTime).HasColumnName("Average_OTD_Time");

                entity.Property(e => e.AveragePrice)
                    .HasColumnName("Average_Price")
                    .HasColumnType("money");

                entity.Property(e => e.BadOrders)
                    .HasColumnName("Bad_Orders")
                    .HasColumnType("money");

                entity.Property(e => e.BankDeposits)
                    .HasColumnName("Bank_Deposits")
                    .HasColumnType("money");

                entity.Property(e => e.BottleDeposits)
                    .HasColumnName("Bottle_Deposits")
                    .HasColumnType("money");

                entity.Property(e => e.CarryOut)
                    .HasColumnName("Carry_Out")
                    .HasColumnType("money");

                entity.Property(e => e.ContractLabor)
                    .HasColumnName("Contract_Labor")
                    .HasColumnType("money");

                entity.Property(e => e.Coupons).HasColumnType("money");

                entity.Property(e => e.Credits).HasColumnType("money");

                entity.Property(e => e.DeliveryCompanyCar)
                    .HasColumnName("Delivery_Company_Car")
                    .HasColumnType("money");

                entity.Property(e => e.DeliveryPersonalCar)
                    .HasColumnName("Delivery_Personal_Car")
                    .HasColumnType("money");

                entity.Property(e => e.DineIn)
                    .HasColumnName("Dine_In")
                    .HasColumnType("money");

                entity.Property(e => e.EmpCode)
                    .HasColumnName("EMP_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EndingTill)
                    .HasColumnName("Ending_Till")
                    .HasColumnType("money");

                entity.Property(e => e.Food).HasColumnType("money");

                entity.Property(e => e.FoodBought)
                    .HasColumnName("Food_Bought")
                    .HasColumnType("money");

                entity.Property(e => e.FoodSold)
                    .HasColumnName("Food_Sold")
                    .HasColumnType("money");

                entity.Property(e => e.HourlyLabor)
                    .HasColumnName("Hourly_Labor")
                    .HasColumnType("money");

                entity.Property(e => e.InsideLabor)
                    .HasColumnName("Inside_Labor")
                    .HasColumnType("money");

                entity.Property(e => e.Labor).HasColumnType("money");

                entity.Property(e => e.LateOrderCount).HasColumnName("Late_Order_Count");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Logtime)
                    .HasColumnName("LOGTIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Logtype)
                    .HasColumnName("LOGTYPE")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.LowerTill)
                    .HasColumnName("Lower_Till")
                    .HasColumnType("money");

                entity.Property(e => e.Manager)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerDiscounts)
                    .HasColumnName("Manager_Discounts")
                    .HasColumnType("money");

                entity.Property(e => e.MasterTotal)
                    .HasColumnName("Master_Total")
                    .HasColumnType("money");

                entity.Property(e => e.MaxOrderNumber).HasColumnName("Max_Order_Number");

                entity.Property(e => e.MaxPricePerOrder)
                    .HasColumnName("Max_Price_Per_Order")
                    .HasColumnType("money");

                entity.Property(e => e.Mileage).HasColumnType("money");

                entity.Property(e => e.MileageAll)
                    .HasColumnName("Mileage_All")
                    .HasColumnType("money");

                entity.Property(e => e.MinOrderNumber).HasColumnName("Min_Order_Number");

                entity.Property(e => e.MinPricePerOrder)
                    .HasColumnName("Min_Price_Per_Order")
                    .HasColumnType("money");

                entity.Property(e => e.NetSales)
                    .HasColumnName("Net_Sales")
                    .HasColumnType("money");

                entity.Property(e => e.NonRoyaltySales)
                    .HasColumnName("Non_Royalty_Sales")
                    .HasColumnType("money");

                entity.Property(e => e.OnTimeOrderCount).HasColumnName("OnTime_Order_Count");

                entity.Property(e => e.OrdersInRange).HasColumnName("Orders_In_Range");

                entity.Property(e => e.OutsideLabor)
                    .HasColumnName("Outside_Labor")
                    .HasColumnType("money");

                entity.Property(e => e.PickUp)
                    .HasColumnName("Pick_Up")
                    .HasColumnType("money");

                entity.Property(e => e.RaiseTill)
                    .HasColumnName("Raise_Till")
                    .HasColumnType("money");

                entity.Property(e => e.RoyaltySales)
                    .HasColumnName("Royalty_Sales")
                    .HasColumnType("money");

                entity.Property(e => e.SalaryLabor)
                    .HasColumnName("Salary_Labor")
                    .HasColumnType("money");

                entity.Property(e => e.SalesTax)
                    .HasColumnName("Sales_Tax")
                    .HasColumnType("money");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("System_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TillOverride)
                    .HasColumnName("Till_Override")
                    .HasColumnType("money");

                entity.Property(e => e.TotalCpo)
                    .HasColumnName("Total_CPO")
                    .HasColumnType("money");

                entity.Property(e => e.TotalDiscounts)
                    .HasColumnName("Total_Discounts")
                    .HasColumnType("money");

                entity.Property(e => e.TotalMrots)
                    .HasColumnName("Total_MROTS")
                    .HasColumnType("money");

                entity.Property(e => e.TotalOrders).HasColumnName("Total_Orders");

                entity.Property(e => e.TotalSales)
                    .HasColumnName("Total_Sales")
                    .HasColumnType("money");

                entity.Property(e => e.VoidOrders)
                    .HasColumnName("Void_Orders")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<DatabaseEventLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_DatabaseEventLOG ");

                entity.ToTable("DatabaseEventLOG");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.DatabaseName).HasMaxLength(100);

                entity.Property(e => e.EventDataXml)
                    .HasColumnName("EventDataXML")
                    .HasColumnType("xml");

                entity.Property(e => e.EventDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EventType).HasMaxLength(100);

                entity.Property(e => e.HostName).HasMaxLength(100);

                entity.Property(e => e.Ipadderss)
                    .HasColumnName("IPAdderss")
                    .HasMaxLength(25);

                entity.Property(e => e.LoginName).HasMaxLength(100);

                entity.Property(e => e.ObjectName).HasMaxLength(250);

                entity.Property(e => e.ObjectType).HasMaxLength(100);

                entity.Property(e => e.PostTime).HasColumnType("datetime");

                entity.Property(e => e.ProgramName).HasMaxLength(500);

                entity.Property(e => e.SchemaName).HasMaxLength(100);

                entity.Property(e => e.ServerName).HasMaxLength(100);

                entity.Property(e => e.Spid)
                    .HasColumnName("SPID")
                    .HasMaxLength(10);

                entity.Property(e => e.Tsqlcommand).HasColumnName("TSQLCommand");

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<DateIntervalTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.DateIntervalCode });

                entity.ToTable("Date_Interval_Types");

                entity.HasIndex(e => e.ApproximateDays)
                    .HasName("Approximate_Days");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DateIntervalCode)
                    .HasColumnName("Date_Interval_Code")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ApproximateDays).HasColumnName("Approximate_Days");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .IsRequired()
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.DateIntervalTypes)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Date_Interval_Types_Location_Codes");
            });

            modelBuilder.Entity<DayOfWeekValues>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.DayCode });

                entity.ToTable("Day_Of_Week_Values");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.DayCode).HasColumnName("Day_Code");

                entity.Property(e => e.EnglishDescription)
                    .HasColumnName("English_Description")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDescription)
                    .HasColumnName("Modified_Description")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.DayOfWeekValues)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Day_Of_Week_Values_Location_Codes");
            });

            modelBuilder.Entity<DbManagerLogger>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DB_Manager_Logger");

                entity.Property(e => e.Added)
                    .HasColumnName("added")
                    .HasColumnType("datetime");

                entity.Property(e => e.ErrorMessage)
                    .HasColumnName("Error_Message")
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasColumnName("File_Name")
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DefaultCurrencyHistory>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.DefaultCurrency, e.Added })
                    .IsClustered(false);

                entity.ToTable("Default_Currency_History");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultCurrency)
                    .HasColumnName("Default_Currency")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.DefaultCurrencyHistory)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Default_Currency_History_Location_Codes");
            });

            modelBuilder.Entity<Deliveries>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.DeliveryId })
                    .IsClustered(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryId).HasColumnName("Delivery_ID");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AlternateVendorName)
                    .HasColumnName("Alternate_Vendor_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryAmount)
                    .HasColumnName("Delivery_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.DeliveryCharge)
                    .HasColumnName("Delivery_Charge")
                    .HasColumnType("money");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnName("Delivery_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeliveryTax)
                    .HasColumnName("Delivery_Tax")
                    .HasColumnType("money");

                entity.Property(e => e.DeliveryTypeCode).HasColumnName("Delivery_Type_Code");

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice_Number")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IsPrint).HasDefaultValueSql("((0))");

                entity.Property(e => e.ListVendorCode)
                    .HasColumnName("List_Vendor_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PosId)
                    .HasColumnName("POS_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StnPost).HasColumnName("STN_POST");

                entity.Property(e => e.VendorCode)
                    .HasColumnName("Vendor_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.Deliveries)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Deliveries_Location_Codes");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.Deliveries)
                    .HasForeignKey(d => new { d.LocationCode, d.VendorCode })
                    .HasConstraintName("FK_Deliveries_Vendor");
            });

            modelBuilder.Entity<DeliveriesTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DELIVERIES_TMP");

                entity.Property(e => e.Added)
                    .HasColumnName("ADDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("ADDED_BY")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AlternateVendorName)
                    .HasColumnName("ALTERNATE_VENDOR_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryAmount)
                    .HasColumnName("DELIVERY_AMOUNT")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DeliveryCharge)
                    .HasColumnName("DELIVERY_CHARGE")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnName("DELIVERY_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeliveryId).HasColumnName("DELIVERY_ID");

                entity.Property(e => e.DeliveryTax)
                    .HasColumnName("DELIVERY_TAX")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DeliveryTypeCode).HasColumnName("DELIVERY_TYPE_CODE");

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("INVOICE_NUMBER")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ListVendorCode)
                    .HasColumnName("LIST_VENDOR_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("LOCATION_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCode)
                    .HasColumnName("VENDOR_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeliveryAmount>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.DeliveryId, e.InventoryCode })
                    .IsClustered(false);

                entity.ToTable("Delivery_Amount");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryId).HasColumnName("Delivery_ID");

                entity.Property(e => e.InventoryCode)
                    .HasColumnName("Inventory_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("money");

                entity.Property(e => e.UnitCost)
                    .HasColumnName("Unit_Cost")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.DeliveryAmount)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Delivery_Amount_Location_Codes");

                entity.HasOne(d => d.Deliveries)
                    .WithMany(p => p.DeliveryAmountNavigation)
                    .HasForeignKey(d => new { d.LocationCode, d.DeliveryId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Delivery_Amount_Deliveries");

                entity.HasOne(d => d.InventoryItems)
                    .WithMany(p => p.DeliveryAmount)
                    .HasForeignKey(d => new { d.LocationCode, d.InventoryCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Delivery_Amount_Inventory_Items");
            });

            modelBuilder.Entity<DeliveryAmountTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DELIVERY_AMOUNT_TMP");

                entity.Property(e => e.DeliveryId).HasColumnName("DELIVERY_ID");

                entity.Property(e => e.InventoryCode)
                    .HasColumnName("INVENTORY_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("LOCATION_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity)
                    .HasColumnName("QUANTITY")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.UnitCost)
                    .HasColumnName("UNIT_COST")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<DeliveryFee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Delivery_Fee");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryCharge)
                    .HasColumnName("Delivery_Charge")
                    .HasColumnType("money");

                entity.Property(e => e.EndTime).HasColumnName("End_Time");

                entity.Property(e => e.LastModify)
                    .HasColumnName("Last_Modify")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.MaxValue)
                    .HasColumnName("Max_Value")
                    .HasColumnType("money");

                entity.Property(e => e.MinValue)
                    .HasColumnName("Min_Value")
                    .HasColumnType("money");

                entity.Property(e => e.StartTime).HasColumnName("Start_Time");

                entity.Property(e => e.StatusCode).HasColumnName("Status_Code");
            });

            modelBuilder.Entity<DeliveryFeeExemptedItem>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MenuCode, e.SizeCode });

                entity.ToTable("Delivery_Fee_Exempted_Item");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SizeCode)
                    .HasColumnName("Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DelApply).HasColumnName("DEL_Apply");

                entity.Property(e => e.LastModify)
                    .HasColumnName("Last_Modify")
                    .HasColumnType("datetime");

                entity.Property(e => e.MovApply).HasColumnName("MOV_Apply");

                entity.HasOne(d => d.MenuItemSizes)
                    .WithOne(p => p.DeliveryFeeExemptedItem)
                    .HasForeignKey<DeliveryFeeExemptedItem>(d => new { d.LocationCode, d.MenuCode, d.SizeCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Delivery_Fee_Exempted_Item_Menu_Item_Sizes");
            });

            modelBuilder.Entity<DeliveryFeeMov>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderTypeCode, e.StartTime, e.EndTime });

                entity.ToTable("Delivery_Fee_MOV");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTypeCode)
                    .HasColumnName("Order_Type_Code")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnName("Start_Time");

                entity.Property(e => e.EndTime).HasColumnName("End_Time");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LastModify)
                    .HasColumnName("Last_Modify")
                    .HasColumnType("datetime");

                entity.Property(e => e.MinOrderValue)
                    .HasColumnName("Min_Order_Value")
                    .HasColumnType("money");

                entity.Property(e => e.StatusCode).HasColumnName("Status_Code");
            });

            modelBuilder.Entity<DeliveryTypeCodes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.DeliveryTypeCode });

                entity.ToTable("Delivery_Type_Codes");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DeliveryTypeCode).HasColumnName("Delivery_Type_Code");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.DeliveryTypeCodes)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Delivery_Type_Codes_Location_Codes");
            });

            modelBuilder.Entity<DeviceInterfaceTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.DeviceInterfaceTypeCode });

                entity.ToTable("Device_Interface_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DeviceInterfaceTypeCode).HasColumnName("Device_Interface_Type_Code");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DriverTpeLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Driver_TPE_Log");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LogType)
                    .HasColumnName("Log_Type")
                    .HasMaxLength(50);

                entity.Property(e => e.RetryCount)
                    .HasColumnName("Retry_Count")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId).HasColumnName("Transaction_Id");
            });

            modelBuilder.Entity<DriverTrackExeInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Driver_Track_ExeInfo");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ExeId).HasColumnName("Exe_ID");

                entity.Property(e => e.ExeName)
                    .HasColumnName("Exe_Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FieldFilter)
                    .HasColumnName("Field_Filter")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TimeOut).HasColumnName("Time_Out");
            });

            modelBuilder.Entity<DriverTrackId>(entity =>
            {
                entity.ToTable("Driver_Track_Id");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.ApproveState)
                    .HasColumnName("Approve_State")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AsignDateTime)
                    .HasColumnName("Asign_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.AssignType)
                    .HasColumnName("Assign_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DriverId)
                    .HasColumnName("Driver_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RfId)
                    .HasColumnName("Rf_id")
                    .HasMaxLength(50);

                entity.Property(e => e.RfTimeStamp)
                    .HasColumnName("Rf_TimeStamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.StatusCode)
                    .HasColumnName("Status_code")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDateTime)
                    .HasColumnName("Update_DateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DriverTrackOrderNumber>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Driver_Track_OrderNumber");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AfterExeInvokeTimeStamp)
                    .HasColumnName("AfterExeInvoke_TimeStamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.BeforeExeInvokeTimeStamp)
                    .HasColumnName("BeforeExeInvoke_TimeStamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DriverId)
                    .HasColumnName("Driver_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ErrorMessage).HasColumnName("Error_message");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LogType)
                    .HasColumnName("Log_Type")
                    .HasMaxLength(50);

                entity.Property(e => e.RfId)
                    .HasColumnName("Rf_id")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId).HasColumnName("Transaction_Id");
            });

            modelBuilder.Entity<DriverTrackOrderNumberDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Driver_Track_OrderNumber_Details");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Assign).HasMaxLength(50);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber)
                    .IsRequired()
                    .HasColumnName("Order_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.TpeMessage)
                    .HasColumnName("TPE_message")
                    .HasMaxLength(500);

                entity.Property(e => e.TransactionId).HasColumnName("Transaction_Id");
            });

            modelBuilder.Entity<DriverTrackReturnOrderNumber>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Driver_Track_Return_OrderNumber");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AfterExeInvokeTimeStamp)
                    .HasColumnName("AfterExeInvoke_TimeStamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.BeforeExeInvokeTimeStamp)
                    .HasColumnName("BeforeExeInvoke_TimeStamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DriverId)
                    .HasColumnName("Driver_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ErrorMessage).HasColumnName("Error_message");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LogType)
                    .HasColumnName("Log_Type")
                    .HasMaxLength(50);

                entity.Property(e => e.RfId)
                    .HasColumnName("Rf_id")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId).HasColumnName("Transaction_Id");
            });

            modelBuilder.Entity<DriverTrackReturnOrderNumberDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Driver_Track_Return_OrderNumber_Details");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Assign).HasMaxLength(50);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber)
                    .IsRequired()
                    .HasColumnName("Order_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.TpeMessage)
                    .HasColumnName("TPE_message")
                    .HasMaxLength(500);

                entity.Property(e => e.TransactionId).HasColumnName("Transaction_Id");
            });

            modelBuilder.Entity<Dual>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Junk)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DuplicatePrint>(entity =>
            {
                entity.HasKey(e => e.PrintId);

                entity.Property(e => e.PrintId).HasColumnName("Print_ID");

                entity.Property(e => e.EmployeeCode)
                    .HasColumnName("Employee_Code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.PrintDate)
                    .HasColumnName("Print_Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.EmployeeCode })
                    .HasName("aaaaaEmployee_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_CodesEmployee");

                entity.HasIndex(e => e.PayTypeCode)
                    .HasName("Pay_TypeEmployee");

                entity.HasIndex(e => e.StatusCode)
                    .HasName("Status_CodesEmployee");

                entity.HasIndex(e => new { e.UserId, e.LocationCode })
                    .HasName("User_ID")
                    .IsUnique();

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCode)
                    .HasColumnName("Employee_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AdminLevel).HasColumnName("Admin_Level");

                entity.Property(e => e.AllowBiometricAuth).HasColumnName("Allow_Biometric_Auth");

                entity.Property(e => e.AllowKeyboardAuth).HasColumnName("Allow_Keyboard_Auth");

                entity.Property(e => e.AllowMsrAuth).HasColumnName("Allow_MSR_Auth");

                entity.Property(e => e.CarInspection)
                    .HasColumnName("Car_Inspection")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CarRegistration)
                    .HasColumnName("Car_Registration")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DlExpiration)
                    .HasColumnName("DL_Expiration")
                    .HasColumnType("datetime");

                entity.Property(e => e.DlNumber)
                    .HasColumnName("DL_Number")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DlRegion)
                    .HasColumnName("DL_Region")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContact)
                    .HasColumnName("Emergency_Contact")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyPhone)
                    .HasColumnName("Emergency_Phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmpType)
                    .HasColumnName("Emp_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First_Name")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FoodHandlerExpiration)
                    .HasColumnName("Food_Handler_Expiration")
                    .HasColumnType("datetime");

                entity.Property(e => e.FoodHandlerLicense)
                    .HasColumnName("Food_Handler_License")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GovernmentId)
                    .HasColumnName("Government_ID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.HireDate)
                    .HasColumnName("Hire_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsExpDate)
                    .HasColumnName("Ins_Exp_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InspectionDate)
                    .HasColumnName("Inspection_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsuranceCo)
                    .HasColumnName("Insurance_Co")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsurancePolicy)
                    .HasColumnName("Insurance_Policy")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("Last_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.LicensePlate)
                    .HasColumnName("License_Plate")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasColumnName("Middle_Name")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MvrCheckDate)
                    .HasColumnName("MVR_Check_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MvrPass)
                    .HasColumnName("MVR_Pass")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OldPassword)
                    .HasColumnName("Old_Password")
                    .HasMaxLength(3000);

                entity.Property(e => e.Password).HasMaxLength(3000);

                entity.Property(e => e.PasswordExpiryDate)
                    .HasColumnName("Password_ExpiryDate")
                    .HasColumnType("date");

                entity.Property(e => e.PayTypeCode)
                    .HasColumnName("Pay_Type_Code")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostalCode)
                    .HasColumnName("Postal_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RegExpiration)
                    .HasColumnName("Reg_Expiration")
                    .HasColumnType("datetime");

                entity.Property(e => e.Region)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ResetPassword).HasColumnName("Reset_Password");

                entity.Property(e => e.RightHanded)
                    .HasColumnName("Right_Handed")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StatusCode).HasColumnName("Status_Code");

                entity.Property(e => e.SyncTime)
                    .HasColumnName("Sync_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TerminationDate)
                    .HasColumnName("Termination_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Track1Data)
                    .HasColumnName("Track1_Data")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Track2Data)
                    .HasColumnName("Track2_Data")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Track3Data)
                    .HasColumnName("Track3_Data")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("User_ID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Location_Codes");
            });

            modelBuilder.Entity<EmployeeCashDrop>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.EmployeeCode, e.SystemDate, e.Added })
                    .IsClustered(false);

                entity.ToTable("Employee_Cash_Drop");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => new { e.LocationCode, e.EmployeeCode })
                    .HasName("EmployeeEmployee_Cash_Drop");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCode)
                    .HasColumnName("Employee_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("System_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.EmployeeCashDrop)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Cash_Drop_Location_Codes");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeCashDrop)
                    .HasForeignKey(d => new { d.LocationCode, d.EmployeeCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Cash_Drop_Employee");
            });

            modelBuilder.Entity<EmployeeClass>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.EmployeeCode, e.SecurityClassCode })
                    .IsClustered(false);

                entity.ToTable("Employee_Class");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => e.SecurityClassCode)
                    .HasName("Class_Type_ID");

                entity.HasIndex(e => new { e.LocationCode, e.EmployeeCode })
                    .HasName("EmployeeEmployee_Class");

                entity.HasIndex(e => new { e.LocationCode, e.SecurityClassCode })
                    .HasName("Security_ClassEmployee_Class");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCode)
                    .HasColumnName("Employee_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityClassCode)
                    .HasColumnName("Security_Class_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeClassOverride>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.EmployeeCode, e.SecurityClassCode, e.VbMenuItemId })
                    .IsClustered(false);

                entity.ToTable("Employee_Class_Override");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => e.SecurityClassCode)
                    .HasName("Security_Class_ID");

                entity.HasIndex(e => e.VbMenuItemId)
                    .HasName("VB_Menu_ItemsEmployee_Class_Override");

                entity.HasIndex(e => new { e.LocationCode, e.EmployeeCode, e.SecurityClassCode })
                    .HasName("Employee_ClassEmployee_Class_Override");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCode)
                    .HasColumnName("Employee_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityClassCode)
                    .HasColumnName("Security_Class_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VbMenuItemId).HasColumnName("VB_Menu_Item_ID");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Enabled).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<EmployeeFingerprint>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.EmployeeCode })
                    .IsClustered(false);

                entity.ToTable("Employee_Fingerprint");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCode)
                    .HasColumnName("Employee_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FingerprintTemplate1)
                    .IsRequired()
                    .HasColumnName("Fingerprint_Template1")
                    .HasColumnType("text");

                entity.Property(e => e.FingerprintTemplate2)
                    .HasColumnName("Fingerprint_Template2")
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FingerprintTemplate3)
                    .HasColumnName("Fingerprint_Template3")
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FingerprintTemplate4)
                    .HasColumnName("Fingerprint_Template4")
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<EmployeePosition>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.EmployeeCode, e.PositionCode })
                    .IsClustered(false);

                entity.ToTable("Employee_Position");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => e.PositionCode)
                    .HasName("Position_ID");

                entity.HasIndex(e => new { e.LocationCode, e.EmployeeCode })
                    .HasName("EmployeeEmployee_Position");

                entity.HasIndex(e => new { e.LocationCode, e.PositionCode })
                    .HasName("PositionEmployee_Position");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCode)
                    .HasColumnName("Employee_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PositionCode)
                    .HasColumnName("Position_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");

                entity.Property(e => e.MileageRate1)
                    .HasColumnName("Mileage_Rate_1")
                    .HasColumnType("money");

                entity.Property(e => e.MileageRate2)
                    .HasColumnName("Mileage_Rate_2")
                    .HasColumnType("money");

                entity.Property(e => e.PayRate)
                    .HasColumnName("Pay_Rate")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<EodDataSyncLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EOD_DATA_SyncLog");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessError)
                    .HasColumnName("process_error")
                    .IsUnicode(false);

                entity.Property(e => e.ProcessFlag)
                    .HasColumnName("Process_flag")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ProcessName)
                    .HasColumnName("Process_Name")
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("System_Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<EodDataSyncMailfailover>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EOD_DATA_SyncMailfailover");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MailMessage)
                    .HasColumnName("Mail_Message")
                    .IsUnicode(false);

                entity.Property(e => e.MailSendFlag)
                    .HasColumnName("Mail_Send_Flag")
                    .HasColumnType("numeric(1, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("System_Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<EodError>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EodDate).HasColumnType("datetime");

                entity.Property(e => e.ErrorLine).HasColumnName("ERROR_LINE");

                entity.Property(e => e.ErrorMessage)
                    .HasColumnName("ERROR_MESSAGE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorNumber).HasColumnName("ERROR_NUMBER");

                entity.Property(e => e.ErrorProcedure)
                    .HasColumnName("ERROR_PROCEDURE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorSeverity)
                    .HasColumnName("ERROR_SEVERITY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorState)
                    .HasColumnName("ERROR_STATE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EodLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EOD_Log");

                entity.Property(e => e.EmployeeCode)
                    .HasColumnName("Employee_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EodEndDatetime)
                    .HasColumnName("EOD_End_Datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.EodFlagReasonText)
                    .IsRequired()
                    .HasColumnName("EOD_Flag_Reason_Text")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EodStartDatetime)
                    .HasColumnName("EOD_Start_Datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.EodrunningFlag)
                    .HasColumnName("EODRunning_Flag")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.FlagChangeDatetime)
                    .HasColumnName("Flag_change_Datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("System_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<EodprocessLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EODProcessLOG");

                entity.Property(e => e.CountNumber)
                    .HasColumnName("Count_number")
                    .HasColumnType("numeric(10, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasColumnName("Employee_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocationDate)
                    .HasColumnName("Location_date")
                    .HasColumnType("date")
                    .HasDefaultValueSql("('01-jan-1900')");

                entity.Property(e => e.ProcessName)
                    .IsRequired()
                    .HasColumnName("Process_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProcessStatus)
                    .IsRequired()
                    .HasColumnName("Process_status")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("System_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01-jan-1900')");
            });

            modelBuilder.Entity<EodpromptMessage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EODPromptMessage");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PrompMsg).IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("System_Date")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<EodvarianceLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EODVarianceLog");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.ExceptionMessage).IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("System_Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Errors>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.SequenceNumber })
                    .IsClustered(false);

                entity.HasIndex(e => e.Added)
                    .HasName("Added");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Error).HasDefaultValueSql("((0))");

                entity.Property(e => e.Object)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubRoutine)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExtraScriptDday>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ExtraScriptDDay");

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.StepNumber)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<ExtraScriptLog>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.StepNumber)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<FileLocationCodes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.FileLocationCode })
                    .HasName("PK_File_Location_Type");

                entity.ToTable("File_Location_Codes");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FileLocationCode).HasColumnName("File_Location_Code");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FinancialReportDataSources>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.DataSource })
                    .HasName("PK_Financial_Report_Data_Source");

                entity.ToTable("Financial_Report_Data_Sources");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataSource).HasColumnName("Data_Source");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FinancialReportDataSourcesDescriptions>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.DataSource })
                    .HasName("PK_Financial_Report_Data_Source_Descriptions");

                entity.ToTable("Financial_Report_Data_Sources_Descriptions");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.DataSource).HasColumnName("Data_Source");

                entity.Property(e => e.DefaultDescription)
                    .HasColumnName("Default_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDescription)
                    .HasColumnName("Modified_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FinancialReportDesignDetails>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.FrDesignId, e.FrLineId });

                entity.ToTable("Financial_Report_Design_Details");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FrDesignId).HasColumnName("FR_Design_ID");

                entity.Property(e => e.FrLineId).HasColumnName("FR_Line_ID");

                entity.Property(e => e.ActualDataAmount)
                    .HasColumnName("Actual_Data_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.ActualDataSource).HasColumnName("Actual_Data_Source");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetDataAmount)
                    .HasColumnName("Budget_Data_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.BudgetDataSource).HasColumnName("Budget_Data_Source");

                entity.Property(e => e.DataFormatType).HasColumnName("Data_Format_Type");

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");

                entity.Property(e => e.FrAccountCode)
                    .HasColumnName("FR_Account_Code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FrAccountDescription)
                    .HasColumnName("FR_Account_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IndentionLevel).HasColumnName("Indention_Level");

                entity.Property(e => e.LabelFormatType).HasColumnName("Label_Format_Type");

                entity.Property(e => e.LineType).HasColumnName("Line_Type");
            });

            modelBuilder.Entity<FinancialReportDesigns>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.FrDesignId });

                entity.ToTable("Financial_Report_Designs");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FrDesignId).HasColumnName("FR_Design_ID");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FinancialReportType)
                    .HasColumnName("Financial_Report_Type")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FrDesignDescription)
                    .HasColumnName("FR_Design_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FinancialReportDetails>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.FinancialReportId, e.FinancialReportLineId });

                entity.ToTable("Financial_Report_Details");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FinancialReportId).HasColumnName("Financial_Report_ID");

                entity.Property(e => e.FinancialReportLineId).HasColumnName("Financial_Report_Line_ID");

                entity.Property(e => e.ActualAmount)
                    .HasColumnName("Actual_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.ActualPercent)
                    .HasColumnName("Actual_Percent")
                    .HasColumnType("money");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetAmount)
                    .HasColumnName("Budget_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.BudgetPercent)
                    .HasColumnName("Budget_Percent")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<FinancialReportFormatTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.FormatType });

                entity.ToTable("Financial_Report_Format_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FormatType).HasColumnName("Format_Type");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FinancialReportFormatTypesDescriptions>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.FormatType });

                entity.ToTable("Financial_Report_Format_Types_Descriptions");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.FormatType).HasColumnName("Format_Type");

                entity.Property(e => e.DefaultDescription)
                    .HasColumnName("Default_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDescription)
                    .HasColumnName("Modified_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FinancialReportLineTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LineType });

                entity.ToTable("Financial_Report_Line_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LineType).HasColumnName("Line_Type");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FinancialReportLineTypesDescriptions>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.LineType });

                entity.ToTable("Financial_Report_Line_Types_Descriptions");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.LineType).HasColumnName("Line_Type");

                entity.Property(e => e.DefaultDescription)
                    .HasColumnName("Default_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDescription)
                    .HasColumnName("Modified_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FinancialReportLinks>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.FrDesignId, e.FrParentLineId, e.FrLinkId, e.FrLinkType });

                entity.ToTable("Financial_Report_Links");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FrDesignId).HasColumnName("FR_Design_ID");

                entity.Property(e => e.FrParentLineId).HasColumnName("FR_Parent_Line_ID");

                entity.Property(e => e.FrLinkId).HasColumnName("FR_Link_ID");

                entity.Property(e => e.FrLinkType).HasColumnName("FR_Link_Type");

                entity.Property(e => e.AccountId).HasColumnName("Account_ID");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FrChildLineId).HasColumnName("FR_Child_Line_ID");
            });

            modelBuilder.Entity<FinancialReportTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.FinancialReportType });

                entity.ToTable("Financial_Report_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FinancialReportType).HasColumnName("Financial_Report_Type");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FinancialReportTypesDescriptions>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.FinancialReportType });

                entity.ToTable("Financial_Report_Types_Descriptions");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.FinancialReportType).HasColumnName("Financial_Report_Type");

                entity.Property(e => e.DefaultDescription)
                    .HasColumnName("Default_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDescription)
                    .HasColumnName("Modified_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FinancialReports>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.FinancialReportId });

                entity.ToTable("Financial_Reports");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FinancialReportId).HasColumnName("Financial_Report_ID");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BeginDate)
                    .HasColumnName("Begin_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasColumnName("End_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FinancialReportDescription)
                    .IsRequired()
                    .HasColumnName("Financial_Report_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FrDesignId).HasColumnName("FR_Design_ID");
            });

            modelBuilder.Entity<FormFields>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.Form, e.FieldName })
                    .HasName("aaaaaForm_Fields_PK")
                    .IsClustered(false);

                entity.ToTable("Form_Fields");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.Form)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldName)
                    .HasColumnName("Field_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishText)
                    .HasColumnName("English_Text")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishToolTip)
                    .HasColumnName("English_ToolTip")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedText)
                    .HasColumnName("Modified_Text")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedToolTip)
                    .HasColumnName("Modified_ToolTip")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GiftCardSettings>(entity =>
            {
                entity.HasKey(e => e.LocationCode)
                    .IsClustered(false);

                entity.ToTable("Gift_Card_Settings");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ActivationOnVoid).HasColumnName("Activation_On_Void");

                entity.Property(e => e.CashBackAllowance)
                    .HasColumnName("Cash_Back_Allowance")
                    .HasColumnType("money");

                entity.Property(e => e.DaysToKeepGiftOrderHistory).HasColumnName("Days_To_Keep_Gift_Order_History");

                entity.Property(e => e.GiftCardProcessing).HasColumnName("Gift_Card_Processing");

                entity.Property(e => e.InFileLocation)
                    .HasColumnName("In_File_Location")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LoadAccountId).HasColumnName("Load_Account_ID");

                entity.Property(e => e.LogProcessorCommunications).HasColumnName("Log_Processor_Communications");

                entity.Property(e => e.MaxCardNumberLength)
                    .HasColumnName("Max_Card_Number_Length")
                    .HasDefaultValueSql("((20))");

                entity.Property(e => e.MerchantNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MinCardNumberLength)
                    .HasColumnName("Min_Card_Number_Length")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OutFileLocation)
                    .HasColumnName("Out_File_Location")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password).HasMaxLength(3000);

                entity.Property(e => e.PortId)
                    .HasColumnName("PortID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Processor)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RedemptionAccountId).HasColumnName("Redemption_Account_ID");

                entity.Property(e => e.ShowItemsOnSalesReports).HasColumnName("Show_Items_On_Sales_Reports");

                entity.Property(e => e.ThirdPartyDllFileLocation)
                    .HasColumnName("Third_Party_DLL_File_Location")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GiftCardTransactionTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.TransactionType })
                    .IsClustered(false);

                entity.ToTable("Gift_Card_Transaction_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType).HasColumnName("Transaction_Type");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GiftCardTransactionTypesDescriptions>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.TransactionType })
                    .IsClustered(false);

                entity.ToTable("Gift_Card_Transaction_Types_Descriptions");

                entity.HasIndex(e => new { e.LocationCode, e.LanguageCode })
                    .HasName("IX_Gift_Card_Transaction_Types_Descriptions");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.TransactionType).HasColumnName("Transaction_Type");

                entity.Property(e => e.DefaultDescription)
                    .IsRequired()
                    .HasColumnName("Default_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDescription)
                    .IsRequired()
                    .HasColumnName("Modified_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GiftCards>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.CreditCardId, e.AccountNumber });

                entity.ToTable("Gift_Cards");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardId).HasColumnName("Credit_Card_ID");

                entity.Property(e => e.AccountNumber)
                    .HasColumnName("Account_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActivationCode)
                    .IsRequired()
                    .HasColumnName("Activation_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActivationDate)
                    .HasColumnName("Activation_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ExpirationDate)
                    .HasColumnName("Expiration_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PresentAmount)
                    .HasColumnName("Present_Amount")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<GovernmentReceipts>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.GovernmentId })
                    .IsClustered(false);

                entity.ToTable("Government_Receipts");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.GovernmentId).HasColumnName("Government_ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishDescription)
                    .IsRequired()
                    .HasColumnName("English_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GstAudit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GST_Audit");

                entity.Property(e => e.CategoriesCount)
                    .HasColumnName("Categories_Count")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CityCount)
                    .HasColumnName("City_Count")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GstApplicable)
                    .HasColumnName("GST_Applicable")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GstInventoryMaster)
                    .HasColumnName("GST_Inventory_Master")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GstMrpItemsBasePrice)
                    .HasColumnName("GST_MRP_Items_Base_Price")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GstNonAcStoreMaster)
                    .HasColumnName("GST_Non_AC_Store_Master")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GstNonGstComplianceStoreMaster)
                    .HasColumnName("GST_Non_GST_Compliance_Store_Master")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GstTaxCategoryMaster)
                    .HasColumnName("GST_Tax_Category_Master")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GstTaxCityMaster)
                    .HasColumnName("GST_Tax_City_Master")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GstTaxCityMasterIst)
                    .HasColumnName("GST_Tax_City_Master_IST")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GstTaxNameMaster)
                    .HasColumnName("GST_Tax_Name_Master")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvTaxCount)
                    .HasColumnName("Inv_Tax_Count")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvTaxCountGstinventory12Per)
                    .HasColumnName("Inv_Tax_Count_GSTInventory12Per")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvTaxCountGstinventory18Per)
                    .HasColumnName("Inv_Tax_Count_GSTInventory18Per")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvTaxCountGstinventory2812Per)
                    .HasColumnName("Inv_Tax_Count_GSTInventory2812Per")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvTaxCountGstinventory28Per)
                    .HasColumnName("Inv_Tax_Count_GSTInventory28Per")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvTaxCountGstinventory5Per)
                    .HasColumnName("Inv_Tax_Count_GSTInventory5Per")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IstCityStateDetl)
                    .HasColumnName("IST_CITY_STATE_DETL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MenuTaxCount)
                    .HasColumnName("Menu_Tax_Count")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MenuTaxCountGstnonPreparedBeverages)
                    .HasColumnName("Menu_Tax_Count_GSTNonPreparedBeverages")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MenuTaxCountGstnonPreparedOthers)
                    .HasColumnName("Menu_Tax_Count_GSTNonPreparedOthers")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MenuTaxCountGstpreparedBeverages)
                    .HasColumnName("Menu_Tax_Count_GSTPreparedBeverages")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MenuTaxCountGstpreparedFood)
                    .HasColumnName("Menu_Tax_Count_GSTPreparedFood")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptMessageBottom)
                    .HasColumnName("Receipt_Message_Bottom")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptMessageTop)
                    .HasColumnName("Receipt_Message_Top")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.RegionCount)
                    .HasColumnName("Region_Count")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxNameRecords)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UseUserDefinedTax1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UseUserDefinedTax2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UseUserDefinedTax3)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UseUserDefinedTax4)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserDefinedTax1CarryOut)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserDefinedTax1Delivery)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserDefinedTax1Description)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserDefinedTax1DineIn)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserDefinedTax1Pickup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserDefinedTax2CarryOut)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserDefinedTax2Delivery)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserDefinedTax2Description)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserDefinedTax2DineIn)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserDefinedTax2Pickup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserDefinedTax3CarryOut)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserDefinedTax3Delivery)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserDefinedTax3Description)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserDefinedTax3DineIn)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserDefinedTax3Pickup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserDefinedTax4CarryOut)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserDefinedTax4Delivery)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserDefinedTax4Description)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserDefinedTax4DineIn)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserDefinedTax4Pickup)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GstCity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GST_City");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CityCode).HasColumnName("City_Code");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("City_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RegionCode).HasColumnName("Region_Code");

                entity.Property(e => e.TaxRate1).HasColumnName("Tax_Rate1");

                entity.Property(e => e.TaxRate2).HasColumnName("Tax_Rate2");
            });

            modelBuilder.Entity<GstHsnSac>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.HsnSacCode });

                entity.ToTable("GST_HSN_SAC");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.HsnSacCode)
                    .HasColumnName("HSN_SAC_Code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HsnSacAbbr)
                    .HasColumnName("HSN_SAC_Abbr")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .IsRequired()
                    .HasColumnName("Status_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GstHsnSacMenuItem>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MenuCode, e.HsnSacCode })
                    .HasName("GST_HSN_SAC_Menu_Item_PK")
                    .IsClustered(false);

                entity.ToTable("GST_HSN_SAC_Menu_Item");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.HsnSacCode)
                    .HasColumnName("HSN_SAC_Code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode).HasColumnName("Status_Code");
            });

            modelBuilder.Entity<GstHsnSacMenuItemSizes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MenuCode, e.SizeCode, e.HsnSacCode })
                    .HasName("GST_HSN_SAC_Menu_Item_Sizes_PK")
                    .IsClustered(false);

                entity.ToTable("GST_HSN_SAC_Menu_Item_Sizes");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SizeCode)
                    .HasColumnName("Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.HsnSacCode)
                    .HasColumnName("HSN_SAC_Code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode).HasColumnName("Status_Code");
            });

            modelBuilder.Entity<GstInventoryItemsDomFinal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GST_Inventory_Items_DOM_final");

                entity.Property(e => e.GstRates)
                    .HasColumnName("gst_rates")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Hsn)
                    .HasColumnName("hsn")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryCode)
                    .IsRequired()
                    .HasColumnName("inventory_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCategoryId).HasColumnName("Tax_Category_ID");
            });

            modelBuilder.Entity<GstInventoryItemsTaxHsn>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.InventoryCode, e.GstTaxCategoryId })
                    .IsClustered(false);

                entity.ToTable("GST_Inventory_Items_Tax_HSN");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryCode)
                    .HasColumnName("Inventory_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.GstTaxCategoryId).HasColumnName("GST_Tax_Category_ID");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.HsnSacCode)
                    .IsRequired()
                    .HasColumnName("HSN_SAC_Code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode).HasColumnName("Status_Code");
            });

            modelBuilder.Entity<GstInventoryMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GST_Inventory_Master");

                entity.Property(e => e.CessRate)
                    .HasColumnName("Cess_Rate")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.GstRates)
                    .HasColumnName("GST_Rates")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Hsn)
                    .HasColumnName("HSN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Material)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialDescription)
                    .HasColumnName("Material_Description")
                    .IsUnicode(false);

                entity.Property(e => e.PosCode)
                    .HasColumnName("POS_Code")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GstMrpItemsBasePrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GST_MRP_Items_Base_Price");

                entity.Property(e => e.BasePrice)
                    .HasColumnName("Base_Price")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SizeCode)
                    .HasColumnName("Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GstNonAcStoreMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GST_Non_AC_Store_Master");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GstNonGstComplianceStoreMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GST_Non_GST_Compliance_Store_Master");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GstRegions>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GST_Regions");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AddedManually).HasColumnName("Added_Manually");

                entity.Property(e => e.DriverLicenseDob).HasColumnName("Driver_License_DOB");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RegionAbbr)
                    .HasColumnName("Region_Abbr")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RegionCode).HasColumnName("Region_Code");

                entity.Property(e => e.RegionName)
                    .HasColumnName("Region_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StateCode)
                    .HasColumnName("State_Code")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GstSacMaster>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.SacCode, e.OrderTypeCode })
                    .HasName("GST_SAC_Master_PK")
                    .IsClustered(false);

                entity.ToTable("GST_SAC_Master");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SacCode)
                    .HasColumnName("SAC_Code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTypeCode)
                    .HasColumnName("Order_Type_Code")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode).HasColumnName("Status_Code");
            });

            modelBuilder.Entity<GstStoreCityMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GST_Store_City_Master");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('GST')");

                entity.Property(e => e.CityCode).HasColumnName("City_Code");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GstStoreStateCity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GST_Store_State_City");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('GSTTEAM')");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GstTaxCategoryMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GST_Tax_Category_Master");

                entity.Property(e => e.TaxCategoryDescription)
                    .HasColumnName("Tax_Category_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GstTaxCityMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GST_Tax_City_Master");

                entity.Property(e => e.CityName)
                    .HasColumnName("City_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GstTaxCityMasterIst>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GST_Tax_City_Master_IST");

                entity.Property(e => e.CityName)
                    .HasColumnName("City_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GstTaxNameMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GST_Tax_Name_Master");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Tax1Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tax1Odcapply).HasColumnName("Tax1ODCApply");

                entity.Property(e => e.Tax1On).HasColumnName("Tax1ON");

                entity.Property(e => e.Tax2Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tax2Odcapply).HasColumnName("Tax2ODCApply");

                entity.Property(e => e.Tax2On).HasColumnName("Tax2ON");

                entity.Property(e => e.Tax3Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tax3Odcapply).HasColumnName("Tax3ODCApply");

                entity.Property(e => e.Tax3On).HasColumnName("Tax3ON");

                entity.Property(e => e.Tax4Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tax4Odcapply).HasColumnName("Tax4ODCApply");

                entity.Property(e => e.Tax4On).HasColumnName("Tax4ON");

                entity.Property(e => e.Updated)
                    .HasColumnName("updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HalfToppingPricingCodes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.HalfToppingPricingCode });

                entity.ToTable("Half_Topping_Pricing_Codes");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.HalfToppingPricingCode).HasColumnName("Half_Topping_Pricing_Code");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .IsRequired()
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Holidays>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.HolidayDate })
                    .IsClustered(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.HolidayDate)
                    .HasColumnName("Holiday_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Hours>(entity =>
            {
                entity.HasKey(e => e.Hour)
                    .IsClustered(false);

                entity.Property(e => e.Hour).HasColumnType("datetime");
            });

            modelBuilder.Entity<HrisShiftPasswordResetLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HRIS_Shift_Password_Reset_Log");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.EmployeeCode)
                    .HasColumnName("Employee_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EventType)
                    .HasColumnName("Event_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LoginEmployeeCode)
                    .HasColumnName("Login_Employee_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_Date")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<HustleRegistration>(entity =>
            {
                entity.HasKey(e => e.LocationCode)
                    .IsClustered(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("Company_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.CurrentDate).HasColumnType("datetime");

                entity.Property(e => e.KeyString)
                    .IsRequired()
                    .HasColumnName("Key_String")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerName)
                    .IsRequired()
                    .HasColumnName("Owner_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.RegDate)
                    .HasColumnName("Reg_Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<IfcRecalculateCall>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IFC_RecalculateCall");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.ErrorMessage)
                    .HasColumnName("Error_Message")
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessingDate)
                    .HasColumnName("processing_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("System_Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<InstallVariables>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.VariableName });

                entity.ToTable("Install_Variables");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VariableName)
                    .HasColumnName("Variable_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VariableValue)
                    .IsRequired()
                    .HasColumnName("Variable_Value")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InventoryItemNutritionalValues>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.InventoryCode, e.NutritionalItemCode });

                entity.ToTable("Inventory_Item_Nutritional_Values");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryCode)
                    .HasColumnName("Inventory_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NutritionalItemCode)
                    .HasColumnName("Nutritional_Item_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NutritionalValue).HasColumnName("Nutritional_Value");
            });

            modelBuilder.Entity<InventoryItemRecipeIngredients>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.InventoryCode, e.SubInventoryCode });

                entity.ToTable("Inventory_Item_Recipe_Ingredients");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryCode)
                    .HasColumnName("Inventory_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SubInventoryCode)
                    .HasColumnName("Sub_Inventory_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryUnit)
                    .HasColumnName("Inventory_Unit")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<InventoryItemRecipeYieldItems>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.InventoryCode, e.SubInventoryCode });

                entity.ToTable("Inventory_Item_Recipe_Yield_Items");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryCode)
                    .HasColumnName("Inventory_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SubInventoryCode)
                    .HasColumnName("Sub_Inventory_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InventoryItemToppingCodes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.InventoryCode })
                    .IsClustered(false);

                entity.ToTable("Inventory_Item_Topping_Codes");

                entity.HasIndex(e => e.InventoryCode)
                    .HasName("Inventory_Code");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => new { e.LocationCode, e.InventoryCode })
                    .HasName("Inventory_ItemsInventory_Item_Topping_Codes")
                    .IsUnique();

                entity.HasIndex(e => new { e.LocationCode, e.ToppingCode })
                    .HasName("Topping_Code")
                    .IsUnique();

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryCode)
                    .HasColumnName("Inventory_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ToppingCode)
                    .IsRequired()
                    .HasColumnName("Topping_Code")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InventoryItemTypeCodes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.InventoryItemTypeCode });

                entity.ToTable("Inventory_Item_Type_Codes");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.InventoryItemTypeCode).HasColumnName("Inventory_Item_Type_Code");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InventoryItems>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.InventoryCode })
                    .IsClustered(false);

                entity.ToTable("Inventory_Items");

                entity.HasIndex(e => e.CountTypeCode)
                    .HasName("Count_TypeInventory");

                entity.HasIndex(e => e.InventoryCode)
                    .HasName("Inventory_ID");

                entity.HasIndex(e => e.InventoryTypeCode)
                    .HasName("Inventory_Type_ID");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => e.StatusCode)
                    .HasName("Status_CodesInventory_Items");

                entity.HasIndex(e => e.VendorCode)
                    .HasName("Vendor_Code");

                entity.HasIndex(e => new { e.LocationCode, e.InventoryTypeCode })
                    .HasName("Inventory_TypeInventory");

                entity.HasIndex(e => new { e.LocationCode, e.VendorCode })
                    .HasName("VendorInventory_Items");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryCode)
                    .HasColumnName("Inventory_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CountOrder).HasColumnName("Count_Order");

                entity.Property(e => e.CountTypeCode).HasColumnName("Count_Type_Code");

                entity.Property(e => e.CountUnit)
                    .IsRequired()
                    .HasColumnName("Count_Unit")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");

                entity.Property(e => e.InstructionsImage).HasColumnName("Instructions_Image");

                entity.Property(e => e.InventoryItemTypeCode)
                    .HasColumnName("Inventory_Item_Type_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.InventoryTypeCode)
                    .IsRequired()
                    .HasColumnName("Inventory_Type_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MaxStockingLevel).HasColumnName("Max_Stocking_Level");

                entity.Property(e => e.MinStockingLevel).HasColumnName("Min_Stocking_Level");

                entity.Property(e => e.OrderUnit)
                    .IsRequired()
                    .HasColumnName("Order_Unit")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PortionCount).HasColumnName("Portion_Count");

                entity.Property(e => e.PortionUnit)
                    .IsRequired()
                    .HasColumnName("Portion_Unit")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PrepDays).HasColumnName("Prep_Days");

                entity.Property(e => e.PrepHours).HasColumnName("Prep_Hours");

                entity.Property(e => e.PrepMinutes).HasColumnName("Prep_Minutes");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ReadyDays).HasColumnName("Ready_Days");

                entity.Property(e => e.ReadyHours).HasColumnName("Ready_Hours");

                entity.Property(e => e.ReadyMinutes).HasColumnName("Ready_Minutes");

                entity.Property(e => e.ShelfLifeDays).HasColumnName("Shelf_Life_Days");

                entity.Property(e => e.ShelfLifeHours).HasColumnName("Shelf_Life_Hours");

                entity.Property(e => e.ShelfLifeMinutes).HasColumnName("Shelf_Life_Minutes");

                entity.Property(e => e.StatusCode).HasColumnName("Status_Code");

                entity.Property(e => e.VendorCode)
                    .HasColumnName("Vendor_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VendorItemCode)
                    .HasColumnName("Vendor_Item_Code")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InventoryToppingPercentages>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.ToppingCode, e.ToppingCount })
                    .IsClustered(false);

                entity.ToTable("Inventory_Topping_Percentages");

                entity.HasIndex(e => new { e.LocationCode, e.ToppingCode })
                    .HasName("Inventory_Item_Topping_CodesInventory_Topping_Percentages");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ToppingCode)
                    .HasColumnName("Topping_Code")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ToppingCount).HasColumnName("Topping_Count");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PercentUsed).HasColumnName("Percent_Used");
            });

            modelBuilder.Entity<InventoryType>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.InventoryTypeCode })
                    .IsClustered(false);

                entity.ToTable("Inventory_Type");

                entity.HasIndex(e => e.InventoryTypeCode)
                    .HasName("Inventory_Type_ID");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryTypeCode)
                    .HasColumnName("Inventory_Type_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Food).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<InventoryVariance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Inventory_Variance");

                entity.Property(e => e.InventoryIdeal)
                    .HasColumnName("Inventory_Ideal")
                    .HasColumnType("numeric(10, 3)");

                entity.Property(e => e.InventoryName)
                    .HasColumnName("Inventory_Name")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryUsed)
                    .HasColumnName("Inventory_Used")
                    .HasColumnType("numeric(10, 3)");

                entity.Property(e => e.InventoryVariance1)
                    .HasColumnName("Inventory_Variance")
                    .HasColumnType("numeric(10, 3)");
            });

            modelBuilder.Entity<InvoiceNumber>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.InvoiceNumber1 })
                    .HasName("PK__InvoiceN__215195EAFFFE12AD");

                entity.HasIndex(e => new { e.OrderNumber, e.OrderDate })
                    .HasName("AK_order_number")
                    .IsUnique();

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber1)
                    .HasColumnName("Invoice_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Browser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomField1).HasMaxLength(50);

                entity.Property(e => e.CustomField10).HasMaxLength(250);

                entity.Property(e => e.CustomField2).HasMaxLength(50);

                entity.Property(e => e.CustomField3).HasMaxLength(50);

                entity.Property(e => e.CustomField4).HasMaxLength(50);

                entity.Property(e => e.CustomField5).HasMaxLength(50);

                entity.Property(e => e.CustomField6).HasMaxLength(50);

                entity.Property(e => e.CustomField7).HasMaxLength(250);

                entity.Property(e => e.CustomField8).HasMaxLength(250);

                entity.Property(e => e.CustomField9).HasMaxLength(250);

                entity.Property(e => e.DeviceType)
                    .HasColumnName("Device_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GrossAmount).HasColumnType("money");

                entity.Property(e => e.Instruction)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.PaymentGateway)
                    .HasColumnName("Payment_Gateway")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Platform)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoiCustomer)
                    .HasColumnName("ROI_Customer")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tax).HasColumnType("money");

                entity.Property(e => e.TotalAmount).HasColumnType("money");

                entity.Property(e => e.Types)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvoiceNumberJune2018>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InvoiceNumber_June2018");

                entity.Property(e => e.Browser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomField1).HasMaxLength(50);

                entity.Property(e => e.CustomField2).HasMaxLength(50);

                entity.Property(e => e.CustomField3).HasMaxLength(50);

                entity.Property(e => e.CustomField4).HasMaxLength(50);

                entity.Property(e => e.CustomField5).HasMaxLength(50);

                entity.Property(e => e.DeviceType)
                    .HasColumnName("Device_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GrossAmount).HasColumnType("money");

                entity.Property(e => e.Instruction)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.PaymentGateway)
                    .HasColumnName("Payment_Gateway")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Platform)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoiCustomer)
                    .HasColumnName("ROI_Customer")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tax).HasColumnType("money");

                entity.Property(e => e.TotalAmount).HasColumnType("money");

                entity.Property(e => e.Types)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IstCityStateDetl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IST_CITY_STATE_DETL");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("LOCATION_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverCity)
                    .HasColumnName("RECEIVER_CITY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverState)
                    .HasColumnName("RECEIVER_STATE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SenderCity)
                    .HasColumnName("SENDER_CITY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SenderState)
                    .HasColumnName("SENDER_STATE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TransferLocationCode)
                    .HasColumnName("TRANSFER_LOCATION_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IstEodCheckLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IST_EOD_CHECK_LOG");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastEodTime)
                    .HasColumnName("Last_EOD_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("System_Date")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<IstInvoiceNumber>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IST_Invoice_Number");

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_ID");

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice_Number")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IstReceiptTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IST_RECEIPT_TRANSACTION");

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CountUnit)
                    .HasColumnName("COUNT_UNIT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryId).HasColumnName("DELIVERY_ID");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryCode)
                    .IsRequired()
                    .HasColumnName("INVENTORY_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("INVOICE_NUMBER")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("LOCATION_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderUnit)
                    .HasColumnName("ORDER_UNIT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SenderLocationCode)
                    .HasColumnName("SENDER_LOCATION_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("TIME_STAMP")
                    .HasColumnType("datetime");

                entity.Property(e => e.TransferQty)
                    .HasColumnName("TRANSFER_QTY")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.XmlfileName)
                    .HasColumnName("XMLFILE_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IstStateGstin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IST_State_GSTIN");

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .HasColumnName("Region_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IstStnDataDetl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IST_STN_DATA_DETL");

                entity.Property(e => e.ItemCode)
                    .HasColumnName("ITEM_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemQty)
                    .HasColumnName("ITEM_QTY")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.ItemRate)
                    .HasColumnName("ITEM_RATE")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LocnCode)
                    .HasColumnName("LOCN_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldRate)
                    .HasColumnName("OLD_RATE")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PosCode)
                    .HasColumnName("POS_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PosQty)
                    .HasColumnName("POS_QTY")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.PosRate)
                    .HasColumnName("POS_RATE")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RecNo).HasColumnName("REC_NO");

                entity.Property(e => e.StnId).HasColumnName("STN_ID");
            });

            modelBuilder.Entity<IstStnDataHdr>(entity =>
            {
                entity.HasKey(e => e.StnId)
                    .HasName("PK__IST_STN___221F552C474DA00C");

                entity.ToTable("IST_STN_DATA_HDR");

                entity.Property(e => e.StnId).HasColumnName("STN_ID");

                entity.Property(e => e.InvDate)
                    .HasColumnName("INV_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvNo)
                    .HasColumnName("INV_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocnCode)
                    .HasColumnName("LOCN_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StoreDlyDate)
                    .HasColumnName("STORE_DLY_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.StoreDlyId)
                    .HasColumnName("STORE_DLY_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendCode)
                    .HasColumnName("VEND_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.XmlfileName)
                    .HasColumnName("XMLFILE_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IstTax>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IST_TAX");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxId).HasColumnName("Tax_ID");

                entity.Property(e => e.TaxName)
                    .HasColumnName("Tax_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IstTaxDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IST_TAX_DETAILS");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IstId).HasColumnName("IST_ID");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Tax1Amount)
                    .HasColumnName("Tax1_Amount")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Tax1Rate)
                    .HasColumnName("Tax1_Rate")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Tax2Amount)
                    .HasColumnName("Tax2_Amount")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Tax2Rate)
                    .HasColumnName("Tax2_Rate")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Tax3Amount)
                    .HasColumnName("Tax3_Amount")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Tax3Rate)
                    .HasColumnName("Tax3_Rate")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Tax4Amount)
                    .HasColumnName("Tax4_Amount")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Tax4Rate)
                    .HasColumnName("Tax4_Rate")
                    .HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<IstTaxTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IST_TAX_tmp");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxId).HasColumnName("Tax_ID");

                entity.Property(e => e.TaxName)
                    .HasColumnName("Tax_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IstTmpTax>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IST_TMP_TAX");

                entity.Property(e => e.InventoryItem)
                    .HasColumnName("Inventory_Item")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TaxAmount)
                    .HasColumnName("Tax_Amount")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TaxCalcId).HasColumnName("Tax_Calc_id");

                entity.Property(e => e.TaxId).HasColumnName("Tax_id");

                entity.Property(e => e.TaxIdRate)
                    .HasColumnName("Tax_id_Rate")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TaxRate)
                    .HasColumnName("Tax_Rate")
                    .HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<IstTransactionDetl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IST_TRANSACTION_DETL");

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ConFactor)
                    .HasColumnName("CON_FACTOR")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CountUnit)
                    .HasColumnName("COUNT_UNIT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryCode)
                    .HasColumnName("INVENTORY_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("INVOICE_NUMBER")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OrderUnit)
                    .HasColumnName("ORDER_UNIT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransactionId).HasColumnName("TRANSACTION_ID");

                entity.Property(e => e.TransferQty)
                    .HasColumnName("TRANSFER_QTY")
                    .HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<IstTransactionHdr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IST_TRANSACTION_HDR");

                entity.Property(e => e.DeliveryId).HasColumnName("DELIVERY_ID");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("LOCATION_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("TIME_STAMP")
                    .HasColumnType("datetime");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TRANSACTION_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TransactionStatus)
                    .HasColumnName("TRANSACTION_STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransferLocationCode)
                    .HasColumnName("TRANSFER_LOCATION_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.XmlfileName)
                    .HasColumnName("XMLFILE_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemVisibilityTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.ItemVisibilityTypeCode });

                entity.ToTable("Item_Visibility_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ItemVisibilityTypeCode).HasColumnName("Item_Visibility_Type_Code");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JflOneCustomerDv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("JFL_OneCustomerDV");

                entity.Property(e => e.MobileNo).HasMaxLength(50);

                entity.Property(e => e.PropertyColumnText).HasMaxLength(200);

                entity.Property(e => e.PropertyColumnValue).HasMaxLength(200);
            });

            modelBuilder.Entity<KeyboardLayout>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Keyboard_Layout");

                entity.HasIndex(e => e.DisplayOrder)
                    .HasName("Display_Order");

                entity.HasIndex(e => e.ShiftKeyboardKey)
                    .HasName("Shift_Keyboard_Key");

                entity.HasIndex(e => new { e.LocationCode, e.KeyboardKey, e.KeyType })
                    .HasName("KeyBoard_Key")
                    .IsUnique();

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");

                entity.Property(e => e.KeyType).HasColumnName("Key_Type");

                entity.Property(e => e.KeyboardKey)
                    .IsRequired()
                    .HasColumnName("Keyboard_Key")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftKeyboardKey)
                    .HasColumnName("Shift_Keyboard_Key")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KitchenDelayPrint>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderDate, e.OrderNumber })
                    .IsClustered(false);

                entity.ToTable("Kitchen_Delay_Print");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PrintDateTime)
                    .HasColumnName("Print_Date_Time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<LabelConfig>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BackColor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ForeColor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LabelPropertyName).HasMaxLength(50);

                entity.Property(e => e.Labeltext).HasMaxLength(50);
            });

            modelBuilder.Entity<LanguageCodes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode })
                    .IsClustered(false);

                entity.ToTable("Language_Codes");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DefaultLanguageCode).HasColumnName("Default_Language_Code");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .IsRequired()
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LanguageTables>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.TableName, e.KeyValue })
                    .IsClustered(false);

                entity.ToTable("Language_Tables");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.TableName)
                    .HasColumnName("Table_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.KeyValue)
                    .HasColumnName("Key_Value")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultText)
                    .HasColumnName("Default_Text")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserModifiedText)
                    .HasColumnName("User_Modified_Text")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LanpcExe>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LanpcEXe");

                entity.Property(e => e.EodTime)
                    .HasColumnName("Eod_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LanPcexe1).HasColumnName("LanPCexe");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ServerName)
                    .HasColumnName("Server_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkStaion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LocationCodes>(entity =>
            {
                entity.HasKey(e => e.LocationCode)
                    .IsClustered(false);

                entity.ToTable("Location_Codes");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CcSettlementAttempted).HasColumnName("CC_Settlement_Attempted");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaxCreditCard)
                    .HasColumnName("Max_CreditCard")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxStations)
                    .HasColumnName("Max_Stations")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OverrideProcessingDate).HasColumnName("Override_Processing_Date");

                entity.Property(e => e.PizzaToppingGroup)
                    .HasColumnName("Pizza_Topping_Group")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.StoreAddress)
                    .HasColumnName("Store_Address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StorePhone)
                    .HasColumnName("Store_Phone")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("System_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TaxIdNumber)
                    .HasColumnName("Tax_ID_Number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TaxSlipLine1)
                    .HasColumnName("Tax_Slip_line1")
                    .HasMaxLength(44)
                    .IsUnicode(false);

                entity.Property(e => e.TaxSlipLine2)
                    .HasColumnName("Tax_Slip_line2")
                    .HasMaxLength(44)
                    .IsUnicode(false);

                entity.Property(e => e.TaxSlipLine3)
                    .HasColumnName("Tax_Slip_line3")
                    .HasMaxLength(44)
                    .IsUnicode(false);

                entity.Property(e => e.TaxSlipLine4)
                    .HasColumnName("Tax_Slip_line4")
                    .HasMaxLength(44)
                    .IsUnicode(false);

                entity.Property(e => e.TaxSlipLine5)
                    .HasColumnName("Tax_Slip_line5")
                    .HasMaxLength(44)
                    .IsUnicode(false);

                entity.Property(e => e.TaxSlipLine6)
                    .HasColumnName("Tax_Slip_line6")
                    .HasMaxLength(44)
                    .IsUnicode(false);

                entity.Property(e => e.TaxSlipLine7)
                    .HasColumnName("Tax_Slip_line7")
                    .HasMaxLength(44)
                    .IsUnicode(false);

                entity.Property(e => e.TaxSlipLine8)
                    .HasColumnName("Tax_Slip_line8")
                    .HasMaxLength(44)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogError>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOG_ERROR");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ErrorNumber).HasColumnName("Error_Number");

                entity.Property(e => e.LineNumber).HasColumnName("Line_Number");
            });

            modelBuilder.Entity<LogPosSheet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Log_pos_Sheet");

                entity.Property(e => e.ExportDate).HasColumnType("datetime");

                entity.Property(e => e.LocationCode).HasColumnName("Location_Code");

                entity.Property(e => e.PosSheetNo).HasColumnName("Pos_SheetNo");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<MakeLineDisplay>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderNumber, e.OrderDate, e.LineNumber, e.DeviceId })
                    .HasName("aaaaaMake_Line_Display_PK")
                    .IsClustered(false);

                entity.ToTable("Make_Line_Display");

                entity.HasIndex(e => e.ActualOrderDate)
                    .HasName("Actual_Order_Date");

                entity.HasIndex(e => e.CustomerCode)
                    .HasName("Customer_Code");

                entity.HasIndex(e => e.LineNumber)
                    .HasName("Line_Number");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => e.MenuCode)
                    .HasName("Menu_Code");

                entity.HasIndex(e => e.OrderSaved)
                    .HasName("Order_Saved");

                entity.HasIndex(e => e.OrderTypeCode)
                    .HasName("Order_Type_Code");

                entity.HasIndex(e => e.SizeCode)
                    .HasName("Size_Code");

                entity.HasIndex(e => new { e.LocationCode, e.OrderNumber, e.OrderDate })
                    .HasName("OrdersMake_Line_Display");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LineNumber).HasColumnName("Line_Number");

                entity.Property(e => e.DeviceId).HasColumnName("Device_ID");

                entity.Property(e => e.ActualOrderDate)
                    .HasColumnName("Actual_Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerCode)
                    .HasColumnName("Customer_Code")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Instructions)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.KitchenDisplayTime)
                    .HasColumnName("Kitchen_Display_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MakeQty)
                    .HasColumnName("Make_Qty")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSaved)
                    .HasColumnName("Order_Saved")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderTypeCode)
                    .HasColumnName("Order_Type_Code")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.SizeCode)
                    .HasColumnName("Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ToppingCodes)
                    .HasColumnName("Topping_Codes")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ToppingDescriptions)
                    .HasColumnName("Topping_Descriptions")
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MakeLineDisplayRemoteOrders>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderNumber, e.OrderDate, e.DeviceId, e.WorkstationId })
                    .IsClustered(false);

                entity.ToTable("Make_Line_Display_Remote_Orders");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeviceId).HasColumnName("Device_ID");

                entity.Property(e => e.WorkstationId).HasColumnName("Workstation_ID");

                entity.Property(e => e.KitchenDisplayTime)
                    .HasColumnName("Kitchen_Display_Time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<MarketingCouponAnalysisTemp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasColumnName("Coupon_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Sector)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MarketingCouponsTemp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CouponCode)
                    .HasColumnName("Coupon_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MarketingCustomQueryFields>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.QueryCode, e.KeyId })
                    .IsClustered(false);

                entity.ToTable("Marketing_Custom_Query_Fields");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.QueryCode).HasColumnName("Query_Code");

                entity.Property(e => e.KeyId).HasColumnName("KeyID");

                entity.Property(e => e.ListOrder).HasColumnName("List_Order");
            });

            modelBuilder.Entity<MarketingFields>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.CriteriaKey });

                entity.ToTable("Marketing_Fields");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CriteriaKey).HasColumnName("Criteria_Key");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");

                entity.Property(e => e.EnglishTextDescription)
                    .IsRequired()
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modifier).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.NeedLanguage).HasColumnName("Need_Language");

                entity.Property(e => e.NeedLocation).HasColumnName("Need_Location");

                entity.Property(e => e.NeedParen).HasColumnName("Need_Paren");

                entity.Property(e => e.SpFlag).HasColumnName("SP_Flag");

                entity.Property(e => e.SpecialCode).HasColumnName("Special_Code");

                entity.Property(e => e.SqlTag)
                    .IsRequired()
                    .HasColumnName("SQL_Tag")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StoredProcedure)
                    .IsRequired()
                    .HasColumnName("Stored_Procedure")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TableCode).HasColumnName("Table_Code");

                entity.Property(e => e.VariableType).HasColumnName("Variable_Type");
            });

            modelBuilder.Entity<MarketingLabelTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.LabelId });

                entity.ToTable("Marketing_Label_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.LabelId).HasColumnName("Label_ID");

                entity.Property(e => e.DefaultDescription)
                    .IsRequired()
                    .HasColumnName("Default_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDescription)
                    .IsRequired()
                    .HasColumnName("Modified_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MarketingOperators>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.OperatorCode });

                entity.ToTable("Marketing_Operators");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OperatorCode).HasColumnName("Operator_Code");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .IsRequired()
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Modifier).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.SqlCode)
                    .IsRequired()
                    .HasColumnName("SQL_Code")
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MarketingOutputChoices>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.KeyId });

                entity.ToTable("Marketing_Output_Choices");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.KeyId).HasColumnName("KeyID");

                entity.Property(e => e.AggregateComboUsed)
                    .IsRequired()
                    .HasColumnName("Aggregate_Combo_Used")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .IsRequired()
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SqlColName)
                    .IsRequired()
                    .HasColumnName("SQL_Col_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TableCode).HasColumnName("Table_Code");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasColumnName("Table_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MarketingQueryCodes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.QueryCode, e.QueryIndex })
                    .IsClustered(false);

                entity.ToTable("Marketing_Query_Codes");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.QueryCode).HasColumnName("Query_Code");

                entity.Property(e => e.QueryIndex).HasColumnName("Query_Index");

                entity.Property(e => e.BeginValue)
                    .HasColumnName("Begin_Value")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CloseParen)
                    .IsRequired()
                    .HasColumnName("Close_Paren")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CriteriaCode).HasColumnName("Criteria_Code");

                entity.Property(e => e.EndValue)
                    .HasColumnName("End_Value")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpenParen)
                    .IsRequired()
                    .HasColumnName("Open_Paren")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorCode).HasColumnName("Operator_Code");

                entity.Property(e => e.OperatorListIndex).HasColumnName("Operator_List_Index");
            });

            modelBuilder.Entity<MarketingQuerys>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.QueryCode })
                    .IsClustered(false);

                entity.ToTable("Marketing_Querys");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.QueryCode).HasColumnName("Query_Code");

                entity.Property(e => e.QueryDescription)
                    .IsRequired()
                    .HasColumnName("Query_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MarketingSectorsTemp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.SectorCode)
                    .IsRequired()
                    .HasColumnName("Sector_Code")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MarketingVariableType>(entity =>
            {
                entity.HasKey(e => e.VariableType)
                    .IsClustered(false);

                entity.ToTable("Marketing_Variable_Type");

                entity.Property(e => e.VariableType)
                    .HasColumnName("Variable_Type")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MarketingVtOc>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.VariableType, e.OperatorCode })
                    .IsClustered(false);

                entity.ToTable("Marketing_VT_OC");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VariableType).HasColumnName("Variable_Type");

                entity.Property(e => e.OperatorCode).HasColumnName("Operator_Code");

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");
            });

            modelBuilder.Entity<MasterType>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MenuCode, e.SizeCode })
                    .IsClustered(false);

                entity.ToTable("Master_Type");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SizeCode)
                    .HasColumnName("Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MasterCode)
                    .HasColumnName("Master_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCodes)
                    .HasColumnName("Product_codes")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProductGroupCode)
                    .HasColumnName("Product_Group_Code")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ProductSizeCode)
                    .HasColumnName("Product_Size_code")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MatchOrderLines>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Match_Order_Lines");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<MenuCategory>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MenuCategoryCode })
                    .IsClustered(false);

                entity.ToTable("Menu_Category");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => e.MenuCategoryCode)
                    .HasName("Menu_Category_ID");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCategoryCode)
                    .HasColumnName("Menu_Category_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("Display_Order")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MenuCategoryImage).HasColumnName("Menu_Category_Image");

                entity.Property(e => e.OrderDescription)
                    .HasColumnName("Order_Description")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RemoteOrderAvailability)
                    .HasColumnName("Remote_Order_Availability")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.TextColor)
                    .HasColumnName("Text_Color")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Visible).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MenuComboItemSizes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MenuCode, e.SizeCode, e.SubMenuCode, e.SubSizeCode, e.ItemNumber });

                entity.ToTable("Menu_Combo_Item_Sizes");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SizeCode)
                    .HasColumnName("Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SubMenuCode)
                    .HasColumnName("Sub_Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SubSizeCode)
                    .HasColumnName("Sub_Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNumber).HasColumnName("Item_Number");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultItem)
                    .HasColumnName("Default_Item")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MenuComboItems>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MenuCode, e.SizeCode, e.SubMenuCode, e.ItemNumber });

                entity.ToTable("Menu_Combo_Items");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SizeCode)
                    .HasColumnName("Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SubMenuCode)
                    .HasColumnName("Sub_Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNumber).HasColumnName("Item_Number");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultItem)
                    .HasColumnName("Default_Item")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Discount).HasColumnType("money");

                entity.Property(e => e.MaxAmount).HasColumnType("money");

                entity.Property(e => e.MinAmount).HasColumnType("money");

                entity.Property(e => e.PromptForAttributes).HasColumnName("Prompt_For_Attributes");

                entity.Property(e => e.PromptForMenuItem).HasColumnName("Prompt_For_Menu_Item");

                entity.Property(e => e.PromptForOptions).HasColumnName("Prompt_For_Options");

                entity.Property(e => e.PromptForSizes).HasColumnName("Prompt_For_Sizes");
            });

            modelBuilder.Entity<MenuItemAttributeGroups>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MenuCode, e.AttributeGroupCode })
                    .IsClustered(false);

                entity.ToTable("Menu_Item_Attribute_Groups");

                entity.HasIndex(e => e.AttributeGroupCode)
                    .HasName("Menu_Options_Code");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => e.MenuCode)
                    .HasName("Menu_Option_Code");

                entity.HasIndex(e => new { e.LocationCode, e.MenuCode })
                    .HasName("Menu_ItemsMenu_Item_Attribute_Groups");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AttributeGroupCode)
                    .HasColumnName("Attribute_Group_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");

                entity.Property(e => e.MaxToChoose)
                    .HasColumnName("Max_to_Choose")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MinToChoose)
                    .HasColumnName("Min_to_Choose")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MenuItemCategories>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MenuCode, e.MenuCategoryCode })
                    .IsClustered(false);

                entity.ToTable("Menu_Item_Categories");

                entity.HasIndex(e => e.MenuCode)
                    .HasName("Menu_Code");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCategoryCode)
                    .HasColumnName("Menu_Category_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCategoryDisplayOrder).HasColumnName("Menu_Category_Display_Order");
            });

            modelBuilder.Entity<MenuItemCoupons>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MenuCode, e.SizeCode, e.CouponCode })
                    .IsClustered(false);

                entity.ToTable("Menu_Item_Coupons");

                entity.HasIndex(e => e.CouponCode)
                    .HasName("Coupon_Code");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => e.MenuCode)
                    .HasName("Menu_code");

                entity.HasIndex(e => new { e.LocationCode, e.CouponCode })
                    .HasName("CouponsMenu_Item_Coupons");

                entity.HasIndex(e => new { e.LocationCode, e.MenuCode })
                    .HasName("Menu_ItemsMenu_Item_Coupons");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SizeCode)
                    .HasColumnName("Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CouponCode)
                    .HasColumnName("Coupon_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasColumnName("Status_code")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MenuItemDisCoupons>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MenuCode, e.SizeCode, e.CouponCode })
                    .IsClustered(false);

                entity.ToTable("Menu_Item_Dis_Coupons");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SizeCode)
                    .HasColumnName("Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CouponCode)
                    .HasColumnName("Coupon_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Discount).HasColumnType("money");

                entity.Property(e => e.StatusCode).HasColumnName("Status_Code");
            });

            modelBuilder.Entity<MenuItemIfc>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MenuCode, e.SizeCode, e.InventoryCode })
                    .HasName("aaaaaMenu_Item_IFC_PK")
                    .IsClustered(false);

                entity.ToTable("Menu_Item_IFC");

                entity.HasIndex(e => e.InventoryCode)
                    .HasName("Inventory_ID");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => e.MenuCode)
                    .HasName("Menu_ID");

                entity.HasIndex(e => e.SizeCode)
                    .HasName("Size_Code");

                entity.HasIndex(e => new { e.LocationCode, e.InventoryCode })
                    .HasName("Inventory_ItemsIFC");

                entity.HasIndex(e => new { e.LocationCode, e.MenuCode })
                    .HasName("Menu_ItemsIFC");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SizeCode)
                    .HasColumnName("Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryCode)
                    .HasColumnName("Inventory_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ApplyCarryOut)
                    .IsRequired()
                    .HasColumnName("Apply_CarryOut")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ApplyDelivery)
                    .IsRequired()
                    .HasColumnName("Apply_Delivery")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ApplyDineIn)
                    .IsRequired()
                    .HasColumnName("Apply_DineIn")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ApplyPickUp)
                    .IsRequired()
                    .HasColumnName("Apply_PickUp")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MenuItemIfcToppings>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MenuCode, e.SizeCode, e.InventoryCode, e.NumberOfToppings })
                    .HasName("aaaaaMenu_Item_IFC_Toppings_PK")
                    .IsClustered(false);

                entity.ToTable("Menu_Item_IFC_Toppings");

                entity.HasIndex(e => e.InventoryCode)
                    .HasName("Inventory_ID");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => e.MenuCode)
                    .HasName("Menu_ID");

                entity.HasIndex(e => e.SizeCode)
                    .HasName("Size_Code");

                entity.HasIndex(e => new { e.LocationCode, e.InventoryCode })
                    .HasName("Inventory_ItemsIFC");

                entity.HasIndex(e => new { e.LocationCode, e.MenuCode })
                    .HasName("Menu_ItemsIFC");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SizeCode)
                    .HasColumnName("Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryCode)
                    .HasColumnName("Inventory_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfToppings).HasColumnName("Number_Of_Toppings");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DoubleAmount).HasColumnName("Double_Amount");

                entity.Property(e => e.ExtraAmount).HasColumnName("Extra_Amount");

                entity.Property(e => e.LightAmount).HasColumnName("Light_Amount");

                entity.Property(e => e.SingleAmount).HasColumnName("Single_Amount");

                entity.Property(e => e.TripleAmount).HasColumnName("Triple_Amount");
            });

            modelBuilder.Entity<MenuItemKitchenDevices>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MenuCode, e.DeviceId })
                    .IsClustered(false);

                entity.ToTable("Menu_Item_Kitchen_Devices");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId).HasColumnName("Device_ID");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MenuItemOptionGroups>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MenuCode, e.MenuOptionGroupCode })
                    .HasName("aaaaaMenu_Item_Option_Group_PK")
                    .IsClustered(false);

                entity.ToTable("Menu_Item_Option_Groups");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => e.MenuCode)
                    .HasName("Menu_Option_Code");

                entity.HasIndex(e => e.MenuOptionGroupCode)
                    .HasName("Menu_Options_Code");

                entity.HasIndex(e => new { e.LocationCode, e.MenuCode })
                    .HasName("Menu_ItemsMenu_Item_Option_Groups");

                entity.HasIndex(e => new { e.LocationCode, e.MenuOptionGroupCode })
                    .HasName("Menu_Option_GroupsMenu_Item_Option_Groups");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuOptionGroupCode)
                    .HasColumnName("Menu_Option_Group_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayHalfButtons).HasColumnName("Display_Half_Buttons");

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("Display_Order")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemSpecificPrice)
                    .HasColumnName("Item_Specific_Price")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxToChoose)
                    .HasColumnName("Max_to_Choose")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MinToChoose)
                    .HasColumnName("Min_to_Choose")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RequireChoice).HasColumnName("Require_Choice");

                entity.Property(e => e.ToppingGroup)
                    .HasColumnName("Topping_Group")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WeightOnKitchenDisplay).HasColumnName("Weight_On_Kitchen_Display");
            });

            modelBuilder.Entity<MenuItemOptionsDetails>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MenuCode, e.MenuOptionGroupCode, e.SubMenuCode, e.SizeCode })
                    .IsClustered(false);

                entity.ToTable("Menu_Item_Options_Details");

                entity.HasIndex(e => e.AmountCode)
                    .HasName("Topping_Amount_CodesMenu_Item_Options_Details");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => e.MenuCode)
                    .HasName("Menu_Code");

                entity.HasIndex(e => e.MenuOptionGroupCode)
                    .HasName("Menu_Option_Group_Code");

                entity.HasIndex(e => e.SizeCode)
                    .HasName("Size_Code");

                entity.HasIndex(e => e.SubMenuCode)
                    .HasName("Menu_Option_Code");

                entity.HasIndex(e => new { e.LocationCode, e.MenuCode, e.MenuOptionGroupCode })
                    .HasName("Menu_Item_Option_GroupsMenu_Item_Options_Details");

                entity.HasIndex(e => new { e.LocationCode, e.SubMenuCode, e.SizeCode })
                    .HasName("Menu_Item_SizesMenu_Item_Options_Details");

                entity.HasIndex(e => new { e.LocationCode, e.MenuOptionGroupCode, e.SubMenuCode, e.SizeCode })
                    .HasName("Menu_Options_Group_Menu_OptionsMenu_Item_Options_Details");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuOptionGroupCode)
                    .HasColumnName("Menu_Option_Group_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SubMenuCode)
                    .HasColumnName("Sub_Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SizeCode)
                    .HasColumnName("Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AmountCode)
                    .HasColumnName("Amount_Code")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Cheese).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sauce).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MenuItemSizes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MenuCode, e.SizeCode })
                    .HasName("aaaaaMenu_Item_Sizes_PK")
                    .IsClustered(false);

                entity.ToTable("Menu_Item_Sizes");

                entity.HasIndex(e => e.DisplayOrder)
                    .HasName("Display_Order");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Menu_Item_SizesLocation_Code");

                entity.HasIndex(e => new { e.LocationCode, e.Barcode })
                    .HasName("BarcodesMenu_Item_Sizes");

                entity.HasIndex(e => new { e.LocationCode, e.MenuCode })
                    .HasName("Menu_ItemsMenu_Item_Sizes");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SizeCode)
                    .HasColumnName("Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BottleDeposit)
                    .HasColumnName("Bottle_Deposit")
                    .HasColumnType("money");

                entity.Property(e => e.DefaultSize).HasColumnName("Default_Size");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");

                entity.Property(e => e.MaxAmountOpenValueCard)
                    .HasColumnName("Max_Amount_Open_Value_Card")
                    .HasColumnType("money");

                entity.Property(e => e.MinAmountOpenValueCard)
                    .HasColumnName("Min_Amount_Open_Value_Card")
                    .HasColumnType("money");

                entity.Property(e => e.OpenValueCard).HasColumnName("Open_Value_Card");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Price2).HasColumnType("money");

                entity.Property(e => e.PriceByWeight).HasColumnName("Price_By_Weight");

                entity.Property(e => e.StatusCode)
                    .HasColumnName("Status_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TareWeight).HasColumnName("Tare_Weight");
            });

            modelBuilder.Entity<MenuItemSizesTaxCategory>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MenuCode, e.SizeCode })
                    .IsClustered(false);

                entity.ToTable("Menu_Item_Sizes_Tax_Category");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SizeCode)
                    .HasColumnName("Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Tax1TaxableAmount)
                    .HasColumnName("Tax_1_Taxable_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax2TaxableAmount)
                    .HasColumnName("Tax_2_Taxable_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax3TaxableAmount)
                    .HasColumnName("Tax_3_Taxable_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax4TaxableAmount)
                    .HasColumnName("Tax_4_Taxable_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.TaxCategoryId).HasColumnName("Tax_Category_ID");

                entity.Property(e => e.TaxableByMargin).HasColumnName("Taxable_By_Margin");
            });

            modelBuilder.Entity<MenuItemTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.MenuItemTypeCode });

                entity.ToTable("Menu_Item_Types");

                entity.HasIndex(e => e.MenuItemTypeCode)
                    .HasName("Menu_Item_Type_ID");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuItemTypeCode).HasColumnName("Menu_Item_Type_Code");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MenuItemTypes1>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.MenuItemType });

                entity.ToTable("MenuItemTypes");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.MenuItemTypes1)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MenuItemTypes_Location_Codes");
            });

            modelBuilder.Entity<MenuItems>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MenuCode })
                    .HasName("aaaaaMenu_Items_PK")
                    .IsClustered(false);

                entity.ToTable("Menu_Items");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => e.MenuCategoryCode)
                    .HasName("Menu_Type_ID");

                entity.HasIndex(e => e.MenuCode)
                    .HasName("Menu_Code");

                entity.HasIndex(e => e.StatusCode)
                    .HasName("Status_CodesMenu_Items");

                entity.HasIndex(e => new { e.LocationCode, e.MenuCategoryCode })
                    .HasName("Menu_TypeMenu_Items");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ComboMeal)
                    .HasColumnName("Combo_Meal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");

                entity.Property(e => e.MenuCategoryCode)
                    .HasColumnName("Menu_Category_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCategoryDisplayOrder)
                    .HasColumnName("Menu_Category_Display_Order")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MenuItemImage).HasColumnName("Menu_Item_Image");

                entity.Property(e => e.MenuItemType).HasDefaultValueSql("((0))");

                entity.Property(e => e.MenuItemTypeCode)
                    .HasColumnName("Menu_Item_Type_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OrderDescription)
                    .HasColumnName("Order_Description")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PizzaYn)
                    .HasColumnName("Pizza_YN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PreparedYn)
                    .HasColumnName("Prepared_YN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintLabel)
                    .HasColumnName("Print_Label")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintNutritionalLabel)
                    .HasColumnName("Print_Nutritional_Label")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintTicket).HasColumnName("Print_Ticket");

                entity.Property(e => e.PromptForSize)
                    .IsRequired()
                    .HasColumnName("Prompt_For_Size")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RemoteOrderAvailability)
                    .HasColumnName("Remote_Order_Availability")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.RoyaltyYn)
                    .HasColumnName("Royalty_YN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SpecialtyPizza)
                    .HasColumnName("Specialty_Pizza")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode)
                    .HasColumnName("Status_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Taxable).HasDefaultValueSql("((0))");

                entity.Property(e => e.TextColor)
                    .HasColumnName("Text_Color")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TrackEmployeeSales).HasColumnName("Track_Employee_Sales");
            });

            modelBuilder.Entity<MenuOptionGroups>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MenuOptionGroupCode })
                    .IsClustered(false);

                entity.ToTable("Menu_Option_Groups");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => e.MenuCategoryCode)
                    .HasName("Menu_Category_Code");

                entity.HasIndex(e => e.MenuOptionGroupCode)
                    .HasName("Menu_Option_Code");

                entity.HasIndex(e => e.StatusCode)
                    .HasName("Status_CodesMenu_Option_Groups");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuOptionGroupCode)
                    .HasColumnName("Menu_Option_Group_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("Display_Order")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ForSale)
                    .HasColumnName("For_Sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ImageName)
                    .HasColumnName("Image_Name")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCategoryCode)
                    .HasColumnName("Menu_Category_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCategoryDisplayOrder)
                    .HasColumnName("Menu_Category_Display_Order")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderDescription)
                    .HasColumnName("Order_Description")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode).HasColumnName("Status_Code");

                entity.Property(e => e.TextColor)
                    .HasColumnName("Text_Color")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MenuOptionPriceByItem>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MenuCode, e.SizeCode, e.MenuOptionGroupCode, e.SubMenuCode, e.SubSizeCode })
                    .IsClustered(false);

                entity.ToTable("Menu_Option_Price_By_Item");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => e.MenuCode)
                    .HasName("Menu_Code");

                entity.HasIndex(e => e.MenuOptionGroupCode)
                    .HasName("Menu_Option_Group_Code");

                entity.HasIndex(e => e.SizeCode)
                    .HasName("Size_Code");

                entity.HasIndex(e => e.SubMenuCode)
                    .HasName("Menu_Option_Code");

                entity.HasIndex(e => e.SubSizeCode)
                    .HasName("Sub_Size_Code");

                entity.HasIndex(e => new { e.LocationCode, e.MenuCode, e.SizeCode })
                    .HasName("Menu_Item_SizesMenu_Option_Price_By_Item");

                entity.HasIndex(e => new { e.LocationCode, e.MenuOptionGroupCode, e.SubMenuCode, e.SubSizeCode })
                    .HasName("Menu_Options_Group_Menu_OptionsMenu_Option_Price_By_Item");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SizeCode)
                    .HasColumnName("Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuOptionGroupCode)
                    .HasColumnName("Menu_Option_Group_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SubMenuCode)
                    .HasColumnName("Sub_Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SubSizeCode)
                    .HasColumnName("Sub_Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Price2).HasColumnType("money");
            });

            modelBuilder.Entity<MenuOptionPriceByNumber>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MenuCode, e.SizeCode, e.MenuOptionGroupCode, e.OptionNumber })
                    .IsClustered(false);

                entity.ToTable("Menu_Option_Price_By_Number");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => e.MenuCode)
                    .HasName("Menu_Code");

                entity.HasIndex(e => e.MenuOptionGroupCode)
                    .HasName("Menu_Option_Group_Code");

                entity.HasIndex(e => e.OptionNumber)
                    .HasName("Menu_Option_Code");

                entity.HasIndex(e => e.SizeCode)
                    .HasName("Size_Code");

                entity.HasIndex(e => new { e.LocationCode, e.MenuCode, e.MenuOptionGroupCode })
                    .HasName("Menu_Item_Option_GroupsMenu_Option_Price_By_Number1");

                entity.HasIndex(e => new { e.LocationCode, e.MenuCode, e.SizeCode })
                    .HasName("Menu_Item_SizesMenu_Option_Price_By_Number");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SizeCode)
                    .HasColumnName("Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuOptionGroupCode)
                    .HasColumnName("Menu_Option_Group_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OptionNumber).HasColumnName("Option_Number");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Price2).HasColumnType("money");
            });

            modelBuilder.Entity<MenuOptionPriceDuplicateToppings>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MenuCode, e.SizeCode, e.MenuOptionGroupCode, e.AmountCode, e.Cheese })
                    .HasName("aaaaaMenu_Option_Price_Duplicate_Toppings_PK")
                    .IsClustered(false);

                entity.ToTable("Menu_Option_Price_Duplicate_Toppings");

                entity.HasIndex(e => e.AmountCode)
                    .HasName("Menu_Option_Code");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => e.MenuCode)
                    .HasName("Menu_Code");

                entity.HasIndex(e => e.MenuOptionGroupCode)
                    .HasName("Menu_Option_Group_Code");

                entity.HasIndex(e => e.SizeCode)
                    .HasName("Size_Code");

                entity.HasIndex(e => new { e.LocationCode, e.MenuCode, e.MenuOptionGroupCode })
                    .HasName("Menu_Item_Option_GroupsMenu_Option_Price_Duplicate_Toppings1");

                entity.HasIndex(e => new { e.LocationCode, e.MenuCode, e.SizeCode })
                    .HasName("Menu_Item_SizesMenu_Option_Price_Duplicate_Toppings");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SizeCode)
                    .HasColumnName("Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuOptionGroupCode)
                    .HasColumnName("Menu_Option_Group_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AmountCode)
                    .HasColumnName("Amount_Code")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DoublePrice)
                    .HasColumnName("Double_Price")
                    .HasColumnType("money");

                entity.Property(e => e.SinglePrice)
                    .HasColumnName("Single_Price")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<MenuOptionsGroupMenuOptions>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MenuOptionGroupCode, e.MenuCode, e.SizeCode })
                    .HasName("PK_Menu_Options_Group_Menu")
                    .IsClustered(false);

                entity.ToTable("Menu_Options_Group_Menu_Options");

                entity.HasIndex(e => new { e.LocationCode, e.MenuOptionGroupCode })
                    .HasName("Menu_Option_GroupsMenu_Options_Group_Menu_Options");

                entity.HasIndex(e => new { e.LocationCode, e.MenuCode, e.SizeCode })
                    .HasName("Menu_Item_SizesMenu_Options_Group_Menu_Options");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuOptionGroupCode)
                    .HasColumnName("Menu_Option_Group_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SizeCode)
                    .HasColumnName("Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("Display_Order")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KitchenDisplayOrder)
                    .HasColumnName("Kitchen_Display_Order")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Price).HasColumnType("money");
            });

            modelBuilder.Entity<MenuTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MenuTypeId })
                    .IsClustered(false);

                entity.ToTable("Menu_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuTypeId).HasColumnName("Menu_Type_ID");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultMenuCategoryCode)
                    .HasColumnName("Default_Menu_Category_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("Display_Order")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MenuTypeCode)
                    .IsRequired()
                    .HasColumnName("Menu_Type_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuTypeImage).HasColumnName("Menu_Type_Image");

                entity.Property(e => e.OrderDescription)
                    .HasColumnName("Order_Description")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TextColor)
                    .HasColumnName("Text_Color")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MenuTypesCategories>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MenuTypeId, e.MenuCategoryCode })
                    .IsClustered(false);

                entity.ToTable("Menu_Types_Categories");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuTypeId).HasColumnName("Menu_Type_ID");

                entity.Property(e => e.MenuCategoryCode)
                    .HasColumnName("Menu_Category_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCategoryDisplayOrder).HasColumnName("Menu_Category_Display_Order");
            });

            modelBuilder.Entity<MileageControl>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MileageTypeCode })
                    .IsClustered(false);

                entity.ToTable("Mileage_Control");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MileageTypeCode).HasColumnName("Mileage_Type_Code");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultMileageRate1)
                    .HasColumnName("Default_Mileage_Rate_1")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DefaultMileageRate2)
                    .HasColumnName("Default_Mileage_Rate_2")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxIrsMileageRate)
                    .HasColumnName("Max_IRS_Mileage_Rate")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MinIrsMileageRate)
                    .HasColumnName("Min_IRS_Mileage_Rate")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PercentForCarTop)
                    .HasColumnName("Percent_For_Car_Top")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MileageTypeSalesRanges>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MileageTypeCode, e.BeginRange, e.EndRange })
                    .IsClustered(false);

                entity.ToTable("Mileage_Type_Sales_Ranges");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MileageTypeCode).HasColumnName("Mileage_Type_Code");

                entity.Property(e => e.BeginRange).HasColumnName("Begin_Range");

                entity.Property(e => e.EndRange).HasColumnName("End_Range");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RangeAmount).HasColumnName("Range_Amount");
            });

            modelBuilder.Entity<MisCallerId>(entity =>
            {
                entity.HasKey(e => e.MisCallerId1)
                    .IsClustered(false);

                entity.ToTable("Mis_Caller_ID");

                entity.Property(e => e.MisCallerId1)
                    .HasColumnName("mis_caller_id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CallDate)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CallDateTime).HasColumnType("datetime");

                entity.Property(e => e.CallTime)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDateTime)
                    .HasColumnName("createDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasColumnName("Customer_Name")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnName("Phone_Number")
                    .HasMaxLength(14)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MobInEmployee>(entity =>
            {
                entity.HasKey(e => new { e.MobInEmployeeId, e.FkEmployeeCode, e.AddedDate })
                    .IsClustered(false);

                entity.ToTable("MobIn_Employee");

                entity.Property(e => e.MobInEmployeeId)
                    .HasColumnName("MobIn_Employee_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FkEmployeeCode)
                    .HasColumnName("FK_Employee_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AddedDate)
                    .HasColumnName("Added_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApiCompleteTimeStamp)
                    .HasColumnName("API_Complete_Time_Stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApiInvokeTimeStamp)
                    .HasColumnName("API_Invoke_Time_Stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApiStatus).HasColumnName("API_Status");

                entity.Property(e => e.BcpStatus)
                    .HasColumnName("BCP_Status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnName("Last_Modified_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedApiStatus).HasColumnName("Modified_API_Status");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("Updated_Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<MobInEmployeeLog>(entity =>
            {
                entity.HasKey(e => new { e.FkLocationCode, e.FkEmployeeCode, e.AddedDate })
                    .IsClustered(false);

                entity.ToTable("MobIn_Employee_Log");

                entity.Property(e => e.FkLocationCode)
                    .HasColumnName("FK_Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FkEmployeeCode)
                    .HasColumnName("FK_Employee_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AddedDate)
                    .HasColumnName("Added_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CallCompleteTimeStamp)
                    .HasColumnName("Call_Complete_Time_Stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.CallInvokeTimeStamp)
                    .HasColumnName("Call_Invoke_Time_Stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmployeeStatusCode)
                    .HasColumnName("Employee_Status_Code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeStatusMessage)
                    .HasColumnName("Employee_Status_Message")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FarEyeOrderMessage)
                    .HasColumnName("FarEye_Order_Message")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCallUrl)
                    .HasColumnName("Service_Call_URL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Fk)
                    .WithMany(p => p.MobInEmployeeLog)
                    .HasForeignKey(d => new { d.FkLocationCode, d.FkEmployeeCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MobIn_Employee_Log_Employee");
            });

            modelBuilder.Entity<MobInHeartBeatStatus>(entity =>
            {
                entity.ToTable("MobIn_HeartBeat_Status");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AddedDate)
                    .HasColumnName("Added_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrentBcpmode).HasColumnName("CurrentBCPMode");
            });

            modelBuilder.Entity<MobInHeartBeatStatusLog>(entity =>
            {
                entity.ToTable("MobIn_HeartBeat_Status_Log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AddedDate)
                    .HasColumnName("Added_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrentBcpmode).HasColumnName("CurrentBCPMode");

                entity.Property(e => e.FkMobInHbsId).HasColumnName("FK_MobIn_HBS_ID");
            });

            modelBuilder.Entity<MobInOrderApiStatus>(entity =>
            {
                entity.ToTable("MobIn_ORDER_API_STATUS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AddedDate)
                    .HasColumnName("Added_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FkMobInOrderStatusCode)
                    .IsRequired()
                    .HasColumnName("FK_MobIn_Order_Status_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FkVlmOrderApiStatusId)
                    .HasColumnName("FK_VLM_ORDER_API_STATUS_ID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MobInOrderApiStatusDesc)
                    .IsRequired()
                    .HasColumnName("MobIn_ORDER_API_STATUS_Desc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MobInOrderApiStatusId)
                    .IsRequired()
                    .HasColumnName("MobIn_ORDER_API_STATUS_ID")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MobInOrderCancel>(entity =>
            {
                entity.HasKey(e => new { e.MobInOrderCancelId, e.FkLocationCode, e.FkOrderNumber, e.FkOrderDate, e.AddedDate })
                    .HasName("PK_MobIn_Cancel_Order")
                    .IsClustered(false);

                entity.ToTable("MobIn_Order_Cancel");

                entity.Property(e => e.MobInOrderCancelId)
                    .HasColumnName("MobIn_Order_Cancel_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FkLocationCode)
                    .HasColumnName("FK_Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FkOrderNumber).HasColumnName("FK_Order_Number");

                entity.Property(e => e.FkOrderDate)
                    .HasColumnName("FK_Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AddedDate)
                    .HasColumnName("Added_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApiCompleteTimeStamp)
                    .HasColumnName("API_Complete_Time_Stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApiInvokeTimeStamp)
                    .HasColumnName("API_Invoke_Time_Stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApiStatus).HasColumnName("API_Status");

                entity.Property(e => e.BcpStatus)
                    .HasColumnName("BCP_Status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("Updated_Date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Fk)
                    .WithMany(p => p.MobInOrderCancel)
                    .HasForeignKey(d => new { d.FkLocationCode, d.FkOrderDate, d.FkOrderNumber })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MobIn_Order_Cancel_Orders");
            });

            modelBuilder.Entity<MobInOrderStatus>(entity =>
            {
                entity.HasKey(e => e.MobInOrderStatusCode);

                entity.ToTable("MobIn_Order_Status");

                entity.Property(e => e.MobInOrderStatusCode)
                    .HasColumnName("MobIn_Order_Status_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AddedDate)
                    .HasColumnName("Added_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MobInOrderStatusDescription)
                    .IsRequired()
                    .HasColumnName("MobIn_Order_Status_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MobInOrders>(entity =>
            {
                entity.HasKey(e => new { e.FkLocationCode, e.FkOrderDate, e.FkOrderNumber, e.MobInOrderId, e.AddedDate })
                    .IsClustered(false);

                entity.ToTable("MobIn_Orders");

                entity.Property(e => e.FkLocationCode)
                    .HasColumnName("FK_Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FkOrderDate)
                    .HasColumnName("FK_Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FkOrderNumber).HasColumnName("FK_Order_Number");

                entity.Property(e => e.MobInOrderId)
                    .HasColumnName("MobIn_Order_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate)
                    .HasColumnName("Added_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApiStatus).HasColumnName("API_Status");

                entity.Property(e => e.BcpStatus).HasColumnName("BCP_Status");

                entity.Property(e => e.FkEmployeeCode)
                    .HasColumnName("FK_Employee_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FkMobInOrderStatusCode)
                    .HasColumnName("FK_MobIn_Order_Status_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsNullTimeStamp).HasColumnName("IsNull_Time_Stamp");

                entity.Property(e => e.OrderAssignMessage)
                    .HasColumnName("Order_Assign_Message")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDeliveredMessage)
                    .HasColumnName("Order_Delivered_Message")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDeliveryPosTimeStamp)
                    .HasColumnName("Order_Delivery_POS_Time_Stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderDeliveryTimeStamp)
                    .HasColumnName("Order_Delivery_Time_Stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderInMessage)
                    .HasColumnName("Order_In_Message")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OrderInTimeStamp)
                    .HasColumnName("Order_In_Time_Stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderOutMessage)
                    .HasColumnName("Order_Out_Message")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OrderOutTimeStamp)
                    .HasColumnName("Order_Out_Time_Stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderReachedMessage)
                    .HasColumnName("Order_Reached_Message")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OrderReachedPosTimeStamp)
                    .HasColumnName("Order_Reached_POS_Time_Stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderReachedTimeStamp)
                    .HasColumnName("Order_Reached_Time_Stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderReturnPosTimeStamp)
                    .HasColumnName("Order_Return_POS_Time_Stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderRoutePosTimeStamp)
                    .HasColumnName("Order_Route_POS_Time_Stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderStatusCode).HasColumnName("Order_Status_Code");

                entity.Property(e => e.PosStatus).HasColumnName("POS_Status");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("Updated_Date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.FkMobInOrderStatusCodeNavigation)
                    .WithMany(p => p.MobInOrders)
                    .HasForeignKey(d => d.FkMobInOrderStatusCode)
                    .HasConstraintName("FK_MobIn_Orders_MobIn_Order_Status");

                entity.HasOne(d => d.Fk)
                    .WithMany(p => p.MobInOrders)
                    .HasForeignKey(d => new { d.FkLocationCode, d.FkOrderDate, d.FkOrderNumber })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MobIn_Orders_Orders");
            });

            modelBuilder.Entity<MobInOrdersLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MobIn_Orders_Log");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AddedDate)
                    .HasColumnName("Added_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CallCompleteTimeStamp)
                    .HasColumnName("Call_Complete_Time_Stamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],'1900-01-01 00:00:00.000'))");

                entity.Property(e => e.CallInvokeTimeStamp)
                    .HasColumnName("Call_Invoke_Time_Stamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],'1900-01-01 00:00:00.000'))");

                entity.Property(e => e.FarEyeOrderMessage)
                    .HasColumnName("FarEye_Order_Message")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FkLocationCode)
                    .IsRequired()
                    .HasColumnName("FK_Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FkOrderDate)
                    .HasColumnName("FK_Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FkOrderNumber).HasColumnName("FK_Order_Number");

                entity.Property(e => e.LogType).HasColumnName("Log_Type");

                entity.Property(e => e.OrderStatusCode)
                    .IsRequired()
                    .HasColumnName("Order_Status_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderStatusMessage)
                    .HasColumnName("Order_Status_Message")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RequestData)
                    .HasColumnName("Request_Data")
                    .IsUnicode(false);

                entity.Property(e => e.ResponseData)
                    .HasColumnName("Response_Data")
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCallUrl)
                    .HasColumnName("Service_Call_URL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Fk)
                    .WithMany(p => p.MobInOrdersLog)
                    .HasForeignKey(d => new { d.FkLocationCode, d.FkOrderDate, d.FkOrderNumber })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MobIn_Orders_Log_Orders");
            });

            modelBuilder.Entity<Months>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.MonthValue })
                    .IsClustered(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.MonthValue).HasColumnName("Month_Value");

                entity.Property(e => e.DefaultText)
                    .IsRequired()
                    .HasColumnName("Default_Text")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedText)
                    .IsRequired()
                    .HasColumnName("Modified_Text")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MuGroupDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mu_Group_Detail");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Groupname)
                    .HasColumnName("groupname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Storedesc)
                    .HasColumnName("storedesc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Storename)
                    .IsRequired()
                    .HasColumnName("storename")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NextNumber>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.TableName, e.FieldName })
                    .IsClustered(false);

                entity.ToTable("Next_Number");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasColumnName("Table_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FieldName)
                    .HasColumnName("Field_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NextNum).HasColumnName("Next_Num");
            });

            modelBuilder.Entity<NoSaleTransactions>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.WorkstationId, e.DeviceId, e.AddedBy, e.Added });

                entity.ToTable("No_Sale_Transactions");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.WorkstationId).HasColumnName("Workstation_ID");

                entity.Property(e => e.DeviceId).HasColumnName("Device_ID");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<NoteCodes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.NoteCode });

                entity.ToTable("Note_Codes");

                entity.HasIndex(e => e.NoteCode)
                    .HasName("Notes_Code");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NoteCode)
                    .HasColumnName("Note_Code")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Notes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.NotesCode, e.KeyField, e.EntryDate, e.Sequence })
                    .IsClustered(false);

                entity.HasIndex(e => e.NotesCode)
                    .HasName("Note_CodesNotes");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NotesCode)
                    .HasColumnName("Notes_Code")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.KeyField)
                    .HasColumnName("Key_Field")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate)
                    .HasColumnName("Entry_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Notes1)
                    .HasColumnName("Notes")
                    .HasMaxLength(3500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NutritionalItems>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.NutritionalItemCode });

                entity.ToTable("Nutritional_Items");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NutritionalItemCode)
                    .HasColumnName("Nutritional_Item_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");

                entity.Property(e => e.NutritionalItemDescription)
                    .IsRequired()
                    .HasColumnName("Nutritional_Item_Description")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RdaQuantity).HasColumnName("RDA_Quantity");

                entity.Property(e => e.RdaUnit)
                    .IsRequired()
                    .HasColumnName("RDA_Unit")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShowPercentageOnLabel).HasColumnName("Show_Percentage_On_Label");

                entity.Property(e => e.ShowValueOnLabel).HasColumnName("Show_Value_On_Label");
            });

            modelBuilder.Entity<OddEvenTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.OddEven });

                entity.ToTable("Odd_Even_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OddEven).HasColumnName("Odd_Even");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");

                entity.Property(e => e.EnglishTextDescription)
                    .IsRequired()
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OfflineLog>(entity =>
            {
                entity.HasKey(e => new { e.OrderNumber, e.OrderDate });

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8);

                entity.Property(e => e.MannualInvoice)
                    .IsRequired()
                    .HasColumnName("Mannual_Invoice")
                    .HasMaxLength(100);

                entity.Property(e => e.PosInvoice)
                    .IsRequired()
                    .HasColumnName("Pos_Invoice")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OfflineLogReason>(entity =>
            {
                entity.HasKey(e => new { e.TicketId, e.LocationCode });

                entity.ToTable("OfflineLog_Reason");

                entity.Property(e => e.TicketId).HasMaxLength(60);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8);

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.DownDate).HasColumnType("datetime");

                entity.Property(e => e.DownTime).HasMaxLength(50);

                entity.Property(e => e.ManagerName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpDate).HasColumnType("datetime");

                entity.Property(e => e.Uptime).HasMaxLength(50);
            });

            modelBuilder.Entity<OloOrders>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OLO_Orders");

                entity.Property(e => e.ActualOrderDate)
                    .HasColumnName("Actual_Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApiResponceMessage)
                    .HasColumnName("API_Responce_Message")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ApiStatus)
                    .HasColumnName("API_Status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CancelApiStatus)
                    .HasColumnName("Cancel_API_Status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CancelPunchTimeStamp)
                    .HasColumnName("Cancel_punch_Time_Stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.DelayedOrder).HasColumnName("Delayed_Order");

                entity.Property(e => e.DeliveryApiStatus)
                    .HasColumnName("Delivery_API_Status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeliveryTimeStamp)
                    .HasColumnName("Delivery_Time_Stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.DriverId)
                    .HasColumnName("Driver_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExceptionMessage).HasColumnName("Exception_Message");

                entity.Property(e => e.KitchenApiStatus)
                    .HasColumnName("Kitchen_API_Status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KitchenPunchTimeStamp)
                    .HasColumnName("Kitchen_punch_Time_Stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderAmount)
                    .HasColumnName("Order_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("date");

                entity.Property(e => e.OrderInApiStatus)
                    .HasColumnName("Order_In_API_Status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderInTimeStamp)
                    .HasColumnName("Order_In_Time_Stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.OrderOutApiStatus)
                    .HasColumnName("Order_Out_API_Status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderOutTimeStamp)
                    .HasColumnName("Order_Out_Time_Stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderSaved)
                    .HasColumnName("Order_Saved")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderStatusCode).HasColumnName("Order_Status_Code");

                entity.Property(e => e.OrderTypeCode)
                    .HasColumnName("Order_Type_Code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ReachedGateApiStatus)
                    .HasColumnName("Reached_Gate_API_Status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReachedGateTimeStamp)
                    .HasColumnName("Reached_Gate_Time_Stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.TentNumber)
                    .IsRequired()
                    .HasColumnName("Tent_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OloOrdersSyncLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OLO_Orders_Sync_Log");

                entity.HasIndex(e => new { e.LocationCode, e.OrderDate, e.OrderNumber, e.OrderStatusCode, e.FailCount })
                    .HasName("idx_OLO_Orders_Sync_Log");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ApiData)
                    .HasColumnName("API_Data")
                    .IsUnicode(false);

                entity.Property(e => e.CallInvokeTimeStamp)
                    .HasColumnName("Call_Invoke_Time_Stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.FailCount)
                    .HasColumnName("Fail_Count")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OloOrderMessage)
                    .HasColumnName("OLO_Order_Message")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.OrderStatusCode)
                    .HasColumnName("Order_Status_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCallUrl)
                    .HasColumnName("Service_Call_URL")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OloOts>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderDate, e.OrderNumber, e.OtsNumber })
                    .HasName("OLO_OTS_PK");

                entity.ToTable("OLO_OTS");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.OtsNumber)
                    .HasColumnName("OTS_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.OloOts)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OLO_OTS_Location_Codes");

                entity.HasOne(d => d.Orders)
                    .WithMany(p => p.OloOts)
                    .HasForeignKey(d => new { d.LocationCode, d.OrderDate, d.OrderNumber })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OLO_OTS_Orders");
            });

            modelBuilder.Entity<OloRefundOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OLO_Refund_Order");

                entity.Property(e => e.AddedDate)
                    .HasColumnName("Added_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ErrorStatus)
                    .IsRequired()
                    .HasColumnName("Error_Status")
                    .HasMaxLength(500);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber)
                    .IsRequired()
                    .HasColumnName("Order_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<OloSyncServiceError>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OLO_Sync_Service_Error");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("date");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.OrderStatusCode)
                    .HasColumnName("Order_Status_Code")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTypeCode)
                    .HasColumnName("Order_Type_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceErrorEvent)
                    .HasColumnName("Service_Error_Event")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceErrorMessage)
                    .HasColumnName("Service_Error_Message")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.TentNumber)
                    .HasColumnName("Tent_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OlocancelorderLog>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderDate, e.OrderNumber })
                    .HasName("OLOCancelorder_log4");

                entity.ToTable("OLOCancelorder_log");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("location_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("Order_number")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.ActualOrderDate)
                    .HasColumnName("Actual_order_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CancelApiDate)
                    .HasColumnName("Cancel_Api_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CancelApiStatus)
                    .HasColumnName("Cancel_api_status")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ErrMessage)
                    .HasColumnName("Err_Message")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("Last_Updated_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderCancelDate)
                    .HasColumnName("order_cancel_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RefundApiDate)
                    .HasColumnName("Refund_Api_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RefundApiStatus)
                    .HasColumnName("Refund_api_status")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.RetryCount)
                    .HasColumnName("Retry_count")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.TentNumber)
                    .IsRequired()
                    .HasColumnName("Tent_number")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OnsCoupons>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ONS_COUPONS");

                entity.Property(e => e.Added)
                    .HasColumnName("ADDED")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.AddedBy)
                    .HasColumnName("ADDED_BY")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Adjustment).HasColumnName("ADJUSTMENT");

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("money");

                entity.Property(e => e.AnyItem).HasColumnName("ANY_ITEM");

                entity.Property(e => e.BeginDate)
                    .HasColumnName("BEGIN_DATE")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.CouponCode)
                    .HasColumnName("COUPON_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CouponTypeCode).HasColumnName("COUPON_TYPE_CODE");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasColumnName("DISPLAY_ORDER");

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.EntireOrder).HasColumnName("ENTIRE_ORDER");

                entity.Property(e => e.GiftCardActivationDiscount).HasColumnName("GIFT_CARD_ACTIVATION_DISCOUNT");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("LOCATION_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MinPrice)
                    .HasColumnName("MIN_PRICE")
                    .HasColumnType("money");

                entity.Property(e => e.ProtectCoupon).HasColumnName("PROTECT_COUPON");

                entity.Property(e => e.RemoteOrderAvailability).HasColumnName("REMOTE_ORDER_AVAILABILITY");

                entity.Property(e => e.StatusCode).HasColumnName("STATUS_CODE");

                entity.Property(e => e.Taxable).HasColumnName("TAXABLE");
            });

            modelBuilder.Entity<OnsInventoryItems>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ONS_INVENTORY_ITEMS");

                entity.Property(e => e.Added)
                    .HasColumnName("ADDED")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.AddedBy)
                    .HasColumnName("ADDED_BY")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CountOrder).HasColumnName("COUNT_ORDER");

                entity.Property(e => e.CountTypeCode).HasColumnName("COUNT_TYPE_CODE");

                entity.Property(e => e.CountUnit)
                    .HasColumnName("COUNT_UNIT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasColumnName("DISPLAY_ORDER");

                entity.Property(e => e.InstructionsImage).HasColumnName("INSTRUCTIONS_IMAGE");

                entity.Property(e => e.InventoryCode)
                    .HasColumnName("INVENTORY_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryItemTypeCode).HasColumnName("INVENTORY_ITEM_TYPE_CODE");

                entity.Property(e => e.InventoryTypeCode)
                    .HasColumnName("INVENTORY_TYPE_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("LOCATION_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MaxStockingLevel).HasColumnName("MAX_STOCKING_LEVEL");

                entity.Property(e => e.MinStockingLevel).HasColumnName("MIN_STOCKING_LEVEL");

                entity.Property(e => e.OrderUnit)
                    .HasColumnName("ORDER_UNIT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PortionCount).HasColumnName("PORTION_COUNT");

                entity.Property(e => e.PortionUnit)
                    .HasColumnName("PORTION_UNIT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PrepDays).HasColumnName("PREP_DAYS");

                entity.Property(e => e.PrepHours).HasColumnName("PREP_HOURS");

                entity.Property(e => e.PrepMinutes).HasColumnName("PREP_MINUTES");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("money");

                entity.Property(e => e.ReadyDays).HasColumnName("READY_DAYS");

                entity.Property(e => e.ReadyHours).HasColumnName("READY_HOURS");

                entity.Property(e => e.ReadyMinutes).HasColumnName("READY_MINUTES");

                entity.Property(e => e.ShelfLifeDays).HasColumnName("SHELF_LIFE_DAYS");

                entity.Property(e => e.ShelfLifeHours).HasColumnName("SHELF_LIFE_HOURS");

                entity.Property(e => e.ShelfLifeMinutes).HasColumnName("SHELF_LIFE_MINUTES");

                entity.Property(e => e.StatusCode).HasColumnName("STATUS_CODE");

                entity.Property(e => e.VendorCode)
                    .HasColumnName("VENDOR_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VendorItemCode)
                    .HasColumnName("VENDOR_ITEM_CODE")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OnsMenuItemCategories>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ONS_MENU_ITEM_CATEGORIES");

                entity.Property(e => e.Added)
                    .HasColumnName("ADDED")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.AddedBy)
                    .HasColumnName("ADDED_BY")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("LOCATION_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCategoryCode)
                    .HasColumnName("MENU_CATEGORY_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCategoryDisplayOrder).HasColumnName("MENU_CATEGORY_DISPLAY_ORDER");

                entity.Property(e => e.MenuCode)
                    .HasColumnName("MENU_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OnsMenuItemCoupons>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ONS_MENU_ITEM_COUPONS");

                entity.Property(e => e.Added)
                    .HasColumnName("ADDED")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.AddedBy)
                    .HasColumnName("ADDED_BY")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CouponCode)
                    .HasColumnName("COUPON_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("LOCATION_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("MENU_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SizeCode)
                    .HasColumnName("SIZE_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OnsMenuItemIfc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ONS_MENU_ITEM_IFC");

                entity.Property(e => e.Added)
                    .HasColumnName("ADDED")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.AddedBy)
                    .HasColumnName("ADDED_BY")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.ApplyCarryout).HasColumnName("APPLY_CARRYOUT");

                entity.Property(e => e.ApplyDelivery).HasColumnName("APPLY_DELIVERY");

                entity.Property(e => e.ApplyDinein).HasColumnName("APPLY_DINEIN");

                entity.Property(e => e.ApplyPickup).HasColumnName("APPLY_PICKUP");

                entity.Property(e => e.InventoryCode)
                    .HasColumnName("INVENTORY_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("LOCATION_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("MENU_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SizeCode)
                    .HasColumnName("SIZE_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OnsMenuItemIfcToppings>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ONS_MENU_ITEM_IFC_TOPPINGS");

                entity.Property(e => e.Added)
                    .HasColumnName("ADDED")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.AddedBy)
                    .HasColumnName("ADDED_BY")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DoubleAmount).HasColumnName("DOUBLE_AMOUNT");

                entity.Property(e => e.ExtraAmount).HasColumnName("EXTRA_AMOUNT");

                entity.Property(e => e.InventoryCode)
                    .HasColumnName("INVENTORY_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LightAmount).HasColumnName("LIGHT_AMOUNT");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("LOCATION_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("MENU_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfToppings).HasColumnName("NUMBER_OF_TOPPINGS");

                entity.Property(e => e.SingleAmount).HasColumnName("SINGLE_AMOUNT");

                entity.Property(e => e.SizeCode)
                    .HasColumnName("SIZE_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TripleAmount).HasColumnName("TRIPLE_AMOUNT");
            });

            modelBuilder.Entity<OnsMenuItemSizes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ONS_MENU_ITEM_SIZES");

                entity.Property(e => e.Added)
                    .HasColumnName("ADDED")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.AddedBy)
                    .HasColumnName("ADDED_BY")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Barcode)
                    .HasColumnName("BARCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BottleDeposit)
                    .HasColumnName("BOTTLE_DEPOSIT")
                    .HasColumnType("money");

                entity.Property(e => e.DefaultSize).HasColumnName("DEFAULT_SIZE");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasColumnName("DISPLAY_ORDER");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("LOCATION_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MaxAmountOpenValueCard)
                    .HasColumnName("MAX_AMOUNT_OPEN_VALUE_CARD")
                    .HasColumnType("money");

                entity.Property(e => e.MenuCode)
                    .HasColumnName("MENU_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MinAmountOpenValueCard)
                    .HasColumnName("MIN_AMOUNT_OPEN_VALUE_CARD")
                    .HasColumnType("money");

                entity.Property(e => e.OpenValueCard).HasColumnName("OPEN_VALUE_CARD");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("money");

                entity.Property(e => e.Price2)
                    .HasColumnName("PRICE2")
                    .HasColumnType("money");

                entity.Property(e => e.PriceByWeight).HasColumnName("PRICE_BY_WEIGHT");

                entity.Property(e => e.SizeCode)
                    .HasColumnName("SIZE_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode).HasColumnName("STATUS_CODE");

                entity.Property(e => e.TareWeight).HasColumnName("TARE_WEIGHT");
            });

            modelBuilder.Entity<OnsMenuItemSizesTaxCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ONS_MENU_ITEM_SIZES_TAX_CATEGORY");

                entity.Property(e => e.Added)
                    .HasColumnName("ADDED")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.AddedBy)
                    .HasColumnName("ADDED_BY")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("LOCATION_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("MENU_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SizeCode)
                    .HasColumnName("SIZE_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Tax1TaxableAmount)
                    .HasColumnName("TAX_1_TAXABLE_AMOUNT")
                    .HasColumnType("money");

                entity.Property(e => e.Tax2TaxableAmount)
                    .HasColumnName("TAX_2_TAXABLE_AMOUNT")
                    .HasColumnType("money");

                entity.Property(e => e.Tax3TaxableAmount)
                    .HasColumnName("TAX_3_TAXABLE_AMOUNT")
                    .HasColumnType("money");

                entity.Property(e => e.Tax4TaxableAmount)
                    .HasColumnName("TAX_4_TAXABLE_AMOUNT")
                    .HasColumnType("money");

                entity.Property(e => e.TaxCategoryId).HasColumnName("TAX_CATEGORY_ID");

                entity.Property(e => e.TaxableByMargin).HasColumnName("TAXABLE_BY_MARGIN");
            });

            modelBuilder.Entity<OnsMenuItems>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ONS_MENU_ITEMS");

                entity.Property(e => e.Added)
                    .HasColumnName("ADDED")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.AddedBy)
                    .HasColumnName("ADDED_BY")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ComboMeal).HasColumnName("COMBO_MEAL");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasColumnName("DISPLAY_ORDER");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("LOCATION_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCategoryCode)
                    .HasColumnName("MENU_CATEGORY_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCategoryDisplayOrder).HasColumnName("MENU_CATEGORY_DISPLAY_ORDER");

                entity.Property(e => e.MenuCode)
                    .HasColumnName("MENU_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuItemImage).HasColumnName("MENU_ITEM_IMAGE");

                entity.Property(e => e.MenuItemTypeCode).HasColumnName("MENU_ITEM_TYPE_CODE");

                entity.Property(e => e.OrderDescription)
                    .HasColumnName("ORDER_DESCRIPTION")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PizzaYn).HasColumnName("PIZZA_YN");

                entity.Property(e => e.PreparedYn).HasColumnName("PREPARED_YN");

                entity.Property(e => e.PrintLabel).HasColumnName("PRINT_LABEL");

                entity.Property(e => e.PrintNutritionalLabel).HasColumnName("PRINT_NUTRITIONAL_LABEL");

                entity.Property(e => e.PrintTicket).HasColumnName("PRINT_TICKET");

                entity.Property(e => e.PromptForSize).HasColumnName("PROMPT_FOR_SIZE");

                entity.Property(e => e.RemoteOrderAvailability).HasColumnName("REMOTE_ORDER_AVAILABILITY");

                entity.Property(e => e.RoyaltyYn).HasColumnName("ROYALTY_YN");

                entity.Property(e => e.SpecialtyPizza).HasColumnName("SPECIALTY_PIZZA");

                entity.Property(e => e.StatusCode).HasColumnName("STATUS_CODE");

                entity.Property(e => e.Taxable).HasColumnName("TAXABLE");

                entity.Property(e => e.TextColor).HasColumnName("TEXT_COLOR");

                entity.Property(e => e.TrackEmployeeSales).HasColumnName("TRACK_EMPLOYEE_SALES");
            });

            modelBuilder.Entity<OnsMenuOptionPriceByItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ONS_MENU_OPTION_PRICE_BY_ITEM");

                entity.Property(e => e.Added)
                    .HasColumnName("ADDED")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.AddedBy)
                    .HasColumnName("ADDED_BY")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("LOCATION_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("MENU_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuOptionGroupCode)
                    .HasColumnName("MENU_OPTION_GROUP_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("money");

                entity.Property(e => e.Price2)
                    .HasColumnName("PRICE2")
                    .HasColumnType("money");

                entity.Property(e => e.SizeCode)
                    .HasColumnName("SIZE_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SubMenuCode)
                    .HasColumnName("SUB_MENU_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SubSizeCode)
                    .HasColumnName("SUB_SIZE_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OnsVendor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ONS_VENDOR");

                entity.Property(e => e.Added)
                    .HasColumnName("ADDED")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.AddedBy)
                    .HasColumnName("ADDED_BY")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .HasColumnName("ADDRESS1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("ADDRESS2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("COMPANY_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("CONTACT_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("LOCATION_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("POSTAL_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasColumnName("REGION")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode).HasColumnName("STATUS_CODE");

                entity.Property(e => e.Telephone)
                    .HasColumnName("TELEPHONE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCode)
                    .HasColumnName("VENDOR_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VendorType)
                    .HasColumnName("VENDOR_TYPE")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderCoupons>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderDate, e.OrderNumber, e.OrdCpnNbr });

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.OrdCpnBlockModifyDiscountAmt).HasColumnType("money");

                entity.Property(e => e.OrdCpnCampaignCode).HasMaxLength(12);

                entity.Property(e => e.OrdCpnCampaignCodePhoneNumber).HasMaxLength(15);

                entity.Property(e => e.OrdCpnCouponDiscountAmt).HasColumnType("money");

                entity.Property(e => e.OrdCpnDescriptiveText).HasMaxLength(50);

                entity.Property(e => e.OrdCpnExtendedCode).HasMaxLength(8);

                entity.Property(e => e.OrdCpnOverrideValue).HasColumnType("money");

                entity.Property(e => e.OrdCpnUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.OrdCpnUpdateUserCode).HasMaxLength(8);
            });

            modelBuilder.Entity<OrderCreditCards>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderNumber, e.OrderDate, e.PaymentLineNumber })
                    .IsClustered(false);

                entity.ToTable("Order_Credit_Cards");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaymentLineNumber)
                    .HasColumnName("Payment_Line_Number")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AcctDataSource)
                    .HasColumnName("Acct_Data_Source")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Aci)
                    .HasColumnName("ACI")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ActionCode)
                    .HasColumnName("Action_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AvsResultCode)
                    .HasColumnName("AVS_Result_Code")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AvsStreet)
                    .HasColumnName("AVS_Street")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BatchNumber)
                    .HasColumnName("Batch_Number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CardIdCode)
                    .HasColumnName("Card_ID_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CardPresentValue)
                    .HasColumnName("Card_Present_Value")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardAccount)
                    .HasColumnName("Credit_Card_Account")
                    .HasMaxLength(3000);

                entity.Property(e => e.CreditCardAmount)
                    .HasColumnName("Credit_Card_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.CreditCardApproval)
                    .HasColumnName("Credit_Card_Approval")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardExpiration)
                    .HasColumnName("Credit_Card_Expiration")
                    .HasMaxLength(3000);

                entity.Property(e => e.CreditCardId).HasColumnName("Credit_Card_ID");

                entity.Property(e => e.CreditCardTip)
                    .HasColumnName("Credit_Card_Tip")
                    .HasColumnType("money");

                entity.Property(e => e.CreditCardTransactionType).HasColumnName("Credit_Card_Transaction_Type");

                entity.Property(e => e.CreditLoss).HasColumnName("Credit_Loss");

                entity.Property(e => e.Cvv2ResultCode)
                    .HasColumnName("CVV2_Result_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EntryMethod).HasColumnName("Entry_Method");

                entity.Property(e => e.EstTipAmount)
                    .HasColumnName("Est_Tip_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.InternalSeqNumber)
                    .HasColumnName("Internal_Seq_Number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NameOnCard)
                    .HasColumnName("Name_On_Card")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NetId)
                    .HasColumnName("Net_ID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("Postal_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference_Number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseCode)
                    .HasColumnName("Response_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseText)
                    .HasColumnName("Response_Text")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ResultCode)
                    .HasColumnName("Result_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RetrievalReferenceCode)
                    .HasColumnName("Retrieval_Reference_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnCode)
                    .HasColumnName("Return_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityCode)
                    .HasColumnName("Security_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementDate)
                    .HasColumnName("Settlement_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TransItemNumber).HasColumnName("Trans_Item_Number");

                entity.Property(e => e.TransactionNumber)
                    .HasColumnName("Transaction_Number")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<OrderCreditCardsHistory>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderNumber, e.OrderDate, e.PaymentLineNumber, e.Sequence })
                    .IsClustered(false);

                entity.ToTable("Order_Credit_Cards_History");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaymentLineNumber)
                    .HasColumnName("Payment_Line_Number")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AcctDataSource)
                    .HasColumnName("Acct_Data_Source")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Aci)
                    .HasColumnName("ACI")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ActionCode)
                    .HasColumnName("Action_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AvsResultCode)
                    .HasColumnName("AVS_Result_Code")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AvsStreet)
                    .HasColumnName("AVS_Street")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BatchNumber)
                    .HasColumnName("Batch_Number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CardIdCode)
                    .HasColumnName("Card_ID_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CardPresentValue)
                    .HasColumnName("Card_Present_Value")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardAccount)
                    .HasColumnName("Credit_Card_Account")
                    .HasMaxLength(3000);

                entity.Property(e => e.CreditCardAmount)
                    .HasColumnName("Credit_Card_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.CreditCardApproval)
                    .HasColumnName("Credit_Card_Approval")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardExpiration)
                    .HasColumnName("Credit_Card_Expiration")
                    .HasMaxLength(3000);

                entity.Property(e => e.CreditCardId).HasColumnName("Credit_Card_ID");

                entity.Property(e => e.CreditCardTip)
                    .HasColumnName("Credit_Card_Tip")
                    .HasColumnType("money");

                entity.Property(e => e.CreditCardTransactionType).HasColumnName("Credit_Card_Transaction_Type");

                entity.Property(e => e.CreditLoss).HasColumnName("Credit_Loss");

                entity.Property(e => e.Cvv2ResultCode)
                    .HasColumnName("CVV2_Result_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EntryMethod).HasColumnName("Entry_Method");

                entity.Property(e => e.EstTipAmount)
                    .HasColumnName("Est_Tip_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.InternalSeqNumber)
                    .HasColumnName("Internal_Seq_Number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NameOnCard)
                    .HasColumnName("Name_On_Card")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NetId)
                    .HasColumnName("Net_ID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("Postal_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference_Number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseCode)
                    .HasColumnName("Response_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseText)
                    .HasColumnName("Response_Text")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ResultCode)
                    .HasColumnName("Result_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RetrievalReferenceCode)
                    .HasColumnName("Retrieval_Reference_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnCode)
                    .HasColumnName("Return_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityCode)
                    .HasColumnName("Security_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementDate)
                    .HasColumnName("Settlement_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TransItemNumber).HasColumnName("Trans_Item_Number");

                entity.Property(e => e.TransactionNumber)
                    .HasColumnName("Transaction_Number")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<OrderDigitalPayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Order_Digital_Payment");

                entity.Property(e => e.AcquireName)
                    .HasColumnName("Acquire_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.ApprovalCode)
                    .HasColumnName("Approval_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BatchNumber)
                    .HasColumnName("Batch_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasColumnName("Card_Number")
                    .HasMaxLength(500);

                entity.Property(e => e.CardType)
                    .HasColumnName("Card_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EdcrefId)
                    .IsRequired()
                    .HasColumnName("EDCRefId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiryDate)
                    .HasColumnName("Expiry_Date")
                    .HasMaxLength(500);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayTypeCode).HasColumnName("Pay_Type_Code");

                entity.Property(e => e.PaymentMode)
                    .HasColumnName("Payment_Mode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseCode)
                    .IsRequired()
                    .HasColumnName("Response_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseMessage)
                    .IsRequired()
                    .HasColumnName("Response_Message")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tid)
                    .HasColumnName("TID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate)
                    .HasColumnName("Transaction_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TransactionId).HasColumnName("Transaction_ID");

                entity.Property(e => e.TransactionTime).HasColumnName("Transaction_Time");
            });

            modelBuilder.Entity<OrderDriverShiftLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Order_Driver_Shift_Log");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DriverId)
                    .HasColumnName("Driver_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DriverShift)
                    .HasColumnName("Driver_Shift")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");
            });

            modelBuilder.Entity<OrderGiftCards>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderNumber, e.OrderDate, e.PaymentLineNumber })
                    .IsClustered(false);

                entity.ToTable("Order_Gift_Cards");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaymentLineNumber)
                    .HasColumnName("Payment_Line_Number")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AcctDataSource)
                    .HasColumnName("Acct_Data_Source")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Aci)
                    .HasColumnName("ACI")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ActionCode)
                    .HasColumnName("Action_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BatchNumber)
                    .HasColumnName("Batch_Number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CardIdCode)
                    .HasColumnName("Card_ID_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CardPresentValue)
                    .HasColumnName("Card_Present_Value")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreditLoss).HasColumnName("Credit_Loss");

                entity.Property(e => e.EntryMethod).HasColumnName("Entry_Method");

                entity.Property(e => e.EstTipAmount)
                    .HasColumnName("Est_Tip_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.GiftCardAccount)
                    .HasColumnName("Gift_Card_Account")
                    .HasMaxLength(3000);

                entity.Property(e => e.GiftCardAmount)
                    .HasColumnName("Gift_Card_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.GiftCardApproval)
                    .HasColumnName("Gift_Card_Approval")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GiftCardBalance)
                    .HasColumnName("Gift_Card_Balance")
                    .HasColumnType("money");

                entity.Property(e => e.GiftCardExpiration)
                    .HasColumnName("Gift_Card_Expiration")
                    .HasMaxLength(3000);

                entity.Property(e => e.GiftCardTip)
                    .HasColumnName("Gift_Card_Tip")
                    .HasColumnType("money");

                entity.Property(e => e.GiftCardTransactionType).HasColumnName("Gift_Card_Transaction_Type");

                entity.Property(e => e.InternalSeqNumber)
                    .HasColumnName("Internal_Seq_Number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NetId)
                    .HasColumnName("Net_ID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference_Number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseCode)
                    .HasColumnName("Response_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseText)
                    .HasColumnName("Response_Text")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ResultCode)
                    .HasColumnName("Result_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RetrievalReferenceCode)
                    .HasColumnName("Retrieval_Reference_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnCode)
                    .HasColumnName("Return_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityCode)
                    .HasColumnName("Security_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementDate)
                    .HasColumnName("Settlement_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TransItemNumber).HasColumnName("Trans_Item_Number");

                entity.Property(e => e.TransactionNumber)
                    .HasColumnName("Transaction_Number")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<OrderGiftCardsHistory>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderNumber, e.OrderDate, e.PaymentLineNumber, e.Sequence })
                    .IsClustered(false);

                entity.ToTable("Order_Gift_Cards_History");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaymentLineNumber)
                    .HasColumnName("Payment_Line_Number")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AcctDataSource)
                    .HasColumnName("Acct_Data_Source")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Aci)
                    .HasColumnName("ACI")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ActionCode)
                    .HasColumnName("Action_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BatchNumber)
                    .HasColumnName("Batch_Number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CardIdCode)
                    .HasColumnName("Card_ID_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CardPresentValue)
                    .HasColumnName("Card_Present_Value")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreditLoss).HasColumnName("Credit_Loss");

                entity.Property(e => e.EntryMethod).HasColumnName("Entry_Method");

                entity.Property(e => e.EstTipAmount)
                    .HasColumnName("Est_Tip_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.GiftCardAccount)
                    .HasColumnName("Gift_Card_Account")
                    .HasMaxLength(3000);

                entity.Property(e => e.GiftCardAmount)
                    .HasColumnName("Gift_Card_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.GiftCardApproval)
                    .HasColumnName("Gift_Card_Approval")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GiftCardBalance)
                    .HasColumnName("Gift_Card_Balance")
                    .HasColumnType("money");

                entity.Property(e => e.GiftCardExpiration)
                    .HasColumnName("Gift_Card_Expiration")
                    .HasMaxLength(3000);

                entity.Property(e => e.GiftCardTip)
                    .HasColumnName("Gift_Card_Tip")
                    .HasColumnType("money");

                entity.Property(e => e.GiftCardTransactionType).HasColumnName("Gift_Card_Transaction_Type");

                entity.Property(e => e.InternalSeqNumber)
                    .HasColumnName("Internal_Seq_Number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NetId)
                    .HasColumnName("Net_ID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference_Number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseCode)
                    .HasColumnName("Response_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseText)
                    .HasColumnName("Response_Text")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ResultCode)
                    .HasColumnName("Result_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RetrievalReferenceCode)
                    .HasColumnName("Retrieval_Reference_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnCode)
                    .HasColumnName("Return_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityCode)
                    .HasColumnName("Security_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransItemNumber).HasColumnName("Trans_Item_Number");

                entity.Property(e => e.TransactionNumber)
                    .HasColumnName("Transaction_Number")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<OrderLineAttributes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderDate, e.OrderNumber, e.LineNumber, e.Sequence, e.AttributeGroupCode, e.AttributeCode })
                    .IsClustered(false);

                entity.ToTable("Order_Line_Attributes");

                entity.HasIndex(e => e.AttributeGroupCode)
                    .HasName("Menu_Option_Group_Code");

                entity.HasIndex(e => e.LineNumber)
                    .HasName("Line_Num");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => new { e.LocationCode, e.AttributeGroupCode })
                    .HasName("Attribute_GroupsOrder_Line_Attributes");

                entity.HasIndex(e => new { e.LocationCode, e.OrderNumber, e.OrderDate, e.LineNumber, e.Sequence })
                    .HasName("Order_LinesOrder_Line_Attributes");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.LineNumber).HasColumnName("Line_Number");

                entity.Property(e => e.AttributeGroupCode)
                    .HasColumnName("Attribute_Group_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AttributeCode)
                    .HasColumnName("Attribute_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderLineCoupons>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderDate, e.OrderNumber, e.LineNumber, e.OrdCpnNbr });

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.LineNumber).HasColumnName("Line_Number");

                entity.Property(e => e.OrdLineCpnCouponDiscountAmt).HasColumnType("money");
            });

            modelBuilder.Entity<OrderLineGiftCards>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderNumber, e.OrderDate, e.LineNumber, e.Sequence, e.GiftCardSequence })
                    .IsClustered(false);

                entity.ToTable("Order_Line_Gift_Cards");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LineNumber)
                    .HasColumnName("Line_Number")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.GiftCardSequence).HasColumnName("Gift_Card_Sequence");

                entity.Property(e => e.ActionCode)
                    .HasColumnName("Action_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BatchNumber)
                    .HasColumnName("Batch_Number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EntryMethod).HasColumnName("Entry_Method");

                entity.Property(e => e.GiftCardAccount)
                    .HasColumnName("Gift_Card_Account")
                    .HasMaxLength(3000);

                entity.Property(e => e.GiftCardAmount)
                    .HasColumnName("Gift_Card_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.GiftCardApproval)
                    .HasColumnName("Gift_Card_Approval")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GiftCardTransactionType).HasColumnName("Gift_Card_Transaction_Type");

                entity.Property(e => e.InternalSeqNumber)
                    .HasColumnName("Internal_Seq_Number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference_Number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseCode)
                    .HasColumnName("Response_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseText)
                    .HasColumnName("Response_Text")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ResultCode)
                    .HasColumnName("Result_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RetrievalReferenceCode)
                    .HasColumnName("Retrieval_Reference_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnCode)
                    .HasColumnName("Return_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionNumber)
                    .HasColumnName("Transaction_Number")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<OrderLineIfc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Order_Line_IFC");

                entity.HasIndex(e => new { e.LocationCode, e.MenuCode })
                    .HasName("IX_Order_Line_IFC");

                entity.Property(e => e.AmountCode)
                    .IsRequired()
                    .HasColumnName("Amount_Code")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultValue).HasColumnName("Default_Value");

                entity.Property(e => e.IfcAmount)
                    .HasColumnName("IFC_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.IfcPortion).HasColumnName("IFC_Portion");

                entity.Property(e => e.InvMenuCode)
                    .HasColumnName("Inv_Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.InvSizeCode)
                    .HasColumnName("Inv_Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryCode)
                    .IsRequired()
                    .HasColumnName("Inventory_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LineNumber).HasColumnName("Line_Number");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .IsRequired()
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCodeQuantity).HasColumnName("Menu_Code_Quantity");

                entity.Property(e => e.MenuOptionGroupCode)
                    .IsRequired()
                    .HasColumnName("Menu_Option_Group_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfToppings).HasColumnName("Number_of_Toppings");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.PercentOfWhole).HasColumnName("Percent_of_Whole");

                entity.Property(e => e.PizzaPart)
                    .IsRequired()
                    .HasColumnName("Pizza_Part")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RecordType).HasColumnName("Record_Type");

                entity.Property(e => e.SizeCode)
                    .IsRequired()
                    .HasColumnName("Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ToppingPercent).HasColumnName("Topping_Percent");
            });

            modelBuilder.Entity<OrderLineOptions>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderDate, e.OrderNumber, e.LineNumber, e.Sequence, e.MenuOptionGroupCode, e.MenuCode, e.SizeCode, e.PizzaPart })
                    .IsClustered(false);

                entity.ToTable("Order_Line_Options");

                entity.HasIndex(e => e.AmountCode)
                    .HasName("Topping_Amount_CodesOrder_Line_Options");

                entity.HasIndex(e => e.LineNumber)
                    .HasName("Line_Num");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => e.MenuOptionGroupCode)
                    .HasName("Menu_Option_Group_Code");

                entity.HasIndex(e => e.SizeCode)
                    .HasName("Size_Code");

                entity.HasIndex(e => new { e.LocationCode, e.OrderNumber, e.OrderDate, e.LineNumber, e.Sequence })
                    .HasName("Order_LinesOrder_Line_Options");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.LineNumber).HasColumnName("Line_Number");

                entity.Property(e => e.MenuOptionGroupCode)
                    .HasColumnName("Menu_Option_Group_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SizeCode)
                    .HasColumnName("Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PizzaPart)
                    .HasColumnName("Pizza_Part")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AmountCode)
                    .HasColumnName("Amount_Code")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderLineReasons>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderDate, e.OrderNumber, e.LineNumber, e.Sequence, e.ReasonSequence });

                entity.ToTable("Order_Line_Reasons");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.LineNumber).HasColumnName("Line_Number");

                entity.Property(e => e.ReasonSequence).HasColumnName("Reason_Sequence");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OtherInformation)
                    .HasColumnName("Other_Information")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonGroupCode).HasColumnName("Reason_Group_Code");

                entity.Property(e => e.ReasonId).HasColumnName("Reason_ID");
            });

            modelBuilder.Entity<OrderLineSpecialtyPizzas>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderDate, e.OrderNumber, e.LineNumber, e.Sequence, e.MenuOptionGroupCode, e.PizzaPart, e.SpecialtyPizzaCode })
                    .IsClustered(false);

                entity.ToTable("Order_Line_Specialty_Pizzas");

                entity.HasIndex(e => e.LineNumber)
                    .HasName("Line_Num");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => e.MenuOptionGroupCode)
                    .HasName("Menu_Option_Group_Code");

                entity.HasIndex(e => e.SpecialtyPizzaCode)
                    .HasName("Order_Line_Specialty_PizzasSpecialty_Pizza_Code");

                entity.HasIndex(e => new { e.LocationCode, e.OrderNumber, e.OrderDate, e.LineNumber, e.Sequence })
                    .HasName("Order_LinesOrder_Line_Specialty_Pizzas");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.LineNumber).HasColumnName("Line_Number");

                entity.Property(e => e.MenuOptionGroupCode)
                    .HasColumnName("Menu_Option_Group_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PizzaPart)
                    .HasColumnName("Pizza_Part")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialtyPizzaCode)
                    .HasColumnName("Specialty_Pizza_Code")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderLineUserDefinedTax>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderDate, e.OrderNumber, e.LineNumber, e.Sequence });

                entity.ToTable("Order_Line_User_Defined_Tax");

                entity.HasIndex(e => new { e.OrderLineTaxableSale1, e.OrderLineTaxableSale2, e.OrderLineTaxableSale3, e.OrderLineTaxableSale4, e.OrderLineTax1, e.OrderLineTax2, e.OrderLineTax3, e.OrderLineTax4, e.LineNumber, e.Sequence, e.LocationCode, e.OrderDate, e.OrderNumber })
                    .HasName("IX_OrderLineUserDefinedTax_OrderNoDateLocationLineSequence");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.LineNumber).HasColumnName("Line_Number");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderLineNonTaxableSale1)
                    .HasColumnName("Order_Line_Non_Taxable_Sale1")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineNonTaxableSale2)
                    .HasColumnName("Order_Line_Non_Taxable_Sale2")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineNonTaxableSale3)
                    .HasColumnName("Order_Line_Non_Taxable_Sale3")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineNonTaxableSale4)
                    .HasColumnName("Order_Line_Non_Taxable_Sale4")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTax1)
                    .HasColumnName("Order_Line_Tax1")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTax2)
                    .HasColumnName("Order_Line_Tax2")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTax3)
                    .HasColumnName("Order_Line_Tax3")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTax4)
                    .HasColumnName("Order_Line_Tax4")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTaxableSale1)
                    .HasColumnName("Order_Line_Taxable_Sale1")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTaxableSale2)
                    .HasColumnName("Order_Line_Taxable_Sale2")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTaxableSale3)
                    .HasColumnName("Order_Line_Taxable_Sale3")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTaxableSale4)
                    .HasColumnName("Order_Line_Taxable_Sale4")
                    .HasColumnType("money");

                entity.Property(e => e.Tax1Discounted).HasColumnName("Tax_1_Discounted");

                entity.Property(e => e.Tax1ItemMinAmount)
                    .HasColumnName("Tax_1_Item_Min_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax1Rate).HasColumnName("Tax_1_Rate");

                entity.Property(e => e.Tax1TaxableAmount)
                    .HasColumnName("Tax_1_Taxable_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax2Discounted).HasColumnName("Tax_2_Discounted");

                entity.Property(e => e.Tax2ItemMinAmount)
                    .HasColumnName("Tax_2_Item_Min_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax2Rate).HasColumnName("Tax_2_Rate");

                entity.Property(e => e.Tax2TaxableAmount)
                    .HasColumnName("Tax_2_Taxable_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax3Discounted).HasColumnName("Tax_3_Discounted");

                entity.Property(e => e.Tax3ItemMinAmount)
                    .HasColumnName("Tax_3_Item_Min_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax3Rate).HasColumnName("Tax_3_Rate");

                entity.Property(e => e.Tax3TaxableAmount)
                    .HasColumnName("Tax_3_Taxable_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax4Discounted).HasColumnName("Tax_4_Discounted");

                entity.Property(e => e.Tax4ItemMinAmount)
                    .HasColumnName("Tax_4_Item_Min_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax4Rate).HasColumnName("Tax_4_Rate");

                entity.Property(e => e.Tax4TaxableAmount)
                    .HasColumnName("Tax_4_Taxable_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.TaxCategoryId).HasColumnName("Tax_Category_ID");

                entity.Property(e => e.TaxableByMargin).HasColumnName("Taxable_By_Margin");
            });

            modelBuilder.Entity<OrderLines>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderDate, e.OrderNumber, e.LineNumber, e.Sequence })
                    .HasName("aaaaaOrder_Lines_PK");

                entity.ToTable("Order_Lines");

                entity.HasIndex(e => e.ComboMenuCode)
                    .HasName("Combo_Menu_Code");

                entity.HasIndex(e => e.CouponCode)
                    .HasName("Coupon_Code");

                entity.HasIndex(e => e.CouponTypeCode)
                    .HasName("Coupon_Type_Code");

                entity.HasIndex(e => e.LineNumber)
                    .HasName("Line_Num");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => e.MenuCode)
                    .HasName("Item_Code");

                entity.HasIndex(e => e.OrderDate)
                    .HasName("Order_Date");

                entity.HasIndex(e => e.OrderLineStatusCode)
                    .HasName("Order_Status_Code");

                entity.HasIndex(e => e.OrderSavedTime)
                    .HasName("Order_Saved_Time");

                entity.HasIndex(e => e.SizeCode)
                    .HasName("Size_Code");

                entity.HasIndex(e => new { e.LocationCode, e.OrderNumber, e.OrderDate })
                    .HasName("OrdersOrder_Lines");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.LineNumber).HasColumnName("Line_Number");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BasePrice)
                    .HasColumnName("Base_Price")
                    .HasColumnType("money");

                entity.Property(e => e.BasePrice2)
                    .HasColumnName("Base_Price2")
                    .HasColumnType("money");

                entity.Property(e => e.BottleDeposit)
                    .HasColumnName("Bottle_Deposit")
                    .HasColumnType("money");

                entity.Property(e => e.CalculateIfc)
                    .IsRequired()
                    .HasColumnName("Calculate_IFC")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ComboGroup).HasColumnName("Combo_Group");

                entity.Property(e => e.ComboItemNumber).HasColumnName("Combo_Item_Number");

                entity.Property(e => e.ComboMenuCode)
                    .HasColumnName("Combo_Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ComboSizeCode)
                    .HasColumnName("Combo_Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CouponAdjustment)
                    .HasColumnName("Coupon_Adjustment")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CouponAmount)
                    .HasColumnName("Coupon_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.CouponCode)
                    .HasColumnName("Coupon_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CouponMinPrice)
                    .HasColumnName("Coupon_Min_Price")
                    .HasColumnType("money");

                entity.Property(e => e.CouponTaxable)
                    .HasColumnName("Coupon_Taxable")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CouponTypeCode).HasColumnName("Coupon_Type_Code");

                entity.Property(e => e.CreditDiscount)
                    .HasColumnName("Credit_Discount")
                    .HasColumnType("money");

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.DoublesBypassed).HasColumnName("Doubles_Bypassed");

                entity.Property(e => e.DoublesGroup).HasColumnName("Doubles_Group");

                entity.Property(e => e.InstructionString)
                    .HasColumnName("Instruction_String")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCategoryCode)
                    .HasColumnName("Menu_Category_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuItemTypeCode)
                    .HasColumnName("Menu_Item_Type_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuPrice)
                    .HasColumnName("Menu_Price")
                    .HasColumnType("money");

                entity.Property(e => e.MenuPrice2)
                    .HasColumnName("Menu_Price2")
                    .HasColumnType("money");

                entity.Property(e => e.MenuTypeId)
                    .HasColumnName("Menu_Type_ID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OrderCouponAmount)
                    .HasColumnName("Order_Coupon_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineCouponAmount)
                    .HasColumnName("Order_Line_Coupon_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineNoTaxDiscount)
                    .HasColumnName("Order_Line_No_Tax_Discount")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineNonTaxableSale)
                    .HasColumnName("Order_Line_Non_Taxable_Sale")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineStatusCode)
                    .HasColumnName("Order_Line_Status_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OrderLineTax1)
                    .HasColumnName("Order_Line_Tax1")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTax2)
                    .HasColumnName("Order_Line_Tax2")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTaxDiscount)
                    .HasColumnName("Order_Line_Tax_Discount")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTaxableSale1)
                    .HasColumnName("Order_Line_Taxable_Sale1")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTaxableSale2)
                    .HasColumnName("Order_Line_Taxable_Sale2")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTotal)
                    .HasColumnName("Order_Line_Total")
                    .HasColumnType("money");

                entity.Property(e => e.OrderNoTaxDiscount)
                    .HasColumnName("Order_No_Tax_Discount")
                    .HasColumnType("money");

                entity.Property(e => e.OrderSavedTime)
                    .HasColumnName("Order_Saved_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderTaxDiscount)
                    .HasColumnName("Order_Tax_Discount")
                    .HasColumnType("money");

                entity.Property(e => e.OrigMenuCode)
                    .HasColumnName("Orig_Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OvenTime)
                    .HasColumnName("Oven_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.SizeCode)
                    .HasColumnName("Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ToppingCodes)
                    .HasColumnName("Topping_Codes")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ToppingCount).HasColumnName("Topping_Count");

                entity.Property(e => e.ToppingDescriptions)
                    .HasColumnName("Topping_Descriptions")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ToppingString)
                    .HasColumnName("Topping_String")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderPayTypeCodes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.OrderPayTypeCode });

                entity.ToTable("Order_Pay_Type_Codes");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OrderPayTypeCode).HasColumnName("Order_Pay_Type_Code");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreditCardCode).HasColumnName("Credit_Card_Code");

                entity.Property(e => e.Description)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPayId).HasColumnName("Sales_Pay_ID");
            });

            modelBuilder.Entity<OrderPayTypeHdr>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.SalesPayId })
                    .IsClustered(false);

                entity.ToTable("Order_Pay_Type_HDR");

                entity.HasIndex(e => e.SalesPayId)
                    .HasName("UQ__Order_Pa__CAC1CA6D2396101D")
                    .IsUnique();

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPayId)
                    .HasColumnName("Sales_Pay_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DisplaySequence).HasColumnName("Display_Sequence");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.SalesPayHead)
                    .IsRequired()
                    .HasColumnName("Sales_Pay_Head")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderPaymentSavedMode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Order_Payment_Saved_Mode");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AmountTendered)
                    .HasColumnName("Amount_Tendered")
                    .HasColumnType("money");

                entity.Property(e => e.CashOutId)
                    .HasColumnName("CashOut_ID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CashOutShift).HasColumnName("Cash_Out_Shift");

                entity.Property(e => e.CashOutTime)
                    .HasColumnName("CashOut_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChangeDue)
                    .HasColumnName("Change_Due")
                    .HasColumnType("money");

                entity.Property(e => e.CheckInfo)
                    .HasColumnName("Check_Info")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyAmount)
                    .HasColumnName("Currency_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("Currency_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DriverCheckIn)
                    .HasColumnName("Driver_CheckIn")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ispay).HasDefaultValueSql("((0))");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerApproved)
                    .HasColumnName("Manager_Approved")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ManagerCheckIn)
                    .HasColumnName("Manager_CheckIn")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.OrderPayTypeCode).HasColumnName("Order_Pay_Type_Code");

                entity.Property(e => e.PaymentAmount)
                    .HasColumnName("Payment_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.PaymentLineNumber).HasColumnName("Payment_Line_Number");

                entity.Property(e => e.Tip).HasColumnType("money");

                entity.Property(e => e.TransactionId).HasColumnName("Transaction_ID");
            });

            modelBuilder.Entity<OrderPayments>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderDate, e.OrderNumber, e.PaymentLineNumber, e.Sequence });

                entity.ToTable("Order_Payments");

                entity.HasIndex(e => new { e.PaymentLineNumber, e.Sequence, e.OrderPayTypeCode, e.AmountTendered, e.PaymentAmount, e.ChangeDue, e.CurrencyAmount, e.CurrencyCode, e.CheckInfo, e.Deleted, e.CashOutId, e.CashOutShift, e.CashOutTime, e.Tip, e.AddedBy, e.Added, e.LocationCode, e.OrderNumber, e.OrderDate })
                    .HasName("IX_OrderPayment_OrderNumber_Date_Location_LineNO");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.PaymentLineNumber).HasColumnName("Payment_Line_Number");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AmountTendered)
                    .HasColumnName("Amount_Tendered")
                    .HasColumnType("money");

                entity.Property(e => e.CashOutId)
                    .HasColumnName("CashOut_ID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CashOutShift).HasColumnName("Cash_Out_Shift");

                entity.Property(e => e.CashOutTime)
                    .HasColumnName("CashOut_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChangeDue)
                    .HasColumnName("Change_Due")
                    .HasColumnType("money");

                entity.Property(e => e.CheckInfo)
                    .HasColumnName("Check_Info")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyAmount)
                    .HasColumnName("Currency_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("Currency_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderPayTypeCode).HasColumnName("Order_Pay_Type_Code");

                entity.Property(e => e.PaymentAmount)
                    .HasColumnName("Payment_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tip).HasColumnType("money");
            });

            modelBuilder.Entity<OrderReasons>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderDate, e.OrderNumber, e.ReasonSequence });

                entity.ToTable("Order_Reasons");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.ReasonSequence).HasColumnName("Reason_Sequence");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OtherInformation)
                    .HasColumnName("Other_Information")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonGroupCode).HasColumnName("Reason_Group_Code");

                entity.Property(e => e.ReasonId).HasColumnName("Reason_ID");
            });

            modelBuilder.Entity<OrderTransaction>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderNumber, e.OrderDate, e.PaymentLineNumber, e.Sequence })
                    .IsClustered(false);

                entity.ToTable("Order_Transaction");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaymentLineNumber)
                    .HasColumnName("Payment_Line_Number")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CashOutId)
                    .IsRequired()
                    .HasColumnName("CashOut_ID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CashOutShift).HasColumnName("Cash_Out_Shift");

                entity.Property(e => e.CashOutTime)
                    .HasColumnName("CashOut_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasColumnName("Computer_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("Currency_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderPayTypeCode).HasColumnName("Order_Pay_Type_Code");

                entity.Property(e => e.OrderStatusCode).HasColumnName("Order_Status_Code");

                entity.Property(e => e.Tip).HasColumnType("money");

                entity.Property(e => e.WorkstationId).HasColumnName("Workstation_ID");
            });

            modelBuilder.Entity<OrderTransactionRefund>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Order_Transaction_Refund");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.OrderPayTypeCode).HasColumnName("Order_Pay_Type_Code");

                entity.Property(e => e.RefundAmount).HasColumnType("money");

                entity.Property(e => e.RefundMessage)
                    .HasColumnName("Refund_Message")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RefundTransactionStatusCode).HasColumnName("Refund_Transaction_Status_Code");
            });

            modelBuilder.Entity<OrderTypeCodes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.OrderTypeCode });

                entity.ToTable("Order_Type_Codes");

                entity.HasIndex(e => e.OrderTypeCode)
                    .HasName("Order_Type_Code");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OrderTypeCode)
                    .HasColumnName("Order_Type_Code")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .IsRequired()
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderTypeOptions>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderTypeCode });

                entity.ToTable("Order_Type_Options");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTypeCode)
                    .HasColumnName("Order_Type_Code")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PrintLabelEventCode).HasColumnName("Print_Label_Event_Code");

                entity.Property(e => e.PrintReceiptEventCode).HasColumnName("Print_Receipt_Event_Code");
            });

            modelBuilder.Entity<OrderUserDefinedTax>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderDate, e.OrderNumber });

                entity.ToTable("Order_User_Defined_Tax");

                entity.HasIndex(e => new { e.LocationCode, e.OrderDate, e.OrderNumber })
                    .HasName("IX_OrderUserDefTax_OrderDateNumber");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CityBasedTax).HasColumnName("City_Based_Tax");

                entity.Property(e => e.CityCode).HasColumnName("City_Code");

                entity.Property(e => e.DeliveryFeeCategoryId).HasColumnName("Delivery_Fee_Category_ID");

                entity.Property(e => e.DeliveryFeeRate1).HasColumnName("Delivery_Fee_Rate_1");

                entity.Property(e => e.DeliveryFeeRate2).HasColumnName("Delivery_Fee_Rate_2");

                entity.Property(e => e.DeliveryFeeRate3).HasColumnName("Delivery_Fee_Rate_3");

                entity.Property(e => e.DeliveryFeeRate4).HasColumnName("Delivery_Fee_Rate_4");

                entity.Property(e => e.DeliveryFeeTax1)
                    .HasColumnName("Delivery_Fee_Tax1")
                    .HasColumnType("money");

                entity.Property(e => e.DeliveryFeeTax2)
                    .HasColumnName("Delivery_Fee_Tax2")
                    .HasColumnType("money");

                entity.Property(e => e.DeliveryFeeTax3)
                    .HasColumnName("Delivery_Fee_Tax3")
                    .HasColumnType("money");

                entity.Property(e => e.DeliveryFeeTax4)
                    .HasColumnName("Delivery_Fee_Tax4")
                    .HasColumnType("money");

                entity.Property(e => e.NonTaxableSales1)
                    .HasColumnName("Non_Taxable_Sales1")
                    .HasColumnType("money");

                entity.Property(e => e.NonTaxableSales2)
                    .HasColumnName("Non_Taxable_Sales2")
                    .HasColumnType("money");

                entity.Property(e => e.NonTaxableSales3)
                    .HasColumnName("Non_Taxable_Sales3")
                    .HasColumnType("money");

                entity.Property(e => e.NonTaxableSales4)
                    .HasColumnName("Non_Taxable_Sales4")
                    .HasColumnType("money");

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasColumnName("Postal_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalesTax1)
                    .HasColumnName("Sales_Tax1")
                    .HasColumnType("money");

                entity.Property(e => e.SalesTax2)
                    .HasColumnName("Sales_Tax2")
                    .HasColumnType("money");

                entity.Property(e => e.SalesTax3)
                    .HasColumnName("Sales_Tax3")
                    .HasColumnType("money");

                entity.Property(e => e.SalesTax4)
                    .HasColumnName("Sales_Tax4")
                    .HasColumnType("money");

                entity.Property(e => e.Tax1CompoundTax2).HasColumnName("Tax_1_Compound_Tax_2");

                entity.Property(e => e.Tax1CompoundTax3).HasColumnName("Tax_1_Compound_Tax_3");

                entity.Property(e => e.Tax1CompoundTax4).HasColumnName("Tax_1_Compound_Tax_4");

                entity.Property(e => e.Tax1MinOrderAmount)
                    .HasColumnName("Tax_1_Min_Order_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax1MinOrderTax).HasColumnName("Tax_1_Min_Order_Tax");

                entity.Property(e => e.Tax2CompoundTax1).HasColumnName("Tax_2_Compound_Tax_1");

                entity.Property(e => e.Tax2CompoundTax3).HasColumnName("Tax_2_Compound_Tax_3");

                entity.Property(e => e.Tax2CompoundTax4).HasColumnName("Tax_2_Compound_Tax_4");

                entity.Property(e => e.Tax2MinOrderAmount)
                    .HasColumnName("Tax_2_Min_Order_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax2MinOrderTax).HasColumnName("Tax_2_Min_Order_Tax");

                entity.Property(e => e.Tax3CompoundTax1).HasColumnName("Tax_3_Compound_Tax_1");

                entity.Property(e => e.Tax3CompoundTax2).HasColumnName("Tax_3_Compound_Tax_2");

                entity.Property(e => e.Tax3CompoundTax4).HasColumnName("Tax_3_Compound_Tax_4");

                entity.Property(e => e.Tax3MinOrderAmount)
                    .HasColumnName("Tax_3_Min_Order_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax3MinOrderTax).HasColumnName("Tax_3_Min_Order_Tax");

                entity.Property(e => e.Tax4CompoundTax1).HasColumnName("Tax_4_Compound_Tax_1");

                entity.Property(e => e.Tax4CompoundTax2).HasColumnName("Tax_4_Compound_Tax_2");

                entity.Property(e => e.Tax4CompoundTax3).HasColumnName("Tax_4_Compound_Tax_3");

                entity.Property(e => e.Tax4MinOrderAmount)
                    .HasColumnName("Tax_4_Min_Order_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax4MinOrderTax).HasColumnName("Tax_4_Min_Order_Tax");

                entity.Property(e => e.TaxableSales1)
                    .HasColumnName("Taxable_Sales1")
                    .HasColumnType("money");

                entity.Property(e => e.TaxableSales2)
                    .HasColumnName("Taxable_Sales2")
                    .HasColumnType("money");

                entity.Property(e => e.TaxableSales3)
                    .HasColumnName("Taxable_Sales3")
                    .HasColumnType("money");

                entity.Property(e => e.TaxableSales4)
                    .HasColumnName("Taxable_Sales4")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<OrderWallet>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderDate, e.OrderNumber, e.TentNumber, e.Sequence })
                    .HasName("Order_Wallet_PK");

                entity.ToTable("Order_Wallet");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.TentNumber)
                    .HasColumnName("Tent_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AodAmount)
                    .HasColumnName("AOD_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.ApiAttempt).HasColumnName("API_Attempt");

                entity.Property(e => e.ApiRequest)
                    .HasColumnName("API_Request")
                    .HasMaxLength(4000);

                entity.Property(e => e.ApiResponse)
                    .HasColumnName("API_Response")
                    .HasMaxLength(4000);

                entity.Property(e => e.OloSyncDate)
                    .HasColumnName("OLO_Sync_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OloSyncStatus).HasColumnName("OLO_Sync_Status");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.OrderWallet)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Wallet_Location_Codes");

                entity.HasOne(d => d.Orders)
                    .WithMany(p => p.OrderWallet)
                    .HasForeignKey(d => new { d.LocationCode, d.OrderDate, d.OrderNumber })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Wallet_Orders");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderDate, e.OrderNumber })
                    .HasName("aaaaaOrders_PK");

                entity.HasIndex(e => e.CouponCode)
                    .HasName("Coupon_Code");

                entity.HasIndex(e => e.CouponTypeCode)
                    .HasName("Coupon_Type_Code");

                entity.HasIndex(e => e.DriverId)
                    .HasName("Route_ID");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => e.OrderDate)
                    .HasName("Order_Date");

                entity.HasIndex(e => e.OrderSaved)
                    .HasName("Order_Saved");

                entity.HasIndex(e => e.OrderStatusCode)
                    .HasName("Order_Status_Code");

                entity.HasIndex(e => e.OrderTypeCode)
                    .HasName("Order_Type_Code");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.ActualOrderDate)
                    .HasColumnName("Actual_Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BeingModified)
                    .HasColumnName("Being_Modified")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClosedOrderTime)
                    .HasColumnName("Closed_Order_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ComputerName)
                    .HasColumnName("Computer_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CouponAdjustment)
                    .HasColumnName("Coupon_Adjustment")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CouponAmount)
                    .HasColumnName("Coupon_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.CouponCode)
                    .HasColumnName("Coupon_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CouponTaxable)
                    .HasColumnName("Coupon_Taxable")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CouponTotal)
                    .HasColumnName("Coupon_Total")
                    .HasColumnType("money");

                entity.Property(e => e.CouponTypeCode).HasColumnName("Coupon_Type_Code");

                entity.Property(e => e.Credit).HasColumnType("money");

                entity.Property(e => e.CustomerCode).HasColumnName("Customer_Code");

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerRoom)
                    .HasColumnName("Customer_Room")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DelayedOrder)
                    .HasColumnName("Delayed_Order")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeliveryFee)
                    .HasColumnName("Delivery_Fee")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeliveryFeeTax1)
                    .HasColumnName("Delivery_Fee_Tax1")
                    .HasColumnType("money");

                entity.Property(e => e.DeliveryFeeTax2)
                    .HasColumnName("Delivery_Fee_Tax2")
                    .HasColumnType("money");

                entity.Property(e => e.DeliveryTime)
                    .HasColumnName("Delivery_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DriverId)
                    .HasColumnName("Driver_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DriverShift)
                    .IsRequired()
                    .HasColumnName("Driver_Shift")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.FinalTotal)
                    .HasColumnName("Final_Total")
                    .HasColumnType("money");

                entity.Property(e => e.KitchenDisplayTime)
                    .HasColumnName("Kitchen_Display_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Modifying)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NonTaxableSales)
                    .HasColumnName("Non_Taxable_Sales")
                    .HasColumnType("money");

                entity.Property(e => e.NumberInParty).HasColumnName("Number_In_Party");

                entity.Property(e => e.OldOrderNumber).HasColumnName("Old_Order_Number");

                entity.Property(e => e.OrderAdjustments)
                    .HasColumnName("Order_Adjustments")
                    .HasColumnType("money");

                entity.Property(e => e.OrderCouponTotal)
                    .HasColumnName("Order_Coupon_Total")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineAdjustments)
                    .HasColumnName("Order_Line_Adjustments")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineCouponTotal)
                    .HasColumnName("Order_Line_Coupon_Total")
                    .HasColumnType("money");

                entity.Property(e => e.OrderSaved)
                    .HasColumnName("Order_Saved")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderStatusCode).HasColumnName("Order_Status_Code");

                entity.Property(e => e.OrderTakerId)
                    .HasColumnName("Order_Taker_ID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTakerShift)
                    .IsRequired()
                    .HasColumnName("Order_Taker_Shift")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.OrderTime).HasColumnName("Order_Time");

                entity.Property(e => e.OrderTypeCode)
                    .HasColumnName("Order_Type_Code")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PayNow)
                    .HasColumnName("Pay_Now")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReturnTime)
                    .HasColumnName("Return_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Roudingoff).HasColumnType("money");

                entity.Property(e => e.RouteTime)
                    .HasColumnName("Route_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.SalesTax1)
                    .HasColumnName("Sales_Tax1")
                    .HasColumnType("money");

                entity.Property(e => e.SalesTax2)
                    .HasColumnName("Sales_Tax2")
                    .HasColumnType("money");

                entity.Property(e => e.SubTotal).HasColumnType("money");

                entity.Property(e => e.TaxableSales1)
                    .HasColumnName("Taxable_Sales1")
                    .HasColumnType("money");

                entity.Property(e => e.TaxableSales2)
                    .HasColumnName("Taxable_Sales2")
                    .HasColumnType("money");

                entity.Property(e => e.TentNumber)
                    .HasColumnName("Tent_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount)
                    .HasColumnName("Total_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.WorkstationId).HasColumnName("Workstation_ID");
            });

            modelBuilder.Entity<OvenDescription>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.Id, e.OvenName })
                    .HasName("Oven_Description_PK")
                    .IsClustered(false);

                entity.ToTable("Oven_Description");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.OvenName)
                    .HasColumnName("Oven_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BakeTime).HasColumnName("Bake_Time");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.OvenDescription)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Oven_Description_Location_Codes");
            });

            modelBuilder.Entity<OvertimeConditions>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OvertimeCode })
                    .IsClustered(false);

                entity.ToTable("Overtime_Conditions");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OvertimeCode).HasColumnName("Overtime_Code");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_by")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PayCalc).HasColumnName("Pay_Calc");
            });

            modelBuilder.Entity<ParityTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.ParityTypeCode });

                entity.ToTable("Parity_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ParityTypeCode).HasColumnName("Parity_Type_Code");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayType>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.PayTypeCode });

                entity.ToTable("Pay_Type");

                entity.HasIndex(e => e.PayTypeCode)
                    .HasName("Pay_Type_ID");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PayTypeCode).HasColumnName("Pay_Type_Code");

                entity.Property(e => e.Description)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayrollControl>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.StartingDate });

                entity.ToTable("Payroll_Control");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.StartingDate)
                    .HasColumnName("Starting_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ApplyOvertimeContract).HasColumnName("Apply_Overtime_Contract");

                entity.Property(e => e.NumberOfDays).HasColumnName("Number_Of_Days");

                entity.Property(e => e.OvertimeConditions).HasColumnName("Overtime_Conditions");

                entity.Property(e => e.PayrollTypeCode).HasColumnName("Payroll_Type_Code");
            });

            modelBuilder.Entity<PayrollType>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.PayrollTypeCode });

                entity.ToTable("Payroll_Type");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PayrollTypeCode).HasColumnName("Payroll_Type_Code");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .IsRequired()
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfDays).HasColumnName("Number_of_Days");
            });

            modelBuilder.Entity<PcDeviceOrderTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.DeviceId, e.OrderTypeCode });

                entity.ToTable("PC_Device_Order_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId).HasColumnName("Device_ID");

                entity.Property(e => e.OrderTypeCode)
                    .HasColumnName("Order_Type_Code")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PcDeviceQueue>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.DeviceId, e.Sequence });

                entity.ToTable("PC_Device_Queue");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId).HasColumnName("Device_ID");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LineDisplayColumn).HasColumnName("Line_Display_Column");

                entity.Property(e => e.LineDisplayRow).HasColumnName("Line_Display_Row");

                entity.Property(e => e.SendText)
                    .IsRequired()
                    .HasColumnName("Send_Text")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<PcDeviceQueueDaily>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pc_device_queue_daily");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId).HasColumnName("Device_ID");

                entity.Property(e => e.LineDisplayColumn).HasColumnName("Line_Display_Column");

                entity.Property(e => e.LineDisplayRow).HasColumnName("Line_Display_Row");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("order_number");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phone_number")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SendText)
                    .IsRequired()
                    .HasColumnName("Send_Text")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<PcDeviceTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.DeviceTypeCode });

                entity.ToTable("PC_Device_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DeviceTypeCode).HasColumnName("Device_Type_Code");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .IsRequired()
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PcDevices>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.DeviceId });

                entity.ToTable("PC_Devices");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId).HasColumnName("Device_ID");

                entity.Property(e => e.AbandedReceipt).HasColumnName("Abanded_Receipt");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CashDropLabel).HasColumnName("Cash_Drop_Label");

                entity.Property(e => e.CashDropReceipt).HasColumnName("Cash_Drop_Receipt");

                entity.Property(e => e.CashOutReceipt).HasColumnName("Cash_Out_Receipt");

                entity.Property(e => e.CheckOutReceipt).HasColumnName("Check_Out_Receipt");

                entity.Property(e => e.CustomerLabel).HasColumnName("Customer_Label");

                entity.Property(e => e.Description)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceInterfaceTypeCode)
                    .HasColumnName("Device_Interface_Type_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DeviceTypeCode).HasColumnName("Device_Type_Code");

                entity.Property(e => e.DriverLabel).HasColumnName("Driver_Label");

                entity.Property(e => e.KitchenReceipt).HasColumnName("Kitchen_Receipt");

                entity.Property(e => e.KpItemVisibility).HasColumnName("KP_Item_Visibility");

                entity.Property(e => e.KpShowCodes).HasColumnName("KP_Show_Codes");

                entity.Property(e => e.MakeLineCode).HasColumnName("Make_Line_Code");

                entity.Property(e => e.MapDirections).HasColumnName("Map_Directions");

                entity.Property(e => e.MenuItemLabel).HasColumnName("Menu_Item_Label");

                entity.Property(e => e.MenuItemReceipt).HasColumnName("Menu_Item_Receipt");

                entity.Property(e => e.NumberOfCopies)
                    .HasColumnName("Number_Of_Copies")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NutritionalLabel).HasColumnName("Nutritional_Label");

                entity.Property(e => e.OrderReceipt).HasColumnName("Order_Receipt");

                entity.Property(e => e.PopDrawerChargeAccount).HasColumnName("Pop_Drawer_Charge_Account");

                entity.Property(e => e.PopDrawerCheck).HasColumnName("Pop_Drawer_Check");

                entity.Property(e => e.PopDrawerCreditCard).HasColumnName("Pop_Drawer_Credit_Card");

                entity.Property(e => e.PopDrawerGiftCard).HasColumnName("Pop_Drawer_Gift_Card");

                entity.Property(e => e.PortName)
                    .HasColumnName("Port_Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PortTypeCode).HasColumnName("Port_Type_Code");

                entity.Property(e => e.PreparationLabel).HasColumnName("Preparation_Label");

                entity.Property(e => e.PreparationReceipt).HasColumnName("Preparation_Receipt");

                entity.Property(e => e.ReceiptWidth).HasColumnName("Receipt_Width");

                entity.Property(e => e.ReprintReceipt).HasColumnName("Reprint_Receipt");

                entity.Property(e => e.ShowCodesLabel).HasColumnName("Show_Codes_Label");

                entity.Property(e => e.ShowDiscountsReceipt).HasColumnName("Show_Discounts_Receipt");

                entity.Property(e => e.ShowPrinterInformation).HasColumnName("Show_Printer_Information");

                entity.Property(e => e.SignatureReceipt).HasColumnName("Signature_Receipt");

                entity.Property(e => e.TaxLabel).HasColumnName("Tax_Label");

                entity.Property(e => e.TillReceipt).HasColumnName("Till_Receipt");

                entity.Property(e => e.TimeClockConfirmation).HasColumnName("Time_Clock_Confirmation");

                entity.Property(e => e.VoidBadLabel).HasColumnName("Void_Bad_Label");

                entity.Property(e => e.VoidBadReceipt).HasColumnName("Void_Bad_Receipt");

                entity.Property(e => e.WorkstationId).HasColumnName("Workstation_ID");

                entity.Property(e => e.ZebraHeatSetting)
                    .HasColumnName("Zebra_Heat_Setting")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Period>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.YearCode, e.PeriodCode });

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.YearCode)
                    .HasColumnName("Year_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodCode)
                    .HasColumnName("Period_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BeginDate)
                    .HasColumnName("Begin_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasColumnName("End_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PeriodDescription)
                    .HasColumnName("Period_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PizzaPart>(entity =>
            {
                entity.HasKey(e => e.PizzaPart1)
                    .HasName("aaaaaPizza_Part_PK")
                    .IsClustered(false);

                entity.ToTable("Pizza_Part");

                entity.Property(e => e.PizzaPart1)
                    .HasColumnName("Pizza_Part")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PercentOfWhole).HasColumnName("Percent_of_Whole");
            });

            modelBuilder.Entity<PortTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.PortTypeCode });

                entity.ToTable("Port_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PortTypeCode).HasColumnName("Port_Type_Code");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PosMasterReport>(entity =>
            {
                entity.HasKey(e => e.ReportId);

                entity.ToTable("POS_MasterReport");

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripition)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SpName)
                    .IsRequired()
                    .HasColumnName("Sp_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PosMessage>(entity =>
            {
                entity.HasKey(e => new { e.MessageId, e.LocationCode })
                    .HasName("PK__POS_Mess__662979BEA16E7E7E");

                entity.ToTable("POS_Message");

                entity.Property(e => e.MessageId)
                    .HasColumnName("MessageID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Apiresponse)
                    .HasColumnName("APIResponse")
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.MessageDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Posdatabackupperiod>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.NoOfDays).HasColumnName("No_of_days");

                entity.Property(e => e.SystemDate)
                    .IsRequired()
                    .HasColumnName("System_date")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasColumnName("Table_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.PositionCode })
                    .IsClustered(false);

                entity.HasIndex(e => e.MvrIntervalCode)
                    .HasName("Date_Interval_TypesPosition");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PositionCode)
                    .HasColumnName("Position_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CalculateTips)
                    .HasColumnName("Calculate_Tips")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Driver).HasDefaultValueSql("((0))");

                entity.Property(e => e.Inside).HasDefaultValueSql("((0))");

                entity.Property(e => e.Manager).HasDefaultValueSql("((0))");

                entity.Property(e => e.MvrCheckInterval)
                    .HasColumnName("MVR_Check_Interval")
                    .HasDefaultValueSql("((6))");

                entity.Property(e => e.MvrIntervalCode)
                    .IsRequired()
                    .HasColumnName("MVR_Interval_Code")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.Position1)
                    .HasColumnName("Position")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PositionImage).HasColumnName("Position_Image");

                entity.Property(e => e.RequireCarInspection)
                    .HasColumnName("Require_Car_Inspection")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RequireCarRegistration)
                    .HasColumnName("Require_Car_Registration")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RequireDl)
                    .HasColumnName("Require_DL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RequireFoodLicense)
                    .HasColumnName("Require_Food_License")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RequireInsurance)
                    .HasColumnName("Require_Insurance")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RequireMvr)
                    .HasColumnName("Require_MVR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RequireTill)
                    .HasColumnName("Require_Till")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TextColor)
                    .HasColumnName("Text_Color")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TillStartingAmount)
                    .HasColumnName("Till_Starting_Amount")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<PostalCodes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.PostalCode })
                    .IsClustered(false);

                entity.ToTable("Postal_Codes");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("Postal_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TaxRate1).HasColumnName("Tax_Rate1");

                entity.Property(e => e.TaxRate2).HasColumnName("Tax_Rate2");
            });

            modelBuilder.Entity<PostingDestinations>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.PostingDestination });

                entity.ToTable("Posting_Destinations");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PostingDestination).HasColumnName("Posting_Destination");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .IsRequired()
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PostingTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.PostingType });

                entity.ToTable("Posting_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PostingType).HasColumnName("Posting_Type");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .IsRequired()
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PosupdateLogs>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("POSUpdateLogs");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PosDate)
                    .HasColumnName("POS_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PosNumber)
                    .HasColumnName("POS_Number")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Version).HasMaxLength(15);
            });

            modelBuilder.Entity<PreparedItemsAdjustment>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.InventoryCode });

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryCode)
                    .HasColumnName("Inventory_Code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Desrciption)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrgVer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("prg_ver");

                entity.Property(e => e.Cover)
                    .HasColumnName("COVer")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("Date_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dpinum)
                    .HasColumnName("dpinum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ECver)
                    .HasColumnName("eCver")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lpver)
                    .HasColumnName("LPVer")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ppver)
                    .HasColumnName("PPver")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrintEventTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.PrintEventCode });

                entity.ToTable("Print_Event_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PrintEventCode).HasColumnName("Print_Event_Code");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PriorityCustomerCategory>(entity =>
            {
                entity.HasKey(e => e.CatgId)
                    .HasName("PK__Priority__E1EDCD993CF3D6A0");

                entity.ToTable("Priority_Customer_Category");

                entity.Property(e => e.CatgId).HasColumnName("Catg_Id");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AddedDate)
                    .HasColumnName("Added_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CatgRank).HasColumnName("Catg_Rank");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Symbol).HasMaxLength(1);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.PriorityCustomerCategory)
                    .HasForeignKey(d => d.LocationCode)
                    .HasConstraintName("FK__Priority___Locat__575F49AC");
            });

            modelBuilder.Entity<PriorityCustomers>(entity =>
            {
                entity.ToTable("Priority_Customers");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AddedDate)
                    .HasColumnName("Added_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CatgId).HasColumnName("Catg_ID");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("Phone_no")
                    .HasMaxLength(900);

                entity.HasOne(d => d.Catg)
                    .WithMany(p => p.PriorityCustomers)
                    .HasForeignKey(d => d.CatgId)
                    .HasConstraintName("FK__Priority___Catg___5B2FDA90");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.PriorityCustomers)
                    .HasForeignKey(d => d.LocationCode)
                    .HasConstraintName("FK__Priority___Locat__5A3BB657");
            });

            modelBuilder.Entity<PriorityCustomersNotification>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Priority_Customers_Notification");

                entity.Property(e => e.ActionType)
                    .HasColumnName("Action_Type")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AddedDate)
                    .HasColumnName("Added_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPhone)
                    .HasColumnName("Customer_Phone")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.OrderSaved)
                    .HasColumnName("Order_Saved")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderTypeCode)
                    .HasColumnName("Order_Type_Code")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StoreName)
                    .HasColumnName("Store_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.PriorityCustomersNotification)
                    .HasForeignKey(d => d.LocationCode)
                    .HasConstraintName("FK__Priority___Locat__5D182302");
            });

            modelBuilder.Entity<ProcessorTrackingLog>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LogId });

                entity.ToTable("Processor_Tracking_Log");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LogId).HasColumnName("Log_ID");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CardTypeId).HasColumnName("Card_Type_ID");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasColumnName("Customer_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryMethod).HasColumnName("Entry_Method");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.ProcessorResponse)
                    .HasColumnName("Processor_Response")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RetrievalReferenceCode)
                    .HasColumnName("Retrieval_Reference_Code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionAmount)
                    .HasColumnName("Transaction_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.TransactionType).HasColumnName("Transaction_Type");

                entity.Property(e => e.WorkstationId).HasColumnName("Workstation_ID");
            });

            modelBuilder.Entity<ProductOsgs>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8);

                entity.Property(e => e.PrOsgTypeCode).HasMaxLength(8);

                entity.Property(e => e.ProdCatCode)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.ProdOsgCode)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.ProdOsgDescText)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.ProdOsgPosDescText).HasMaxLength(32);

                entity.Property(e => e.ProdOsgShortDescText).HasMaxLength(8);
            });

            modelBuilder.Entity<ProductPricingTablePrices>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8);

                entity.Property(e => e.OptPrcTblCode).HasMaxLength(8);

                entity.Property(e => e.PptPricePrice).HasColumnType("money");

                entity.Property(e => e.PrPrcTblCode)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.ProdCatCode)
                    .IsRequired()
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<Products2>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.ProductCode });

                entity.HasIndex(e => new { e.LocationCode, e.ProdSizeCode, e.ProdFlavorCode, e.ProdOsgCode })
                    .HasName("Unique_Products2")
                    .IsUnique();

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8);

                entity.Property(e => e.ProductCode).HasMaxLength(10);

                entity.Property(e => e.PrPrcTblCode).HasMaxLength(8);

                entity.Property(e => e.PrPrcTblCode2).HasMaxLength(8);

                entity.Property(e => e.PrPrcTblCode3).HasMaxLength(8);

                entity.Property(e => e.ProdCatCode)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.ProdFlavorCode)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.ProdOsgCode).HasMaxLength(8);

                entity.Property(e => e.ProdSizeCode)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.ProductBasePrice).HasColumnType("money");

                entity.Property(e => e.ProductBottleDepositAmt).HasColumnType("money");

                entity.Property(e => e.ProductDescText).HasMaxLength(32);

                entity.Property(e => e.ProductEffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.ProductExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.ProductLegacyCode).HasMaxLength(4);

                entity.Property(e => e.ProductMaxPrice).HasColumnType("money");

                entity.Property(e => e.ProductPosDescText).HasMaxLength(32);

                entity.Property(e => e.ProductShortDescText).HasMaxLength(16);

                entity.Property(e => e.ProductSurchargeAmt).HasColumnType("money");

                entity.Property(e => e.ProductSurchargeDescText).HasMaxLength(32);

                entity.Property(e => e.ProductUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.ProductUpdateUserCode).HasMaxLength(8);

                entity.Property(e => e.TaxCatCode)
                    .IsRequired()
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<ProductsText>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8);

                entity.Property(e => e.ProdTextCategoryDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProdTextDisplayCode).HasMaxLength(10);

                entity.Property(e => e.ProdTextFlavorDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProdTextFlavorShortDesc).HasMaxLength(8);

                entity.Property(e => e.ProdTextOptSelectGrpDesc).HasMaxLength(50);

                entity.Property(e => e.ProdTextProductDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProdTextSizeDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProdTextSizeShortDesc).HasMaxLength(8);

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ProfileControlTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.ProfileControlTypeCode });

                entity.ToTable("Profile_Control_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ProfileControlTypeCode).HasColumnName("Profile_Control_Type_Code");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PulseApiErrorLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PULSE_API_ERROR_LOG");

                entity.Property(e => e.Errorline)
                    .HasColumnName("ERRORLINE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Errormessage)
                    .HasColumnName("ERRORMESSAGE")
                    .HasColumnType("text");

                entity.Property(e => e.Errornumber)
                    .HasColumnName("ERRORNUMBER")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Errorprocedure)
                    .HasColumnName("ERRORPROCEDURE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Errorseverity)
                    .HasColumnName("ERRORSEVERITY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Errorstate)
                    .HasColumnName("ERRORSTATE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("LOCATION_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequestId)
                    .HasColumnName("REQUEST_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDesc)
                    .HasColumnName("STATUS_DESC")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("TIME_STAMP")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<PulseApiorderData>(entity =>
            {
                entity.HasKey(e => e.OrderDateOrderNumber)
                    .HasName("PK__PulseAPI__DE141033734DD889");

                entity.ToTable("PulseAPIOrderData");

                entity.Property(e => e.OrderDateOrderNumber)
                    .HasColumnName("OrderDate_OrderNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnName("ADDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.BalanceDue)
                    .HasColumnName("Balance_Due")
                    .HasColumnType("money");

                entity.Property(e => e.BottleDepositAmount)
                    .HasColumnName("BottleDeposit_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CsrFirstName)
                    .HasColumnName("CSR_FirstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CsrId)
                    .HasColumnName("CSR_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentDateTime)
                    .HasColumnName("Current_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerAddress1)
                    .HasColumnName("Customer_Address1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerAddress2)
                    .HasColumnName("Customer_Address2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerAddress3)
                    .HasColumnName("Customer_Address3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerAddress4)
                    .HasColumnName("Customer_Address4")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCity)
                    .HasColumnName("Customer_City")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPhone)
                    .HasColumnName("Customer_Phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPostalCode)
                    .HasColumnName("Customer_PostalCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerState)
                    .HasColumnName("Customer_State")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryDateTime)
                    .HasColumnName("Delivery_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeliveryTime).HasColumnName("Delivery_Time");

                entity.Property(e => e.DiscountAmount)
                    .HasColumnName("Discount_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.DispatchDateTime)
                    .HasColumnName("Dispatch_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DriverFirstName)
                    .HasColumnName("Driver_FirstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DriverId)
                    .HasColumnName("Driver_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DriverReturnDateTime)
                    .HasColumnName("Driver_Return_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MakeLineItemCount).HasColumnName("MakeLine_Item_Count");

                entity.Property(e => e.ManagerFirstName)
                    .HasColumnName("Manager_FirstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerId)
                    .HasColumnName("Manager_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount)
                    .HasColumnName("Net_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.OrderComments)
                    .HasColumnName("Order_Comments")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderDescription)
                    .HasColumnName("Order_Description")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDetail)
                    .HasColumnName("Order_Detail")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OrderFinalPrice)
                    .HasColumnName("Order_FinalPrice")
                    .HasColumnType("money");

                entity.Property(e => e.OrderKey)
                    .HasColumnName("Order_Key")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderLastUpdate)
                    .HasColumnName("Order_LastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderLineWithDiscount).HasColumnType("money");

                entity.Property(e => e.OrderListPrice)
                    .HasColumnName("Order_ListPrice")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLoadDateTime)
                    .HasColumnName("Order_Load_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderLoadTime).HasColumnName("Order_Load_Time");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("Order_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSaveDateTime)
                    .HasColumnName("Order_SaveDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderSaveStartTime)
                    .HasColumnName("Order_Save_Start_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderSourceCode)
                    .HasColumnName("Order_Source_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderStatus)
                    .HasColumnName("Order_Status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTakeComplete)
                    .HasColumnName("Order_Take_Complete")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderTakeTime).HasColumnName("Order_Take_Time");

                entity.Property(e => e.OvenTime).HasColumnName("Oven_Time");

                entity.Property(e => e.RackDateTime)
                    .HasColumnName("Rack_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.RackTime).HasColumnName("Rack_Time");

                entity.Property(e => e.RunStopCount).HasColumnName("Run_Stop_Count");

                entity.Property(e => e.RunStopSeq).HasColumnName("Run_Stop_Seq");

                entity.Property(e => e.SalesTax1Amount)
                    .HasColumnName("SalesTax1_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.SalesTax2Amount)
                    .HasColumnName("SalesTax2_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.SalesTax3Amount)
                    .HasColumnName("SalesTax3_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.SalesTax4Amount)
                    .HasColumnName("SalesTax4_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.SalesTax5Amount)
                    .HasColumnName("SalesTax5_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.ServiceMethod)
                    .HasColumnName("Service_Method")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreNumber)
                    .HasColumnName("Store_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PulseApiorderDataDtl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PulseAPIOrderDataDtl");

                entity.Property(e => e.DtlId)
                    .HasColumnName("Dtl_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OrderDateOrderNumber)
                    .HasColumnName("OrderDate_OrderNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("Product_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDescription)
                    .HasColumnName("Product_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.OrderDateOrderNumberNavigation)
                    .WithMany(p => p.PulseApiorderDataDtl)
                    .HasForeignKey(d => d.OrderDateOrderNumber)
                    .HasConstraintName("FK__PulseAPIO__Order__5CE54913");
            });

            modelBuilder.Entity<PulseMappingSequence>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Pulse_Mapping_Sequence");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TabFileName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TableType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PulseTableMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Pulse_TableMapping");

                entity.Property(e => e.DefaultVal).IsUnicode(false);

                entity.Property(e => e.HustleFieldName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.HustleTableName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PulseFieldName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TabFileName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReasonDescriptions>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.ReasonDescriptionId });

                entity.ToTable("Reason_Descriptions");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.ReasonDescriptionId).HasColumnName("Reason_Description_ID");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonId).HasColumnName("Reason_ID");

                entity.Property(e => e.UserText)
                    .HasColumnName("User_Text")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReasonDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Reason_Details");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CouponCode)
                    .HasColumnName("coupon_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HotelName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.ReasonId).HasColumnName("Reason_Id");
            });

            modelBuilder.Entity<ReasonGroups>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.ReasonGroupCode });

                entity.ToTable("Reason_Groups");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.ReasonGroupCode).HasColumnName("Reason_Group_Code");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultDescription)
                    .IsRequired()
                    .HasColumnName("Default_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDescription)
                    .IsRequired()
                    .HasColumnName("Modified_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrackingGroup).HasColumnName("Tracking_Group");
            });

            modelBuilder.Entity<Reasons>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.ReasonId });

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.ReasonId).HasColumnName("Reason_ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");

                entity.Property(e => e.ReasonGroupCode).HasColumnName("Reason_Group_Code");

                entity.Property(e => e.SystemText)
                    .IsRequired()
                    .HasColumnName("System_Text")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RegAppRunning>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasColumnName("Computer_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ExeName)
                    .IsRequired()
                    .HasColumnName("Exe_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RegModuleList>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.KeyLocation, e.OnOffProd })
                    .IsClustered(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.KeyLocation).HasColumnName("Key_Location");

                entity.Property(e => e.OnOffProd).HasColumnName("On_Off_Prod");

                entity.Property(e => e.ExeName)
                    .IsRequired()
                    .HasColumnName("Exe_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramName)
                    .IsRequired()
                    .HasColumnName("Program_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VisionCore).HasColumnName("Vision_Core");
            });

            modelBuilder.Entity<Regions>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.RegionCode })
                    .IsClustered(false);

                entity.HasIndex(e => e.RegionName)
                    .HasName("Description");

                entity.HasIndex(e => new { e.LocationCode, e.RegionAbbr })
                    .HasName("Region_Abbr_Key")
                    .IsUnique();

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RegionCode).HasColumnName("Region_Code");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AddedManually)
                    .HasColumnName("Added_Manually")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DriverLicenseDob)
                    .HasColumnName("Driver_License_DOB")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RegionAbbr)
                    .HasColumnName("Region_Abbr")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RegionName)
                    .HasColumnName("Region_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StateCode)
                    .HasColumnName("State_Code")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.HasKey(e => e.LocationCode)
                    .IsClustered(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("Company_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.CurrentDate).HasColumnType("datetime");

                entity.Property(e => e.KeyString)
                    .IsRequired()
                    .HasColumnName("Key_String")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerName)
                    .IsRequired()
                    .HasColumnName("Owner_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.RegDate)
                    .HasColumnName("Reg_Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Remarks>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RemarksId).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<RemoteOrderAvailabilityTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.RemoteOrderAvailability });

                entity.ToTable("Remote_Order_Availability_Types");

                entity.HasIndex(e => e.RemoteOrderAvailability)
                    .HasName("Remote_Order_Availability_ID");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RemoteOrderAvailability).HasColumnName("Remote_Order_Availability");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportCategories>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.CategoryId })
                    .IsClustered(false);

                entity.ToTable("Report_Categories");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.CategoryId).HasColumnName("Category_ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");

                entity.Property(e => e.EnglishTextDescription)
                    .IsRequired()
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("Parent_ID");
            });

            modelBuilder.Entity<ReportDateRanges>(entity =>
            {
                entity.HasKey(e => new { e.RangeId, e.LocationCode, e.LanguageCode });

                entity.Property(e => e.RangeId).HasColumnName("RangeID");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.DefaultDescription)
                    .IsRequired()
                    .HasColumnName("Default_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDescription)
                    .IsRequired()
                    .HasColumnName("Modified_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportDateSecurityItems>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.ReportId, e.RangeId })
                    .IsClustered(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ReportId).HasColumnName("Report_ID");

                entity.Property(e => e.RangeId).HasColumnName("RangeID");

                entity.Property(e => e.VbMenuItemId).HasColumnName("VB_Menu_Item_ID");
            });

            modelBuilder.Entity<ReportFields>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.ReportId, e.FieldName })
                    .IsClustered(false);

                entity.ToTable("Report_Fields");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.ReportId).HasColumnName("Report_ID");

                entity.Property(e => e.FieldName)
                    .HasColumnName("Field_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultField)
                    .HasColumnName("Default_Field")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EnglishText)
                    .IsRequired()
                    .HasColumnName("English_Text")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldList)
                    .IsRequired()
                    .HasColumnName("Field_List")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedText)
                    .IsRequired()
                    .HasColumnName("Modified_Text")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Removable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SortOrder).HasColumnName("Sort_Order");

                entity.Property(e => e.ViewOrder).HasColumnName("View_Order");
            });

            modelBuilder.Entity<ReportGroupDetail>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.Id });

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Copies).HasColumnName("copies");

                entity.Property(e => e.Groupid).HasColumnName("groupid");

                entity.Property(e => e.RangeId).HasColumnName("RangeID");

                entity.Property(e => e.ReportId).HasColumnName("report_id");
            });

            modelBuilder.Entity<Reports>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.ReportId })
                    .IsClustered(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.ReportId).HasColumnName("Report_ID");

                entity.Property(e => e.BatchReport)
                    .IsRequired()
                    .HasColumnName("Batch_Report")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BeginDate)
                    .HasColumnName("Begin_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CategoryId).HasColumnName("Category_ID");

                entity.Property(e => e.DateRangeRequired).HasColumnName("Date_Range_Required");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayDateRange)
                    .IsRequired()
                    .HasColumnName("Display_Date_Range")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");

                entity.Property(e => e.EndDate)
                    .HasColumnName("End_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnglishTextDescription)
                    .IsRequired()
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsSharedReport).HasColumnName("Is_Shared_Report");

                entity.Property(e => e.LastDateType).HasColumnName("Last_Date_Type");

                entity.Property(e => e.LocationRequired).HasColumnName("Location_Required");

                entity.Property(e => e.ModifyFields).HasColumnName("Modify_Fields");

                entity.Property(e => e.ModifyOrder).HasColumnName("Modify_Order");

                entity.Property(e => e.VbMenuItemId).HasColumnName("VB_Menu_Item_ID");
            });

            modelBuilder.Entity<RmpgetStreet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RMPGetStreet");

                entity.Property(e => e.CityCode).HasColumnName("City_Code");

                entity.Property(e => e.CityName)
                    .HasColumnName("City_Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rmpstreet)
                    .HasColumnName("RMPStreet")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.RmpstreetCustFile)
                    .HasColumnName("RMPStreetCustFile")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Sqlstreet)
                    .HasColumnName("SQLStreet")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.StreetCode).HasColumnName("Street_Code");

                entity.Property(e => e.StreetId)
                    .HasColumnName("Street_ID")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RoaLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ROA_Log");

                entity.Property(e => e.ErrDescription).HasColumnName("ERR_Description");

                entity.Property(e => e.GateWay)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.GateWayIp)
                    .HasColumnName("GateWayIP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Lan).HasColumnName("LAN");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LogDate)
                    .HasColumnName("Log_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RoaLogNo)
                    .HasColumnName("ROA_Log_NO")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SendMessage).HasColumnName("Send_Message");
            });

            modelBuilder.Entity<RouteStationSettings>(entity =>
            {
                entity.HasKey(e => e.LocationCode)
                    .IsClustered(false);

                entity.ToTable("Route_Station_Settings");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LateTime)
                    .HasColumnName("Late_Time")
                    .HasDefaultValueSql("((25))");

                entity.Property(e => e.MaxOrders)
                    .HasColumnName("Max_Orders")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.ProtectNonDelivery)
                    .HasColumnName("Protect_Non_Delivery")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateSeconds)
                    .HasColumnName("Update_Seconds")
                    .HasDefaultValueSql("((65))");
            });

            modelBuilder.Entity<SaleReport>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ComboSale).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DailySdiscount)
                    .HasColumnName("DailySDiscount")
                    .HasColumnType("money");

                entity.Property(e => e.DailySummary).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Discount).HasColumnType("money");

                entity.Property(e => e.FinalTotal)
                    .HasColumnName("Final_Total")
                    .HasColumnType("money");

                entity.Property(e => e.GoodSale).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NetSales)
                    .HasColumnName("Net_Sales")
                    .HasColumnType("money");

                entity.Property(e => e.SaleDate).HasColumnType("datetime");

                entity.Property(e => e.SaleTax).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SalesTax)
                    .HasColumnName("sales_tax")
                    .HasColumnType("money");

                entity.Property(e => e.ServiceTax)
                    .HasColumnName("Service_Tax")
                    .HasColumnType("money");

                entity.Property(e => e.SsubTotal)
                    .HasColumnName("SSubTotal")
                    .HasColumnType("money");

                entity.Property(e => e.SubTotal)
                    .HasColumnName("Sub_Total")
                    .HasColumnType("money");

                entity.Property(e => e.Tax).HasColumnType("numeric(10, 10)");

                entity.Property(e => e.TotalDiscounts)
                    .HasColumnName("total_discounts")
                    .HasColumnType("money");

                entity.Property(e => e.TotalOrders).HasColumnName("Total_Orders");

                entity.Property(e => e.TotalSales)
                    .HasColumnName("Total_Sales")
                    .HasColumnType("money");

                entity.Property(e => e.TotalTax)
                    .HasColumnName("Total_Tax")
                    .HasColumnType("money");

                entity.Property(e => e.TotalsSales)
                    .HasColumnName("Totals_sales")
                    .HasColumnType("money");

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<SalesPeriodHours>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.SalesPeriodCode, e.DayOfWeek, e.StartTime })
                    .IsClustered(false);

                entity.ToTable("Sales_Period_Hours");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => e.SalesPeriodCode)
                    .HasName("Meal_Code");

                entity.HasIndex(e => new { e.LocationCode, e.SalesPeriodCode })
                    .HasName("Meal_DesgnationsMeal_Desgnation_Times");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPeriodCode)
                    .HasColumnName("Sales_Period_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasColumnName("Start_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasColumnName("End_Time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SalesPeriods>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.SalesPeriodCode })
                    .IsClustered(false);

                entity.ToTable("Sales_Periods");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => e.SalesPeriodCode)
                    .HasName("Meal_Code");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPeriodCode)
                    .HasColumnName("Sales_Period_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");

                entity.Property(e => e.ShortDescription)
                    .HasColumnName("Short_Description")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ScaleWeightUnits>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.ScaleWeightUnitCode })
                    .IsClustered(false);

                entity.ToTable("Scale_Weight_Units");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.ScaleWeightUnitCode).HasColumnName("Scale_Weight_Unit_Code");

                entity.Property(e => e.DefaultDescription)
                    .IsRequired()
                    .HasColumnName("Default_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDescription)
                    .IsRequired()
                    .HasColumnName("Modified_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SdpPaymentModeDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SDP_PaymentMode_Details");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CreateOn)
                    .HasColumnName("Create_On")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DriverId)
                    .IsRequired()
                    .HasColumnName("Driver_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("Modify_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.PaymentLine).HasColumnName("Payment_Line");

                entity.Property(e => e.PaymentMode)
                    .IsRequired()
                    .HasColumnName("Payment_Mode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentStatus).HasColumnName("Payment_Status");

                entity.Property(e => e.Reason).IsUnicode(false);

                entity.Property(e => e.Sno).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SdpVoucherDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SDP_VoucherDetails");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.EmployeeCode)
                    .HasColumnName("Employee_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("date");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.OrderPayCode).HasColumnName("Order_Pay_Code");

                entity.Property(e => e.VoucherName)
                    .HasColumnName("Voucher_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sectors>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.SectorKey });

                entity.HasIndex(e => e.LowerBound)
                    .HasName("Lower_Bound");

                entity.HasIndex(e => e.SectorCode)
                    .HasName("Sector_Code");

                entity.HasIndex(e => e.StreetCode)
                    .HasName("StreetsSectors");

                entity.HasIndex(e => e.UpperBound)
                    .HasName("Upper_Bound");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SectorKey).HasColumnName("Sector_Key");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AdditionalDeliveryFee)
                    .HasColumnName("Additional_Delivery_Fee")
                    .HasColumnType("money");

                entity.Property(e => e.LowerBound)
                    .IsRequired()
                    .HasColumnName("Lower_Bound")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OddEven).HasColumnName("Odd_Even");

                entity.Property(e => e.OutOfArea)
                    .HasColumnName("Out_Of_Area")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SectorCode)
                    .IsRequired()
                    .HasColumnName("Sector_Code")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.StreetCode).HasColumnName("Street_Code");

                entity.Property(e => e.UpperBound)
                    .IsRequired()
                    .HasColumnName("Upper_Bound")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SecurityClass>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.SecurityClassCode })
                    .IsClustered(false);

                entity.ToTable("Security_Class");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityClassCode)
                    .HasColumnName("Security_Class_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityClassDescription)
                    .IsRequired()
                    .HasColumnName("Security_Class_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SecurityClassAccess>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.SecurityClassCode, e.VbMenuItemId })
                    .IsClustered(false);

                entity.ToTable("Security_Class_Access");

                entity.HasIndex(e => e.VbMenuItemId)
                    .HasName("VB_Menu_ItemsSecurity_Class_Access");

                entity.HasIndex(e => new { e.LocationCode, e.SecurityClassCode })
                    .HasName("Security_ClassSecurity_Class_Access");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityClassCode)
                    .HasColumnName("Security_Class_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VbMenuItemId).HasColumnName("VB_Menu_Item_ID");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SecurityClassAssignableClasses>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.SecurityClassCode, e.SubSecurityClassCode })
                    .IsClustered(false);

                entity.ToTable("Security_Class_Assignable_Classes");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityClassCode)
                    .HasColumnName("Security_Class_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SubSecurityClassCode)
                    .HasColumnName("Sub_Security_Class_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SerialPorts>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.SerialPortCode });

                entity.ToTable("Serial_Ports");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SerialPortCode).HasColumnName("Serial_Port_Code");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Settings>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.Id });

                entity.HasIndex(e => new { e.LocationCode, e.WorkstationId, e.SettingName })
                    .HasName("SettingsIndex")
                    .IsUnique();

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SettingName)
                    .IsRequired()
                    .HasColumnName("Setting_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SettingValue)
                    .HasColumnName("Setting_Value")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.WorkstationId).HasColumnName("Workstation_ID");
            });

            modelBuilder.Entity<SortOrder>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.SortId })
                    .IsClustered(false);

                entity.ToTable("Sort_Order");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.SortId).HasColumnName("Sort_ID");

                entity.Property(e => e.DefaultDescription)
                    .HasColumnName("Default_Description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDescription)
                    .HasColumnName("Modified_Description")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SpecialtyPizzaCodes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MenuCode })
                    .IsClustered(false);

                entity.ToTable("Specialty_Pizza_Codes");

                entity.HasIndex(e => new { e.LocationCode, e.MenuCode })
                    .HasName("Menu_ItemsSpecialty_Pizza_Codes")
                    .IsUnique();

                entity.HasIndex(e => new { e.LocationCode, e.SpecialtyPizzaCode })
                    .HasName("Specialty_Pizza_Code")
                    .IsUnique();

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialtyPizzaCode)
                    .IsRequired()
                    .HasColumnName("Specialty_Pizza_Code")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SrsReconcileDetl>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.ReconcileId, e.SalesPayId })
                    .IsClustered(false);

                entity.ToTable("SRS_Reconcile_DETL");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ReconcileId).HasColumnName("Reconcile_ID");

                entity.Property(e => e.SalesPayId).HasColumnName("Sales_Pay_ID");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TotalAmount)
                    .HasColumnName("Total_Amount")
                    .HasColumnType("money");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.SrsReconcileDetl)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SRS_Reconcile_DETL_Location_Codes");

                entity.HasOne(d => d.OrderPayTypeHdr)
                    .WithMany(p => p.SrsReconcileDetl)
                    .HasForeignKey(d => new { d.LocationCode, d.SalesPayId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SRS_Reconcile_DETL_Sales_Pay_ID");

                entity.HasOne(d => d.SrsReconcileHdr)
                    .WithMany(p => p.SrsReconcileDetl)
                    .HasForeignKey(d => new { d.LocationCode, d.OrderDate, d.ReconcileId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SRS_Reconcile_DETL_SRS_Reconcile_HDR");
            });

            modelBuilder.Entity<SrsReconcileHdr>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderDate, e.ReconcileId })
                    .IsClustered(false);

                entity.ToTable("SRS_Reconcile_HDR");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReconcileId)
                    .HasColumnName("Reconcile_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FinalSubmit)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.GrossSales)
                    .HasColumnName("Gross_Sales")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PosSales)
                    .HasColumnName("POS_Sales")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.PreparedBy)
                    .IsRequired()
                    .HasColumnName("Prepared_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PreparedDate)
                    .HasColumnName("Prepared_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesVariance)
                    .HasColumnName("Sales_Variance")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.SrsReconcileHdr)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SRS_Reconcile_HDR_Location_Codes");
            });

            modelBuilder.Entity<SrsReconcileOrderDetails>(entity =>
            {
                entity.HasKey(e => new { e.ReconcileId, e.LocationCode, e.OrderDate, e.OrderNumber, e.PaymentLineNumber, e.Sequence });

                entity.ToTable("SRS_Reconcile_OrderDetails");

                entity.Property(e => e.ReconcileId).HasColumnName("Reconcile_ID");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.PaymentLineNumber).HasColumnName("Payment_Line_Number");

                entity.Property(e => e.AcquireName)
                    .HasColumnName("Acquire_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovalCode)
                    .HasColumnName("Approval_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankInfo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BatchNumber)
                    .HasColumnName("Batch_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardType)
                    .HasColumnName("Card_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CashOutId)
                    .HasColumnName("CashOut_Id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DelayedOrder).HasColumnName("Delayed_Order");

                entity.Property(e => e.DriverName)
                    .HasColumnName("Driver_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EdcrefId)
                    .HasColumnName("EDCRefId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderAmount)
                    .HasColumnName("Order_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.OrderPayTypeCode).HasColumnName("Order_Pay_Type_Code");

                entity.Property(e => e.OrderPayTypeDesc)
                    .HasColumnName("Order_Pay_Type_Desc")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTypeCode)
                    .IsRequired()
                    .HasColumnName("Order_Type_Code")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTypeDesc)
                    .IsRequired()
                    .HasColumnName("Order_Type_Desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentAmount)
                    .HasColumnName("Payment_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.PaymentMode)
                    .HasColumnName("Payment_Mode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseCode)
                    .HasColumnName("Response_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPayHead)
                    .HasColumnName("Sales_Pay_Head")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPayId).HasColumnName("Sales_Pay_ID");

                entity.Property(e => e.SalesVariance)
                    .HasColumnName("Sales_Variance")
                    .HasColumnType("money");

                entity.Property(e => e.TentNumber)
                    .HasColumnName("Tent_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tid)
                    .HasColumnName("TID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId).HasColumnName("Transaction_ID");

                entity.Property(e => e.TransactionTime)
                    .HasColumnName("Transaction_Time")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.SrsReconcileHdr)
                    .WithMany(p => p.SrsReconcileOrderDetails)
                    .HasForeignKey(d => new { d.LocationCode, d.OrderDate, d.ReconcileId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SRS_Reconcile_OrderDetails_SRS_Reconcile_HDR");
            });

            modelBuilder.Entity<StartUpScreenTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.StartUpScreenCode });

                entity.ToTable("Start_Up_Screen_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StartUpScreenCode).HasColumnName("Start_Up_Screen_Code");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StationControl>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.StationId })
                    .IsClustered(false);

                entity.ToTable("Station_Control");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.StationId).HasColumnName("Station_ID");

                entity.Property(e => e.CreditCardId).HasColumnName("Credit_Card_ID");
            });

            modelBuilder.Entity<StationUpdateList>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.StationName });

                entity.ToTable("Station_Update_List");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.StationName)
                    .HasColumnName("Station_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CallingApp)
                    .HasColumnName("Calling_App")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileUpdateList)
                    .IsRequired()
                    .HasColumnName("File_Update_List")
                    .IsUnicode(false);

                entity.Property(e => e.IsExecuting).HasColumnName("Is_Executing");
            });

            modelBuilder.Entity<StationUpdateListUpdateFiles>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.StationName });

                entity.ToTable("Station_Update_List_Update_Files");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.StationName)
                    .HasColumnName("Station_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CallingApp)
                    .HasColumnName("Calling_App")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileUpdateList)
                    .IsRequired()
                    .HasColumnName("File_Update_List")
                    .IsUnicode(false);

                entity.Property(e => e.IsExecuting).HasColumnName("Is_Executing");
            });

            modelBuilder.Entity<StatusCodes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.StatusCode });

                entity.ToTable("Status_Codes");

                entity.HasIndex(e => e.StatusCode)
                    .HasName("Status_ID");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StatusCode).HasColumnName("Status_Code");

                entity.Property(e => e.Description)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StnDataLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STN_DATA_LOG");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnName("Delivery_Date")
                    .HasColumnType("date");

                entity.Property(e => e.DeliveryId).HasColumnName("Delivery_ID");

                entity.Property(e => e.DeliveryType).HasColumnName("Delivery_Type");

                entity.Property(e => e.ErrorMessage).HasColumnType("text");

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecordCount).HasColumnName("Record_Count");

                entity.Property(e => e.RequestData).IsUnicode(false);

                entity.Property(e => e.RequestId)
                    .HasColumnName("Request_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Response).HasColumnType("text");
            });

            modelBuilder.Entity<StnErrorLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STN_ERROR_LOG");

                entity.Property(e => e.Errorline)
                    .HasColumnName("ERRORLINE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Errormessage)
                    .HasColumnName("ERRORMESSAGE")
                    .HasColumnType("text");

                entity.Property(e => e.Errornumber)
                    .HasColumnName("ERRORNUMBER")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Errorprocedure)
                    .HasColumnName("ERRORPROCEDURE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Errorseverity)
                    .HasColumnName("ERRORSEVERITY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Errorstate)
                    .HasColumnName("ERRORSTATE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LocnCode)
                    .HasColumnName("LOCN_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequestId)
                    .HasColumnName("REQUEST_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDesc)
                    .HasColumnName("STATUS_DESC")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("TIME_STAMP")
                    .HasColumnType("datetime");

                entity.Property(e => e.XmlfileName)
                    .HasColumnName("XMLFILE_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StoreHours>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.DayOfWeek, e.OpenTime });

                entity.ToTable("Store_Hours");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OpenTime)
                    .HasColumnName("Open_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CloseTime)
                    .HasColumnName("Close_Time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Streets>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.StreetCode })
                    .IsClustered(false);

                entity.HasIndex(e => e.CityCode)
                    .HasName("CityStreets");

                entity.HasIndex(e => e.StreetName)
                    .HasName("Street_Name");

                entity.HasIndex(e => new { e.LocationCode, e.StreetName, e.CityCode, e.PreDirection, e.PostDirection })
                    .HasName("idxUniqueStreet")
                    .IsUnique();

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.StreetCode).HasColumnName("Street_Code");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AddedManually)
                    .HasColumnName("Added_Manually")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CityCode).HasColumnName("City_Code");

                entity.Property(e => e.PostDirection)
                    .HasColumnName("Post_Direction")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PreDirection)
                    .HasColumnName("Pre_Direction")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StreetName)
                    .IsRequired()
                    .HasColumnName("Street_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SubStreets>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.SequenceNumber })
                    .IsClustered(false);

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.HasIndex(e => e.PostalCode)
                    .HasName("Postal_CodesSubStreets");

                entity.HasIndex(e => e.PriLowerBound)
                    .HasName("Pri_Lower_Bound");

                entity.HasIndex(e => e.PriOddEven)
                    .HasName("Pri_Odd_Even");

                entity.HasIndex(e => e.PriUpperBound)
                    .HasName("Pri_Upper_Bound");

                entity.HasIndex(e => e.SecLowerBound)
                    .HasName("Sec_Lower_Bound");

                entity.HasIndex(e => e.SecOddEven)
                    .HasName("Sec_Odd_Even");

                entity.HasIndex(e => e.SecUpperBound)
                    .HasName("Sec_Upper_Bound");

                entity.HasIndex(e => e.StreetCode)
                    .HasName("StreetsSubStreets");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AddedManually)
                    .HasColumnName("Added_Manually")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CarRoute)
                    .HasColumnName("Car_Route")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("Postal_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PriLowerBound)
                    .HasColumnName("Pri_Lower_Bound")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PriOddEven)
                    .HasColumnName("Pri_Odd_Even")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PriUpperBound)
                    .HasColumnName("Pri_Upper_Bound")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SecLowerBound)
                    .HasColumnName("Sec_Lower_Bound")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SecOddEven)
                    .HasColumnName("Sec_Odd_Even")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SecUpperBound)
                    .HasColumnName("Sec_Upper_Bound")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StreetCode)
                    .HasColumnName("Street_Code")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Zip4LowerBound)
                    .HasColumnName("Zip4Lower_Bound")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Zip4UpperBound)
                    .HasColumnName("Zip4Upper_Bound")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SystemAccountsSql>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.AccountId });

                entity.ToTable("System_Accounts_SQL");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AccountId).HasColumnName("Account_ID");

                entity.Property(e => e.SqlStatement)
                    .IsRequired()
                    .HasColumnName("SQL_Statement")
                    .HasMaxLength(5000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SystemPasswords>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("aaaaaSystem_Passwords_PK")
                    .IsClustered(false);

                entity.ToTable("System_Passwords");

                entity.HasIndex(e => e.UserId)
                    .HasName("User_ID");

                entity.Property(e => e.UserId)
                    .HasColumnName("User_ID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Password).HasMaxLength(100);
            });

            modelBuilder.Entity<TaxCalculationCodes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.TaxCalculationCode });

                entity.ToTable("Tax_Calculation_Codes");

                entity.HasIndex(e => e.TaxCalculationCode)
                    .HasName("Tax_Calculation_Code");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TaxCalculationCode).HasColumnName("Tax_Calculation_Code");

                entity.Property(e => e.Description)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TaxCategories>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.TaxCategoryId });

                entity.ToTable("Tax_Categories");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCategoryId).HasColumnName("Tax_Category_ID");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCategoryCode)
                    .IsRequired()
                    .HasColumnName("Tax_Category_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCategoryDescription)
                    .HasColumnName("Tax_Category_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TaxName>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tax_name");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxId)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TaxName1)
                    .HasColumnName("TaxName")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TaxType>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.TaxTypeCode })
                    .IsClustered(false);

                entity.ToTable("Tax_Type");

                entity.HasIndex(e => e.TaxTypeCode)
                    .HasName("Tax_Type_ID");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.TaxTypeCode).HasColumnName("Tax_Type_Code");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempComputer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_COMPUTER");

                entity.Property(e => e.ComputerName)
                    .HasColumnName("COMPUTER_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempDbobjects>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempDBObjects");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddedDate)
                    .HasColumnName("Added_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedIpAddress)
                    .IsRequired()
                    .HasColumnName("Modified_IP_Address")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OldVersion)
                    .HasColumnName("Old_Version")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SetupModifiedDate)
                    .HasColumnName("Setup_Modified_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SubType)
                    .IsRequired()
                    .HasColumnName("Sub_Type")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempFooter>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ReceiptMessageBottom)
                    .HasColumnName("receipt_message_bottom")
                    .HasMaxLength(450)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempIstStnData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_IST_STN_DATA");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnName("Delivery_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeliveryId).HasColumnName("Delivery_ID");

                entity.Property(e => e.InventoryCode)
                    .HasColumnName("Inventory_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.UnitCost)
                    .HasColumnName("Unit_Cost")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.VendorCode)
                    .HasColumnName("Vendor_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempOrderLineUdt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_order_line_udt");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LineNumber).HasColumnName("Line_Number");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderLineNonTaxableSale1)
                    .HasColumnName("Order_Line_Non_Taxable_Sale1")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineNonTaxableSale2)
                    .HasColumnName("Order_Line_Non_Taxable_Sale2")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineNonTaxableSale3)
                    .HasColumnName("Order_Line_Non_Taxable_Sale3")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineNonTaxableSale4)
                    .HasColumnName("Order_Line_Non_Taxable_Sale4")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTax1)
                    .HasColumnName("Order_Line_Tax1")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTax2)
                    .HasColumnName("Order_Line_Tax2")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTax3)
                    .HasColumnName("Order_Line_Tax3")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTax4)
                    .HasColumnName("Order_Line_Tax4")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTaxableSale1)
                    .HasColumnName("Order_Line_Taxable_Sale1")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTaxableSale2)
                    .HasColumnName("Order_Line_Taxable_Sale2")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTaxableSale3)
                    .HasColumnName("Order_Line_Taxable_Sale3")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTaxableSale4)
                    .HasColumnName("Order_Line_Taxable_Sale4")
                    .HasColumnType("money");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.Tax1Discounted).HasColumnName("Tax_1_Discounted");

                entity.Property(e => e.Tax1ItemMinAmount)
                    .HasColumnName("Tax_1_Item_Min_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax1Rate).HasColumnName("Tax_1_Rate");

                entity.Property(e => e.Tax1TaxableAmount)
                    .HasColumnName("Tax_1_Taxable_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax2Discounted).HasColumnName("Tax_2_Discounted");

                entity.Property(e => e.Tax2ItemMinAmount)
                    .HasColumnName("Tax_2_Item_Min_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax2Rate).HasColumnName("Tax_2_Rate");

                entity.Property(e => e.Tax2TaxableAmount)
                    .HasColumnName("Tax_2_Taxable_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax3Discounted).HasColumnName("Tax_3_Discounted");

                entity.Property(e => e.Tax3ItemMinAmount)
                    .HasColumnName("Tax_3_Item_Min_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax3Rate).HasColumnName("Tax_3_Rate");

                entity.Property(e => e.Tax3TaxableAmount)
                    .HasColumnName("Tax_3_Taxable_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax4Discounted).HasColumnName("Tax_4_Discounted");

                entity.Property(e => e.Tax4ItemMinAmount)
                    .HasColumnName("Tax_4_Item_Min_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax4Rate).HasColumnName("Tax_4_Rate");

                entity.Property(e => e.Tax4TaxableAmount)
                    .HasColumnName("Tax_4_Taxable_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.TaxCategoryId).HasColumnName("Tax_Category_ID");

                entity.Property(e => e.TaxableByMargin).HasColumnName("Taxable_By_Margin");
            });

            modelBuilder.Entity<TempOrderLines>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_order_lines");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BasePrice)
                    .HasColumnName("Base_Price")
                    .HasColumnType("money");

                entity.Property(e => e.BasePrice2)
                    .HasColumnName("Base_Price2")
                    .HasColumnType("money");

                entity.Property(e => e.BottleDeposit)
                    .HasColumnName("Bottle_Deposit")
                    .HasColumnType("money");

                entity.Property(e => e.CalculateIfc).HasColumnName("Calculate_IFC");

                entity.Property(e => e.ComboGroup).HasColumnName("Combo_Group");

                entity.Property(e => e.ComboItemNumber).HasColumnName("Combo_Item_Number");

                entity.Property(e => e.ComboMenuCode)
                    .HasColumnName("Combo_Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ComboSizeCode)
                    .HasColumnName("Combo_Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CouponAdjustment).HasColumnName("Coupon_Adjustment");

                entity.Property(e => e.CouponAmount)
                    .HasColumnName("Coupon_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.CouponCode)
                    .HasColumnName("Coupon_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CouponMinPrice)
                    .HasColumnName("Coupon_Min_Price")
                    .HasColumnType("money");

                entity.Property(e => e.CouponTaxable).HasColumnName("Coupon_Taxable");

                entity.Property(e => e.CouponTypeCode).HasColumnName("Coupon_Type_Code");

                entity.Property(e => e.CreditDiscount)
                    .HasColumnName("Credit_Discount")
                    .HasColumnType("money");

                entity.Property(e => e.DoublesBypassed).HasColumnName("Doubles_Bypassed");

                entity.Property(e => e.DoublesGroup).HasColumnName("Doubles_Group");

                entity.Property(e => e.InstructionString)
                    .HasColumnName("Instruction_String")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LineNumber).HasColumnName("Line_Number");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCategoryCode)
                    .HasColumnName("Menu_Category_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuItemTypeCode).HasColumnName("Menu_Item_Type_Code");

                entity.Property(e => e.MenuPrice)
                    .HasColumnName("Menu_Price")
                    .HasColumnType("money");

                entity.Property(e => e.MenuPrice2)
                    .HasColumnName("Menu_Price2")
                    .HasColumnType("money");

                entity.Property(e => e.MenuTypeId).HasColumnName("Menu_Type_ID");

                entity.Property(e => e.OrderCouponAmount)
                    .HasColumnName("Order_Coupon_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderLineCouponAmount)
                    .HasColumnName("Order_Line_Coupon_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineNoTaxDiscount)
                    .HasColumnName("Order_Line_No_Tax_Discount")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineNonTaxableSale)
                    .HasColumnName("Order_Line_Non_Taxable_Sale")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineStatusCode).HasColumnName("Order_Line_Status_Code");

                entity.Property(e => e.OrderLineTax1)
                    .HasColumnName("Order_Line_Tax1")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTax2)
                    .HasColumnName("Order_Line_Tax2")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTaxDiscount)
                    .HasColumnName("Order_Line_Tax_Discount")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTaxableSale1)
                    .HasColumnName("Order_Line_Taxable_Sale1")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTaxableSale2)
                    .HasColumnName("Order_Line_Taxable_Sale2")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTotal)
                    .HasColumnName("Order_Line_Total")
                    .HasColumnType("money");

                entity.Property(e => e.OrderNoTaxDiscount)
                    .HasColumnName("Order_No_Tax_Discount")
                    .HasColumnType("money");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.OrderSavedTime)
                    .HasColumnName("Order_Saved_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderTaxDiscount)
                    .HasColumnName("Order_Tax_Discount")
                    .HasColumnType("money");

                entity.Property(e => e.OrigMenuCode)
                    .HasColumnName("Orig_Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OvenTime)
                    .HasColumnName("Oven_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.SizeCode)
                    .HasColumnName("Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ToppingCodes)
                    .HasColumnName("Topping_Codes")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ToppingCount).HasColumnName("Topping_Count");

                entity.Property(e => e.ToppingDescriptions)
                    .HasColumnName("Topping_Descriptions")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ToppingString)
                    .HasColumnName("Topping_String")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempOrderPayments>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_order_payments");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AmountTendered)
                    .HasColumnName("Amount_Tendered")
                    .HasColumnType("money");

                entity.Property(e => e.CashOutId)
                    .HasColumnName("CashOut_ID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CashOutShift).HasColumnName("Cash_Out_Shift");

                entity.Property(e => e.CashOutTime)
                    .HasColumnName("CashOut_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChangeDue)
                    .HasColumnName("Change_Due")
                    .HasColumnType("money");

                entity.Property(e => e.CheckInfo)
                    .HasColumnName("Check_Info")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyAmount)
                    .HasColumnName("Currency_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("Currency_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.OrderPayTypeCode).HasColumnName("Order_Pay_Type_Code");

                entity.Property(e => e.PaymentAmount)
                    .HasColumnName("Payment_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.PaymentLineNumber).HasColumnName("Payment_Line_Number");

                entity.Property(e => e.Tip).HasColumnType("money");
            });

            modelBuilder.Entity<TempRecap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_Recap");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("Category_Name")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DailyCost)
                    .HasColumnName("Daily_Cost")
                    .HasColumnType("money");

                entity.Property(e => e.DailyIdeal)
                    .HasColumnName("Daily_Ideal")
                    .HasColumnType("money");

                entity.Property(e => e.DailyWaste)
                    .HasColumnName("Daily_Waste")
                    .HasColumnType("money");

                entity.Property(e => e.WtdCost)
                    .HasColumnName("WTD_Cost")
                    .HasColumnType("money");

                entity.Property(e => e.WtdIdeal)
                    .HasColumnName("WTD_Ideal")
                    .HasColumnType("money");

                entity.Property(e => e.WtdWaste)
                    .HasColumnName("WTD_Waste")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TempZero>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_Zero");

                entity.Property(e => e.Blank)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Zero).HasColumnType("money");
            });

            modelBuilder.Entity<Text1>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.KeyField })
                    .IsClustered(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.KeyField).HasColumnName("Key_Field");

                entity.Property(e => e.EnglishText)
                    .IsRequired()
                    .HasColumnName("English_Text")
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedText)
                    .IsRequired()
                    .HasColumnName("Modified_Text")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TextTables>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.Id });

                entity.ToTable("Text_Tables");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DisplayTableName)
                    .HasColumnName("Display_Table_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTableName)
                    .HasColumnName("English_Table_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasColumnName("Table_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TableOrder)
                    .HasColumnName("Table_Order")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TimeClock>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.EmployeeCode, e.PositionCode, e.SystemDate, e.PositionShiftNumber })
                    .IsClustered(false);

                entity.ToTable("Time_Clock");

                entity.HasIndex(e => e.DateShiftNumber)
                    .HasName("Shift_Number");

                entity.HasIndex(e => e.EmployeeCode)
                    .HasName("Employee_Code");

                entity.HasIndex(e => e.PositionCode)
                    .HasName("Position_Code");

                entity.HasIndex(e => e.PositionShiftNumber)
                    .HasName("Position_Shift_Number");

                entity.HasIndex(e => e.SystemDate)
                    .HasName("System_Date");

                entity.HasIndex(e => e.TimeIn)
                    .HasName("Time_In");

                entity.HasIndex(e => e.TimeOut)
                    .HasName("Time_Out");

                entity.HasIndex(e => new { e.LocationCode, e.EmployeeCode, e.PositionCode })
                    .HasName("Employee_PositionTime_Clock");

                entity.HasIndex(e => new { e.LocationCode, e.EmployeeCode, e.SystemDate, e.DateShiftNumber })
                    .HasName("idx_UniqueShift")
                    .IsUnique();

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCode)
                    .HasColumnName("Employee_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PositionCode)
                    .HasColumnName("Position_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("System_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PositionShiftNumber).HasColumnName("Position_Shift_Number");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AllocatedTips)
                    .HasColumnName("Allocated_Tips")
                    .HasColumnType("money");

                entity.Property(e => e.BeginOdometer)
                    .HasColumnName("Begin_Odometer")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BonusMileage)
                    .HasColumnName("Bonus_Mileage")
                    .HasColumnType("money");

                entity.Property(e => e.BonusPay)
                    .HasColumnName("Bonus_Pay")
                    .HasColumnType("money");

                entity.Property(e => e.CarTop).HasColumnName("Car_Top");

                entity.Property(e => e.Collected).HasColumnType("money");

                entity.Property(e => e.ContractPay)
                    .HasColumnName("Contract_Pay")
                    .HasColumnType("money");

                entity.Property(e => e.CreditCardTips)
                    .HasColumnName("Credit_Card_Tips")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DateShiftNumber).HasColumnName("Date_Shift_Number");

                entity.Property(e => e.EndOdometer)
                    .HasColumnName("End_Odometer")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExcessMileage)
                    .HasColumnName("Excess_Mileage")
                    .HasColumnType("money");

                entity.Property(e => e.MileageRate)
                    .HasColumnName("Mileage_Rate")
                    .HasColumnType("money");

                entity.Property(e => e.MileageRateUsed)
                    .HasColumnName("Mileage_Rate_Used")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PayRate)
                    .HasColumnName("Pay_Rate")
                    .HasColumnType("money");

                entity.Property(e => e.PersonalCar).HasColumnName("Personal_Car");

                entity.Property(e => e.RegularMileage)
                    .HasColumnName("Regular_Mileage")
                    .HasColumnType("money");

                entity.Property(e => e.TillStartingAmount)
                    .HasColumnName("Till_Starting_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.TimeIn)
                    .HasColumnName("Time_In")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeOut)
                    .HasColumnName("Time_Out")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tips).HasColumnType("money");

                entity.Property(e => e.TotalPay)
                    .HasColumnName("Total_Pay")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TimeClockBiometric>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Time_Clock_Biometric");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BiometricTimeIn)
                    .HasColumnName("Biometric_TimeIn")
                    .HasColumnType("datetime");

                entity.Property(e => e.BiometricTimeOut)
                    .HasColumnName("Biometric_TimeOut")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateShiftNumber).HasColumnName("Date_Shift_Number");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasColumnName("Employee_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PositionCode)
                    .IsRequired()
                    .HasColumnName("Position_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("System_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeIn)
                    .HasColumnName("Time_In")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeOut)
                    .HasColumnName("Time_Out")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TimeClockLog>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.Id });

                entity.ToTable("Time_Clock_Log");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BeginOdometer).HasColumnName("Begin_Odometer");

                entity.Property(e => e.BonusMileage)
                    .HasColumnName("Bonus_Mileage")
                    .HasColumnType("money");

                entity.Property(e => e.BonusPay)
                    .HasColumnName("Bonus_Pay")
                    .HasColumnType("money");

                entity.Property(e => e.CarTop).HasColumnName("Car_Top");

                entity.Property(e => e.Collected).HasColumnType("money");

                entity.Property(e => e.DateShiftNumber).HasColumnName("Date_Shift_Number");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasColumnName("Employee_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EndOdometer).HasColumnName("End_Odometer");

                entity.Property(e => e.MileageRate)
                    .HasColumnName("Mileage_Rate")
                    .HasColumnType("money");

                entity.Property(e => e.MileageRateUsed)
                    .HasColumnName("Mileage_Rate_Used")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PersonalCar).HasColumnName("Personal_Car");

                entity.Property(e => e.PositionCode)
                    .IsRequired()
                    .HasColumnName("Position_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PositionShiftNumber).HasColumnName("Position_Shift_Number");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("System_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeIn)
                    .HasColumnName("Time_In")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeOut)
                    .HasColumnName("Time_Out")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tips).HasColumnType("money");

                entity.Property(e => e.TotalPay)
                    .HasColumnName("Total_Pay")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<Tmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp");

                entity.Property(e => e.OrderLineNonTaxableSale1)
                    .HasColumnName("Order_Line_Non_Taxable_Sale1")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineNonTaxableSale2)
                    .HasColumnName("Order_Line_Non_Taxable_Sale2")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineNonTaxableSale3)
                    .HasColumnName("Order_Line_Non_Taxable_Sale3")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineNonTaxableSale4)
                    .HasColumnName("Order_Line_Non_Taxable_Sale4")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTax1)
                    .HasColumnName("Order_Line_Tax1")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTax2)
                    .HasColumnName("Order_Line_Tax2")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTax3)
                    .HasColumnName("Order_Line_Tax3")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTax4)
                    .HasColumnName("Order_Line_Tax4")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTaxableSale1)
                    .HasColumnName("Order_Line_Taxable_Sale1")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTaxableSale2)
                    .HasColumnName("Order_Line_Taxable_Sale2")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTaxableSale3)
                    .HasColumnName("Order_Line_Taxable_Sale3")
                    .HasColumnType("money");

                entity.Property(e => e.OrderLineTaxableSale4)
                    .HasColumnName("Order_Line_Taxable_Sale4")
                    .HasColumnType("money");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("System_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tax1Discounted).HasColumnName("Tax_1_Discounted");

                entity.Property(e => e.Tax1ItemMinAmount)
                    .HasColumnName("Tax_1_Item_Min_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax1Rate).HasColumnName("Tax_1_Rate");

                entity.Property(e => e.Tax1TaxableAmount)
                    .HasColumnName("Tax_1_Taxable_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax2Discounted).HasColumnName("Tax_2_Discounted");

                entity.Property(e => e.Tax2ItemMinAmount)
                    .HasColumnName("Tax_2_Item_Min_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax2Rate).HasColumnName("Tax_2_Rate");

                entity.Property(e => e.Tax2TaxableAmount)
                    .HasColumnName("Tax_2_Taxable_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax3Discounted).HasColumnName("Tax_3_Discounted");

                entity.Property(e => e.Tax3ItemMinAmount)
                    .HasColumnName("Tax_3_Item_Min_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax3Rate).HasColumnName("Tax_3_Rate");

                entity.Property(e => e.Tax3TaxableAmount)
                    .HasColumnName("Tax_3_Taxable_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax4Discounted).HasColumnName("Tax_4_Discounted");

                entity.Property(e => e.Tax4ItemMinAmount)
                    .HasColumnName("Tax_4_Item_Min_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax4Rate).HasColumnName("Tax_4_Rate");

                entity.Property(e => e.Tax4TaxableAmount)
                    .HasColumnName("Tax_4_Taxable_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.TaxCategoryId).HasColumnName("Tax_Category_ID");

                entity.Property(e => e.TaxableByMargin).HasColumnName("Taxable_By_Margin");
            });

            modelBuilder.Entity<TmpMakeLineDisplay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tmp_Make_Line_Display");

                entity.Property(e => e.ActualOrderDate)
                    .HasColumnName("Actual_Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerCode)
                    .HasColumnName("Customer_Code")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId).HasColumnName("Device_ID");

                entity.Property(e => e.GridDisplay).HasColumnName("Grid_Display");

                entity.Property(e => e.Instructions)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.KitchenDisplayTime)
                    .HasColumnName("Kitchen_Display_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LineNumber).HasColumnName("Line_Number");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MakeQty).HasColumnName("Make_Qty");

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderDateTime).HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.OrderSaved)
                    .HasColumnName("Order_Saved")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderStatus).HasColumnName("Order_Status");

                entity.Property(e => e.OrderStatusCode).HasColumnName("Order_Status_Code");

                entity.Property(e => e.OrderTakerId)
                    .HasColumnName("Order_Taker_ID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTime)
                    .HasColumnName("Order_Time")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderTypeCode)
                    .HasColumnName("Order_Type_Code")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OtsNumber)
                    .HasColumnName("OTS_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductType).HasColumnName("Product_Type");

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.SizeCode)
                    .HasColumnName("Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ToppingCodes)
                    .HasColumnName("Topping_Codes")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ToppingDescriptions)
                    .HasColumnName("Topping_Descriptions")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.WorkStaionName)
                    .HasColumnName("WorkStaion_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ToppingAmountCodes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.AmountCode })
                    .IsClustered(false);

                entity.ToTable("Topping_Amount_Codes");

                entity.HasIndex(e => new { e.LocationCode, e.AmountCode })
                    .HasName("Amount_Code")
                    .IsUnique();

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AmountCode)
                    .HasColumnName("Amount_Code")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IfcToppingAmount)
                    .HasColumnName("IFC_Topping_Amount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NumberOfToppings)
                    .HasColumnName("Number_of_Toppings")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SortOrder).HasColumnName("Sort_order");
            });

            modelBuilder.Entity<ToppingPercentages>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.ToppingCount })
                    .IsClustered(false);

                entity.ToTable("Topping_Percentages");

                entity.HasIndex(e => e.LocationCode)
                    .HasName("Location_Code");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ToppingCount).HasColumnName("Topping_Count");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PercentUsed).HasColumnName("Percent_Used");
            });

            modelBuilder.Entity<TransactionPaymentTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.TransactionPaymentType });

                entity.ToTable("Transaction_Payment_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TransactionPaymentType).HasColumnName("Transaction_Payment_Type");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .IsRequired()
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Transactions>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.TransactionDate, e.AccountId, e.TransactionSequence })
                    .IsClustered(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate)
                    .HasColumnName("Transaction_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AccountId).HasColumnName("Account_ID");

                entity.Property(e => e.TransactionSequence).HasColumnName("Transaction_Sequence");

                entity.Property(e => e.AccountCode)
                    .IsRequired()
                    .HasColumnName("Account_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AccountDescription)
                    .HasColumnName("Account_Description")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AccountTypeCode).HasColumnName("Account_Type_Code");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyAmount)
                    .HasColumnName("Currency_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("Currency_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDestination)
                    .HasColumnName("Posting_Destination")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PostingType)
                    .HasColumnName("Posting_Type")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SubAccountCode)
                    .HasColumnName("sub_account_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SystemAccount).HasColumnName("System_Account");

                entity.Property(e => e.TransactionAmount)
                    .HasColumnName("Transaction_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.TransactionDescription)
                    .HasColumnName("Transaction_Description")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionNumber)
                    .IsRequired()
                    .HasColumnName("Transaction_Number")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionPaymentDescription)
                    .IsRequired()
                    .HasColumnName("Transaction_Payment_Description")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionPaymentType)
                    .HasColumnName("Transaction_Payment_Type")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TransactionStatus).HasColumnName("Transaction_Status");
            });

            modelBuilder.Entity<UdtorderPayments1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UDTOrderPayments1");

                entity.Property(e => e.Amont).HasColumnType("money");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.OrderPayType).HasColumnName("Order_Pay_Type");
            });

            modelBuilder.Entity<UpdateBehaviorCodes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.UpdateBehaviorCode })
                    .HasName("PK_Update_Behavior_Type");

                entity.ToTable("Update_Behavior_Codes");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateBehaviorCode).HasColumnName("Update_Behavior_Code");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UpsellHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Upsell_History");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCategoryCode)
                    .HasColumnName("Menu_Category_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SizeCode)
                    .HasColumnName("Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UpsellMaster>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.LocationCode, e.MenuCode, e.SizeCode })
                    .HasName("PK_UpsellMaster1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SizeCode)
                    .HasColumnName("Size_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AddedOn)
                    .HasColumnName("Added_On")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.StatusCode).HasColumnName("Status_Code");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnName("Updated_On")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserType)
                    .HasColumnName("User_Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MenuItems)
                    .WithMany(p => p.UpsellMaster)
                    .HasForeignKey(d => new { d.LocationCode, d.MenuCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UpsellMaster_Menu_Items1");
            });

            modelBuilder.Entity<UpsellMasterLog>(entity =>
            {
                entity.ToTable("UpsellMaster_log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AddedDate)
                    .HasColumnName("Added_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.FkIdUsm).HasColumnName("FK_ID_USM");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCode)
                    .HasColumnName("Menu_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SizeCode)
                    .HasColumnName("Size_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode).HasColumnName("Status_Code");

                entity.Property(e => e.UserType)
                    .HasColumnName("User_Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserDefinedTaxRates>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.UserDefinedTaxRateId });

                entity.ToTable("User_Defined_Tax_Rates");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UserDefinedTaxRateId).HasColumnName("User_Defined_Tax_Rate_ID");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CityCode).HasColumnName("City_Code");

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasColumnName("Postal_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tax1CompoundTax2).HasColumnName("Tax_1_Compound_Tax_2");

                entity.Property(e => e.Tax1CompoundTax3).HasColumnName("Tax_1_Compound_Tax_3");

                entity.Property(e => e.Tax1CompoundTax4).HasColumnName("Tax_1_Compound_Tax_4");

                entity.Property(e => e.Tax1MinOrderAmount)
                    .HasColumnName("Tax_1_Min_Order_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax1MinOrderTax).HasColumnName("Tax_1_Min_Order_Tax");

                entity.Property(e => e.Tax2CompoundTax1).HasColumnName("Tax_2_Compound_Tax_1");

                entity.Property(e => e.Tax2CompoundTax3).HasColumnName("Tax_2_Compound_Tax_3");

                entity.Property(e => e.Tax2CompoundTax4).HasColumnName("Tax_2_Compound_Tax_4");

                entity.Property(e => e.Tax2MinOrderAmount)
                    .HasColumnName("Tax_2_Min_Order_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax2MinOrderTax).HasColumnName("Tax_2_Min_Order_Tax");

                entity.Property(e => e.Tax3CompoundTax1).HasColumnName("Tax_3_Compound_Tax_1");

                entity.Property(e => e.Tax3CompoundTax2).HasColumnName("Tax_3_Compound_Tax_2");

                entity.Property(e => e.Tax3CompoundTax4).HasColumnName("Tax_3_Compound_Tax_4");

                entity.Property(e => e.Tax3MinOrderAmount)
                    .HasColumnName("Tax_3_Min_Order_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax3MinOrderTax).HasColumnName("Tax_3_Min_Order_Tax");

                entity.Property(e => e.Tax4CompoundTax1).HasColumnName("Tax_4_Compound_Tax_1");

                entity.Property(e => e.Tax4CompoundTax2).HasColumnName("Tax_4_Compound_Tax_2");

                entity.Property(e => e.Tax4CompoundTax3).HasColumnName("Tax_4_Compound_Tax_3");

                entity.Property(e => e.Tax4MinOrderAmount)
                    .HasColumnName("Tax_4_Min_Order_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.Tax4MinOrderTax).HasColumnName("Tax_4_Min_Order_Tax");
            });

            modelBuilder.Entity<UserDefinedTaxRatesDetails>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.UserDefinedTaxRateId, e.TaxId, e.CategoryId });

                entity.ToTable("User_Defined_Tax_Rates_Details");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UserDefinedTaxRateId).HasColumnName("User_Defined_Tax_Rate_ID");

                entity.Property(e => e.TaxId).HasColumnName("Tax_ID");

                entity.Property(e => e.CategoryId).HasColumnName("Category_ID");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MinimumAmount)
                    .HasColumnName("Minimum_Amount")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<UsrIndentPushLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Usr_IndentPushLog");

                entity.Property(e => e.Dt)
                    .HasColumnName("dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("location_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SysDt)
                    .HasColumnName("sys_dt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<UsrPushPullStat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Usr_PushPullStat");

                entity.Property(e => e.Dpinum)
                    .HasColumnName("dpinum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ppdt)
                    .HasColumnName("ppdt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sysdt)
                    .HasColumnName("sysdt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsrTaxInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("usr_Tax_info");

                entity.Property(e => e.CityCode)
                    .IsRequired()
                    .HasColumnName("City_Code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CityName)
                    .HasColumnName("City_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("location_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MessageBottom)
                    .HasColumnName("message_bottom")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MessageTop)
                    .HasColumnName("message_top")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MultiTaxType)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TaxRate1)
                    .HasColumnName("Tax_Rate1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxRate2)
                    .HasColumnName("Tax_Rate2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxStructure)
                    .HasColumnName("Tax_Structure")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UtilityVersion>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Addedon)
                    .HasColumnName("ADDEDON")
                    .HasColumnType("datetime");

                entity.Property(e => e.Hustlever)
                    .HasColumnName("HUSTLEVER")
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("LOCATION_CODE")
                    .IsUnicode(false);

                entity.Property(e => e.Pushpullver)
                    .HasColumnName("PUSHPULLVER")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VbMenuItems>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.VbMenuItemId })
                    .IsClustered(false);

                entity.ToTable("VB_Menu_Items");

                entity.HasIndex(e => e.VbMenuItemId)
                    .HasName("Menu_Items_ID");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.VbMenuItemId).HasColumnName("VB_Menu_Item_ID");

                entity.Property(e => e.AdminNotAllowed)
                    .HasColumnName("Admin_Not_Allowed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Application)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MenuLevel)
                    .HasColumnName("Menu_Level")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PositionInMenu)
                    .HasColumnName("Position_In_Menu")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Restrictable).HasDefaultValueSql("((0))");

                entity.Property(e => e.SpecialFunction)
                    .HasColumnName("Special_Function")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VbEnglishDescription)
                    .HasColumnName("VB_English_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VbMenuItem)
                    .HasColumnName("VB_Menu_Item")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VbMenuItemDescription)
                    .HasColumnName("VB_Menu_Item_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VbMenuParent)
                    .HasColumnName("VB_Menu_Parent")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.VendorCode })
                    .IsClustered(false);

                entity.HasIndex(e => e.LocationCode)
                    .HasName("VendorLocation_Code");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCode)
                    .HasColumnName("Vendor_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("Postal_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasColumnName("Status_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorType)
                    .HasColumnName("Vendor_Type")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VendorOrders>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.VendorOrderId });

                entity.ToTable("Vendor_Orders");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VendorOrderId).HasColumnName("Vendor_Order_ID");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.HistoryBeginDate)
                    .HasColumnName("History_Begin_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HistoryEndDate)
                    .HasColumnName("History_End_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsUpload).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderTotal)
                    .HasColumnName("Order_Total")
                    .HasColumnType("money");

                entity.Property(e => e.ProjectedSales)
                    .HasColumnName("Projected_Sales")
                    .HasColumnType("money");

                entity.Property(e => e.VendorCode)
                    .IsRequired()
                    .HasColumnName("Vendor_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .IsRequired()
                    .HasColumnName("Vendor_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VendorOrdersDetails>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.VendorOrderId, e.InventoryCode });

                entity.ToTable("Vendor_Orders_Details");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VendorOrderId).HasColumnName("Vendor_Order_ID");

                entity.Property(e => e.InventoryCode)
                    .HasColumnName("Inventory_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ActualOrder)
                    .HasColumnName("Actual_Order")
                    .HasColumnType("money");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AmountNeeded)
                    .HasColumnName("Amount_Needed")
                    .HasColumnType("money");

                entity.Property(e => e.CurrentInventory)
                    .HasColumnName("Current_Inventory")
                    .HasColumnType("money");

                entity.Property(e => e.InventoryCountType)
                    .IsRequired()
                    .HasColumnName("Inventory_Count_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryDescription)
                    .IsRequired()
                    .HasColumnName("Inventory_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaxStockingLevel).HasColumnName("Max_Stocking_Level");

                entity.Property(e => e.MinStockingLevel).HasColumnName("Min_Stocking_Level");

                entity.Property(e => e.OrderCost)
                    .HasColumnName("Order_Cost")
                    .HasColumnType("money");

                entity.Property(e => e.OrderUnit)
                    .IsRequired()
                    .HasColumnName("Order_Unit")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.SuggestedOrder)
                    .HasColumnName("Suggested_Order")
                    .HasColumnType("money");

                entity.Property(e => e.VendorItemCode)
                    .IsRequired()
                    .HasColumnName("Vendor_Item_Code")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VersionControl>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PK_Version_Control_1");

                entity.ToTable("Version_Control");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddedDate)
                    .HasColumnName("Added_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedIpAddress)
                    .IsRequired()
                    .HasColumnName("Modified_IP_Address")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OldVersion)
                    .HasColumnName("Old_Version")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SetupModifiedDate)
                    .HasColumnName("Setup_Modified_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SubType)
                    .HasColumnName("Sub_Type")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VersionControlAppFile>(entity =>
            {
                entity.ToTable("Version_Control_AppFile");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddedDate)
                    .HasColumnName("Added_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileLastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedIpAddress)
                    .HasColumnName("Modified_IP_Address")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OldVersion)
                    .HasColumnName("Old_Version")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SetupModifiedDate)
                    .HasColumnName("Setup_Modified_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SubType)
                    .HasColumnName("Sub_Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VersionControlExceptionalFile>(entity =>
            {
                entity.ToTable("Version_Control_ExceptionalFile");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddedDate)
                    .HasColumnName("Added_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IpAddress)
                    .HasColumnName("IP_Address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsSync).HasDefaultValueSql("((0))");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SetupName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VersionControlHistory>(entity =>
            {
                entity.ToTable("Version_Control_History");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddedDate)
                    .HasColumnName("Added_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasColumnName("IP_Address")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NewVersion)
                    .HasColumnName("New_Version")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OldVersion)
                    .HasColumnName("Old_Version")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SubType)
                    .IsRequired()
                    .HasColumnName("Sub_Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VersionControlWatcherDirectoryPath>(entity =>
            {
                entity.HasKey(e => e.ProjectName)
                    .HasName("PK_Watcher_DirectoryPath_1");

                entity.ToTable("Version_Control_Watcher_DirectoryPath");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AddedDate)
                    .HasColumnName("Added_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DirectoryPath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VersionDiscrepancyLog>(entity =>
            {
                entity.HasKey(e => e.LocationCode);

                entity.ToTable("Version_Discrepancy_Log");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AddedDate)
                    .HasColumnName("Added_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastAlertDate)
                    .HasColumnName("Last_Alert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnName("Modified_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedIpAddress)
                    .IsRequired()
                    .HasColumnName("Modified_IP_Address")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewVersion)
                    .IsRequired()
                    .HasColumnName("New_Version")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OldVersion)
                    .IsRequired()
                    .HasColumnName("Old_Version")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SetupModifiedDate)
                    .HasColumnName("Setup_Modified_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SubType)
                    .IsRequired()
                    .HasColumnName("Sub_Type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VersionInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(8);

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.FileId).ValueGeneratedOnAdd();

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.FileType).HasMaxLength(10);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8);

                entity.Property(e => e.UpdateCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Version).HasMaxLength(10);
            });

            modelBuilder.Entity<VersionSetupDbobjects>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VersionSetupDBObjects");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SETUP')");

                entity.Property(e => e.AddedDate)
                    .HasColumnName("Added_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IsResolved)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSync)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedIpAddress)
                    .IsRequired()
                    .HasColumnName("Modified_IP_Address")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OldVersion)
                    .HasColumnName("Old_Version")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SetupModifiedDate)
                    .HasColumnName("Setup_Modified_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SubType)
                    .IsRequired()
                    .HasColumnName("Sub_Type")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('DB')");

                entity.Property(e => e.Version)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewAddressSample>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewAddressSample");

                entity.Property(e => e.AddressLine2)
                    .HasColumnName("Address_Line_2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine3)
                    .HasColumnName("Address_Line_3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine4)
                    .HasColumnName("Address_Line_4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressType)
                    .HasColumnName("Address_Type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CityName)
                    .HasColumnName("City_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrossStreetCode).HasColumnName("Cross_Street_Code");

                entity.Property(e => e.CrossStreetName)
                    .HasColumnName("Cross_Street_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode).HasColumnName("Customer_Code");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasColumnName("Customer_Name")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerRoom)
                    .IsRequired()
                    .HasColumnName("Customer_Room")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddress)
                    .HasColumnName("Mailing_Address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneExt)
                    .HasColumnName("Phone_Ext")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("Phone_Number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Plus4)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PostDirection)
                    .HasColumnName("Post_Direction")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("Postal_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PreDirection)
                    .HasColumnName("Pre_Direction")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RegionAbbr)
                    .HasColumnName("Region_Abbr")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RegionName)
                    .HasColumnName("Region_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SectorCode)
                    .HasColumnName("Sector_Code")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SectorKey).HasColumnName("Sector_Key");

                entity.Property(e => e.SetDiscount).HasColumnName("Set_Discount");

                entity.Property(e => e.StreetCode).HasColumnName("Street_Code");

                entity.Property(e => e.StreetName)
                    .HasColumnName("Street_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StreetNumber)
                    .HasColumnName("Street_Number")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Suite)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TaxExempt1).HasColumnName("Tax_Exempt1");

                entity.Property(e => e.TaxExempt2).HasColumnName("Tax_Exempt2");

                entity.Property(e => e.TaxExempt3).HasColumnName("Tax_Exempt3");

                entity.Property(e => e.TaxExempt4).HasColumnName("Tax_Exempt4");

                entity.Property(e => e.TaxId1)
                    .HasColumnName("Tax_ID1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxId2)
                    .HasColumnName("Tax_ID2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxId3)
                    .HasColumnName("Tax_ID3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxId4)
                    .HasColumnName("Tax_ID4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxRate1).HasColumnName("Tax_Rate1");

                entity.Property(e => e.TaxRate2).HasColumnName("Tax_Rate2");

                entity.Property(e => e.TentNumber)
                    .HasColumnName("Tent_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewGetSrsReconciliationDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Get_SRS_Reconciliation_Details");

                entity.Property(e => e.AcquireName)
                    .HasColumnName("Acquire_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovalCode)
                    .HasColumnName("Approval_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankInfo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BatchNumber)
                    .HasColumnName("Batch_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardType)
                    .HasColumnName("Card_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CashOutId)
                    .HasColumnName("CashOut_Id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DelayedOrder).HasColumnName("Delayed_Order");

                entity.Property(e => e.DriverName)
                    .HasColumnName("Driver_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EdcrefId)
                    .HasColumnName("EDCRefId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderAmount)
                    .HasColumnName("Order_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.OrderPayTypeCode).HasColumnName("Order_Pay_Type_Code");

                entity.Property(e => e.OrderPayTypeDesc)
                    .HasColumnName("Order_Pay_Type_Desc")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTypeCode)
                    .HasColumnName("Order_Type_Code")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTypeDesc)
                    .IsRequired()
                    .HasColumnName("Order_Type_Desc")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentAmount)
                    .HasColumnName("Payment_Amount")
                    .HasColumnType("money");

                entity.Property(e => e.PaymentLineNumber).HasColumnName("Payment_Line_Number");

                entity.Property(e => e.PaymentMode)
                    .HasColumnName("Payment_Mode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseCode)
                    .HasColumnName("Response_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPayHead)
                    .IsRequired()
                    .HasColumnName("Sales_Pay_Head")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPayId).HasColumnName("Sales_Pay_ID");

                entity.Property(e => e.SalesVariance)
                    .HasColumnName("Sales_Variance")
                    .HasColumnType("money");

                entity.Property(e => e.TentNumber)
                    .HasColumnName("Tent_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tid)
                    .HasColumnName("TID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId).HasColumnName("Transaction_ID");

                entity.Property(e => e.TransactionTime)
                    .HasColumnName("Transaction_Time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewIfctoppingCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewIFCToppingCount");

                entity.Property(e => e.LineNumber).HasColumnName("Line_Number");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuOptionGroupCode)
                    .IsRequired()
                    .HasColumnName("menu_option_group_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.PizzaPart)
                    .IsRequired()
                    .HasColumnName("Pizza_Part")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ToppingCount).HasColumnName("topping_count");
            });

            modelBuilder.Entity<ViewIfctoppings>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewIFCToppings");

                entity.Property(e => e.InvMenuCode)
                    .HasColumnName("inv_menu_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LineNumber).HasColumnName("Line_Number");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MenuOptionGroupCode)
                    .IsRequired()
                    .HasColumnName("menu_option_group_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.PizzaPart)
                    .IsRequired()
                    .HasColumnName("Pizza_Part")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ToppingCount).HasColumnName("Topping_Count");
            });

            modelBuilder.Entity<ViewInventoryVendors>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewInventoryVendors");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryCode)
                    .IsRequired()
                    .HasColumnName("Inventory_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.VendorCode)
                    .HasColumnName("Vendor_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewOloadvanceSales>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_OLOAdvanceSales");

                entity.Property(e => e.Advcollection)
                    .IsRequired()
                    .HasColumnName("advcollection")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CancellationDate)
                    .HasColumnName("Cancellation_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CancellationReason)
                    .HasColumnName("Cancellation_Reason")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ClDate)
                    .HasColumnName("CL_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasColumnName("Coupon_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Gst)
                    .HasColumnName("GST")
                    .HasColumnType("money");

                entity.Property(e => e.InvoiceNumber)
                    .IsRequired()
                    .HasColumnName("invoice_number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderAmount)
                    .HasColumnName("order_amount")
                    .HasColumnType("money");

                entity.Property(e => e.OrderAmountBeforTax)
                    .HasColumnName("order_amount_befor_tax")
                    .HasColumnType("money");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderDeliveryDate)
                    .HasColumnName("order_delivery_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.OrderSavedDate)
                    .HasColumnName("order_saved_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasColumnName("Order_status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PosSalesOnTheDayOfDelivaryAfterEod)
                    .HasColumnName("POS_sales_on_the_day_of_delivary_After_EOD")
                    .HasColumnType("money");

                entity.Property(e => e.RefundAmountOfTheDay)
                    .HasColumnName("Refund_amount_Of_the_day")
                    .HasColumnType("money");

                entity.Property(e => e.StrCode)
                    .HasColumnName("STR_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TentNumber)
                    .HasColumnName("tent_number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalValue)
                    .HasColumnName("Total_value")
                    .HasColumnType("money");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("TYPE")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewRoutedriverReturnTimes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewROUTEDriverReturnTimes");

                entity.Property(e => e.EmployeeCode)
                    .HasColumnName("Employee_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnTime)
                    .HasColumnName("Return_Time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewRouteorderLabels>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewROUTEOrderLabels");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");
            });

            modelBuilder.Entity<ViewSecurityClassAccess>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewSecurityClassAccess");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasColumnName("Employee_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VbMenuItem)
                    .HasColumnName("VB_Menu_Item")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VbMenuItemId).HasColumnName("VB_Menu_Item_ID");
            });

            modelBuilder.Entity<ViewSecurityClassOverride>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewSecurityClassOverride");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasColumnName("Employee_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialFunction).HasColumnName("special_function");

                entity.Property(e => e.VbMenuItem)
                    .HasColumnName("VB_Menu_Item")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VbMenuItemId).HasColumnName("VB_Menu_Item_ID");
            });

            modelBuilder.Entity<ViewTimeClock>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewTimeClock");

                entity.Property(e => e.BonusPay)
                    .HasColumnName("Bonus_Pay")
                    .HasColumnType("money");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasColumnName("Employee_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCodeName)
                    .IsRequired()
                    .HasColumnName("Employee_Code_Name")
                    .HasMaxLength(57)
                    .IsUnicode(false);

                entity.Property(e => e.ExcessMileage)
                    .HasColumnName("Excess_Mileage")
                    .HasColumnType("money");

                entity.Property(e => e.GovernmentId)
                    .HasColumnName("Government_ID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PayRate)
                    .HasColumnName("Pay_Rate")
                    .HasColumnType("money");

                entity.Property(e => e.TotalPay)
                    .HasColumnName("Total_Pay")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<ViewTimeClockLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewTimeClockLog");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BeginOdometer).HasColumnName("Begin_Odometer");

                entity.Property(e => e.BonusMileage)
                    .HasColumnName("Bonus_Mileage")
                    .HasColumnType("money");

                entity.Property(e => e.BonusPay)
                    .HasColumnName("Bonus_Pay")
                    .HasColumnType("money");

                entity.Property(e => e.CarTop).HasColumnName("Car_Top");

                entity.Property(e => e.Collected).HasColumnType("money");

                entity.Property(e => e.DateShiftNumber).HasColumnName("Date_Shift_Number");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasColumnName("Employee_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EndOdometer).HasColumnName("End_Odometer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MileageRate)
                    .HasColumnName("Mileage_Rate")
                    .HasColumnType("money");

                entity.Property(e => e.MileageRateUsed).HasColumnName("Mileage_Rate_Used");

                entity.Property(e => e.PersonalCar).HasColumnName("Personal_Car");

                entity.Property(e => e.PositionCode)
                    .IsRequired()
                    .HasColumnName("Position_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PositionShiftNumber).HasColumnName("Position_Shift_Number");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("System_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeIn)
                    .HasColumnName("Time_In")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeOut)
                    .HasColumnName("Time_Out")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tips).HasColumnType("money");

                entity.Property(e => e.TotalPay)
                    .HasColumnName("Total_Pay")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<ViewTimeClockPerDay>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewTimeClockPerDay");

                entity.Property(e => e.BonusPay)
                    .HasColumnName("Bonus_Pay")
                    .HasColumnType("money");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasColumnName("Employee_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCodeName)
                    .IsRequired()
                    .HasColumnName("Employee_Code_Name")
                    .HasMaxLength(57)
                    .IsUnicode(false);

                entity.Property(e => e.ExcessMileage)
                    .HasColumnName("Excess_Mileage")
                    .HasColumnType("money");

                entity.Property(e => e.GovernmentId)
                    .HasColumnName("Government_ID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PayRate)
                    .HasColumnName("Pay_Rate")
                    .HasColumnType("money");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TotalPay)
                    .HasColumnName("Total_Pay")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<ViewTimeClockPerShift>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewTimeClockPerShift");

                entity.Property(e => e.BonusPay)
                    .HasColumnName("Bonus_Pay")
                    .HasColumnType("money");

                entity.Property(e => e.DateShiftNumber).HasColumnName("Date_Shift_Number");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasColumnName("Employee_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCodeName)
                    .IsRequired()
                    .HasColumnName("Employee_Code_Name")
                    .HasMaxLength(57)
                    .IsUnicode(false);

                entity.Property(e => e.ExcessMileage)
                    .HasColumnName("Excess_Mileage")
                    .HasColumnType("money");

                entity.Property(e => e.GovernmentId)
                    .HasColumnName("Government_ID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PayRate)
                    .HasColumnName("Pay_Rate")
                    .HasColumnType("money");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TotalPay)
                    .HasColumnName("Total_Pay")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<ViewUsrMissedCall>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_usr_missedCall");

                entity.Property(e => e.CallDateTime).HasColumnType("datetime");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MisCallerId).HasColumnName("mis_caller_id");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnName("Phone_Number")
                    .HasMaxLength(14)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VlmOrderStatus>(entity =>
            {
                entity.HasKey(e => e.VlmOrderStatusCode);

                entity.ToTable("VLM_Order_Status");

                entity.Property(e => e.VlmOrderStatusCode)
                    .HasColumnName("VLM_Order_Status_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VlmOrderStatusDescription)
                    .IsRequired()
                    .HasColumnName("VLM_Order_Status_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VlmPartner>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.VlmPartnerId });

                entity.ToTable("VLM_Partner");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VlmPartnerId)
                    .HasColumnName("VLM_Partner_ID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VlmPartnerDescription)
                    .IsRequired()
                    .HasColumnName("VLM_Partner_Description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VlmPartnerDllClassName)
                    .HasColumnName("VLM_Partner_DLL_Class_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VlmPartnerDllName)
                    .HasColumnName("VLM_Partner_DLL_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VlmPartnerOrders>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OrderDate, e.OrderNumber, e.Added })
                    .IsClustered(false);

                entity.ToTable("VLM_Partner_Orders");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasColumnName("Order_Number");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DriverArriveTimeStamp)
                    .HasColumnName("Driver_Arrive_TimeStamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.DriverName)
                    .HasColumnName("Driver_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DriverPhoneNumber)
                    .HasColumnName("Driver_Phone_Number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OrderAllocateTimeStamp)
                    .HasColumnName("Order_Allocate_TimeStamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderAssignConfirmTimeStamp)
                    .HasColumnName("Order_Assign_Confirm_TimeStamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderAssignTimeStamp)
                    .HasColumnName("Order_Assign_TimeStamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderDeliveryTimeStamp)
                    .HasColumnName("Order_Delivery_Time_Stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderOutTimeStamp)
                    .HasColumnName("Order_Out_Time_Stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.VlmOrderStatusCode)
                    .HasColumnName("VLM_Order_Status_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VlmPartnerId)
                    .HasColumnName("VLM_Partner_ID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VlmPartnerOrderAllocateMessage)
                    .HasColumnName("VLM_Partner_Order_Allocate_Message")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VlmPartnerOrderAssignMessage)
                    .HasColumnName("VLM_Partner_Order_Assign_Message")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VlmPartnerOrderDeliveredMessage)
                    .HasColumnName("VLM_Partner_Order_Delivered_Message")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VlmPartnerOrderDriverArriveMessage)
                    .HasColumnName("VLM_Partner_Order_Driver_Arrive_Message")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VlmPartnerOrderNumber)
                    .HasColumnName("VLM_Partner_Order_Number")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VlmPartnerOrderOutMessage)
                    .HasColumnName("VLM_Partner_Order_Out_Message")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VlmPartnerOrderStatusCode)
                    .HasColumnName("VLM_Partner_Order_Status_Code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.VlmOrderStatusCodeNavigation)
                    .WithMany(p => p.VlmPartnerOrders)
                    .HasForeignKey(d => d.VlmOrderStatusCode)
                    .HasConstraintName("FK_VLM_Partner_Orders_VLM_Order_Status");

                entity.HasOne(d => d.VlmPartner)
                    .WithMany(p => p.VlmPartnerOrders)
                    .HasForeignKey(d => new { d.LocationCode, d.VlmPartnerId })
                    .HasConstraintName("FK_VLM_Partner_Orders_VLM_Partner");

                entity.HasOne(d => d.Orders)
                    .WithMany(p => p.VlmPartnerOrders)
                    .HasForeignKey(d => new { d.LocationCode, d.OrderDate, d.OrderNumber })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VLM_Partner_Orders_Orders");
            });

            modelBuilder.Entity<VlmPartnerUnAssignReason>(entity =>
            {
                entity.ToTable("VLM_Partner_UnAssign_Reason");

                entity.Property(e => e.VlmPartnerUnAssignReasonId)
                    .HasColumnName("VLM_PARTNER_UnAssign_REASON_ID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VlmPartnerUnAssignReasonDesc)
                    .IsRequired()
                    .HasColumnName("VLM_PARTNER_UnAssign_REASON_Desc")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VsMetrix>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.MetricId });

                entity.ToTable("VS_Metrix");

                entity.HasIndex(e => new { e.LocationCode, e.Metric })
                    .HasName("IX_VS_Metrix")
                    .IsUnique();

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MetricId).HasColumnName("Metric_ID");

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Metric)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Units)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VsMetrixScenarios>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.Scenario, e.Metric, e.RecordId });

                entity.ToTable("VS_Metrix_Scenarios");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Scenario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Metric)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecordId).HasColumnName("Record_ID");

                entity.Property(e => e.Value1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value5)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VsMetrixTemplate>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.TemplateName, e.Quadrant, e.Page });

                entity.ToTable("VS_Metrix_Template");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WindowName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VsMetrixWindowControls>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.WindowName, e.ControlName });

                entity.ToTable("VS_Metrix_Window_Controls");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.WindowName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ControlName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ControlMetric)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControlType)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ControlValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FontName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FontSize).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.FormatString)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VsMetrixWindows>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.WindowName });

                entity.ToTable("VS_Metrix_Windows");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.WindowName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<VsThresholdAlerts>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.AlertNumber });

                entity.ToTable("VS_ThresholdAlerts");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AlertName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VsThresholdConditions>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.ThresholdId, e.ConditionId });

                entity.ToTable("VS_ThresholdConditions");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ThresholdId).HasColumnName("Threshold_ID");

                entity.Property(e => e.ConditionId).HasColumnName("Condition_ID");

                entity.Property(e => e.CompareValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VsThresholdConjunctions>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.ConjunctionId });

                entity.ToTable("VS_ThresholdConjunctions");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ConjunctionId).HasColumnName("Conjunction_ID");

                entity.Property(e => e.Conjunction)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VsThresholdOperators>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.OperatorId });

                entity.ToTable("VS_ThresholdOperators");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorId).HasColumnName("Operator_ID");

                entity.Property(e => e.OperatorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorValue)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VsThresholds>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.ThresholdId });

                entity.ToTable("VS_Thresholds");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ThresholdId).HasColumnName("Threshold_ID");

                entity.Property(e => e.Window)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WastageDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wastageDetail");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasMaxLength(50);

                entity.Property(e => e.InventoryDate)
                    .HasColumnName("Inventory_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Inventoryitem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("location_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("numeric(10, 3)");

                entity.Property(e => e.TransId).ValueGeneratedOnAdd();

                entity.Property(e => e.WastageReson).HasColumnName("Wastage_Reson");
            });

            modelBuilder.Entity<WastageMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Wastage_Master");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LocationCodes)
                    .HasColumnName("Location_Codes")
                    .HasMaxLength(50);

                entity.Property(e => e.WastageName)
                    .HasColumnName("Wastage_Name")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<WorkStationInformation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WorkStation_Information");

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OutTime).HasColumnType("datetime");

                entity.Property(e => e.TakerId).HasColumnName("Taker_Id");

                entity.Property(e => e.WorkstationId).HasColumnName("Workstation_Id");
            });

            modelBuilder.Entity<WorkStationRights>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WorkStation_Rights");

                entity.Property(e => e.WorkStationId).HasColumnName("WorkStation_Id");

                entity.Property(e => e.WorkStationName)
                    .HasColumnName("WorkStation_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorkstationDevices>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.WorkstationId, e.DeviceId })
                    .IsClustered(false);

                entity.ToTable("Workstation_Devices");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.WorkstationId).HasColumnName("Workstation_ID");

                entity.Property(e => e.DeviceId).HasColumnName("Device_ID");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorkstationKdOrderSort>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.WorkstationId, e.OrderTypeCode });

                entity.ToTable("Workstation_KD_Order_Sort");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.WorkstationId).HasColumnName("Workstation_ID");

                entity.Property(e => e.OrderTypeCode)
                    .HasColumnName("Order_Type_Code")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");
            });

            modelBuilder.Entity<WorkstationMenuTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.WorkstationId, e.MenuTypeId });

                entity.ToTable("Workstation_Menu_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.WorkstationId).HasColumnName("Workstation_ID");

                entity.Property(e => e.MenuTypeId).HasColumnName("Menu_Type_ID");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");
            });

            modelBuilder.Entity<WorkstationOrderTypeDisplay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Workstation_Order_Type_Display");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTypeCode)
                    .IsRequired()
                    .HasColumnName("Order_Type_Code")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.WorkstationId).HasColumnName("Workstation_ID");
            });

            modelBuilder.Entity<WorkstationOrderTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.WorkstationId, e.OrderTypeCode });

                entity.ToTable("Workstation_Order_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.WorkstationId).HasColumnName("Workstation_ID");

                entity.Property(e => e.OrderTypeCode)
                    .HasColumnName("Order_Type_Code")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");
            });

            modelBuilder.Entity<WorkstationPort>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Portno).HasColumnName("portno");

                entity.Property(e => e.WorkstationName)
                    .HasColumnName("workstation_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WorkstationRemoteSettings>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.WorkstationId, e.IpAddress });

                entity.ToTable("Workstation_Remote_Settings");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.WorkstationId).HasColumnName("Workstation_ID");

                entity.Property(e => e.IpAddress)
                    .HasColumnName("IP_Address")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RemoteEmployeeCode)
                    .HasColumnName("Remote_Employee_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityKey)
                    .HasColumnName("Security_Key")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorkstationTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.WorkstationTypeCode });

                entity.ToTable("Workstation_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode).HasColumnName("Language_Code");

                entity.Property(e => e.WorkstationTypeCode).HasColumnName("Workstation_Type_Code");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Workstations>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.WorkstationId });

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.WorkstationId).HasColumnName("Workstation_ID");

                entity.Property(e => e.AcceptCreditCards).HasColumnName("Accept_Credit_Cards");

                entity.Property(e => e.AcceptGiftCards).HasColumnName("Accept_Gift_Cards");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasColumnName("Added_By")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AttachedFpScanner).HasColumnName("Attached_FP_Scanner");

                entity.Property(e => e.CanRunEod)
                    .IsRequired()
                    .HasColumnName("CanRunEOD")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CopyRegistrySettings).HasColumnName("Copy_Registry_Settings");

                entity.Property(e => e.DefaultMenuType).HasColumnName("Default_Menu_Type");

                entity.Property(e => e.Eodreboot)
                    .IsRequired()
                    .HasColumnName("EODReboot")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.KdDisplayOrientation).HasColumnName("KD_DisplayOrientation");

                entity.Property(e => e.KdRefreshRate).HasColumnName("KD_RefreshRate");

                entity.Property(e => e.KdShowAddress).HasColumnName("KD_ShowAddress");

                entity.Property(e => e.KdShowCodes).HasColumnName("KD_ShowCodes");

                entity.Property(e => e.KdShowSummary).HasColumnName("KD_ShowSummary");

                entity.Property(e => e.KdUseBumpBar).HasColumnName("KD_UseBumpBar");

                entity.Property(e => e.PosOrderTypePreference)
                    .HasColumnName("POS_Order_Type_Preference")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RequirePhonePickUp)
                    .IsRequired()
                    .HasColumnName("Require_Phone_Pick_Up")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowOrderStatusModifyScreen).HasColumnName("Show_Order_Status_Modify_Screen");

                entity.Property(e => e.ShowOrderTakersOrdersOnly).HasColumnName("Show_Order_Takers_Orders_Only");

                entity.Property(e => e.StartUpScreenCode).HasColumnName("Start_Up_Screen_Code");

                entity.Property(e => e.WorkstationDescription)
                    .IsRequired()
                    .HasColumnName("Workstation_Description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorkstationName)
                    .IsRequired()
                    .HasColumnName("Workstation_Name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WorkstationTypeCode).HasColumnName("Workstation_Type_Code");
            });

            modelBuilder.Entity<YesNoTypes>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.LanguageCode, e.YesNoCode });

                entity.ToTable("Yes_No_Types");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.YesNoCode).HasColumnName("Yes_No_Code");

                entity.Property(e => e.Description)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishTextDescription)
                    .HasColumnName("English_Text_Description")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
