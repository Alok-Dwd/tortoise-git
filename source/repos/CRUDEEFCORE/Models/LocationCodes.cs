using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class LocationCodes
    {
        public LocationCodes()
        {
            AccountTypes = new HashSet<AccountTypes>();
            Accounts = new HashSet<Accounts>();
            AddressDefinitionType = new HashSet<AddressDefinitionType>();
            AddressDefinitions = new HashSet<AddressDefinitions>();
            AddressLookup = new HashSet<AddressLookup>();
            AddressTypes = new HashSet<AddressTypes>();
            AodLog = new HashSet<AodLog>();
            AppControlDefaultLocationCodeNavigation = new HashSet<AppControl>();
            AppControlLocationCodeNavigation = new HashSet<AppControl>();
            ApplicationUpdateHistory = new HashSet<ApplicationUpdateHistory>();
            ArAgingMethodTypes = new HashSet<ArAgingMethodTypes>();
            ArAgingMethodTypesDescriptions = new HashSet<ArAgingMethodTypesDescriptions>();
            ArTermTypes = new HashSet<ArTermTypes>();
            ArTermTypesDescriptions = new HashSet<ArTermTypesDescriptions>();
            ArTransactionStatusTypes = new HashSet<ArTransactionStatusTypes>();
            ArTransactionStatusTypesDescriptions = new HashSet<ArTransactionStatusTypesDescriptions>();
            ArTransactionTypes = new HashSet<ArTransactionTypes>();
            ArTransactionTypesDescriptions = new HashSet<ArTransactionTypesDescriptions>();
            ArTransactions = new HashSet<ArTransactions>();
            ArTransactionsDetail = new HashSet<ArTransactionsDetail>();
            AttributeGroupAttributes = new HashSet<AttributeGroupAttributes>();
            AttributeGroups = new HashSet<AttributeGroups>();
            Attributes = new HashSet<Attributes>();
            BumpBarKey = new HashSet<BumpBarKey>();
            CallerId = new HashSet<CallerId>();
            CallerIdConnectionTypes = new HashSet<CallerIdConnectionTypes>();
            CallerIdLog = new HashSet<CallerIdLog>();
            CashDrawerAudit = new HashSet<CashDrawerAudit>();
            City = new HashSet<City>();
            ControlProperties = new HashSet<ControlProperties>();
            ControlledFiles = new HashSet<ControlledFiles>();
            CountType = new HashSet<CountType>();
            CouponTypes = new HashSet<CouponTypes>();
            Coupons = new HashSet<Coupons>();
            CreditCardAccounts = new HashSet<CreditCardAccounts>();
            CreditCardActionCodes = new HashSet<CreditCardActionCodes>();
            CreditCardActionCodesDescriptions = new HashSet<CreditCardActionCodesDescriptions>();
            CreditCardEntryMethods = new HashSet<CreditCardEntryMethods>();
            CreditCardEntryMethodsDescriptions = new HashSet<CreditCardEntryMethodsDescriptions>();
            CreditCardNumberRanges = new HashSet<CreditCardNumberRanges>();
            CreditCardProcessingTypes = new HashSet<CreditCardProcessingTypes>();
            CreditCardTransactionTypes = new HashSet<CreditCardTransactionTypes>();
            CreditCardTransactionTypesDescriptions = new HashSet<CreditCardTransactionTypesDescriptions>();
            CreditCards = new HashSet<CreditCards>();
            CreditCardsDescriptions = new HashSet<CreditCardsDescriptions>();
            CurrencyCommonBills = new HashSet<CurrencyCommonBills>();
            CurrencyExchange = new HashSet<CurrencyExchange>();
            CurrencyType = new HashSet<CurrencyType>();
            Customer = new HashSet<Customer>();
            CustomerDaily = new HashSet<CustomerDaily>();
            CustomerProfileData = new HashSet<CustomerProfileData>();
            CustomerProfileTypes = new HashSet<CustomerProfileTypes>();
            DailyInventory = new HashSet<DailyInventory>();
            DailyInventoryDetail = new HashSet<DailyInventoryDetail>();
            DailyInventoryPrep = new HashSet<DailyInventoryPrep>();
            DailyInventoryPrepDetail = new HashSet<DailyInventoryPrepDetail>();
            DailySummary = new HashSet<DailySummary>();
            DateIntervalTypes = new HashSet<DateIntervalTypes>();
            DayOfWeekValues = new HashSet<DayOfWeekValues>();
            DefaultCurrencyHistory = new HashSet<DefaultCurrencyHistory>();
            Deliveries = new HashSet<Deliveries>();
            DeliveryAmount = new HashSet<DeliveryAmount>();
            DeliveryTypeCodes = new HashSet<DeliveryTypeCodes>();
            Employee = new HashSet<Employee>();
            EmployeeCashDrop = new HashSet<EmployeeCashDrop>();
            MenuItemTypes1 = new HashSet<MenuItemTypes1>();
            OloOts = new HashSet<OloOts>();
            OrderWallet = new HashSet<OrderWallet>();
            OvenDescription = new HashSet<OvenDescription>();
            PriorityCustomerCategory = new HashSet<PriorityCustomerCategory>();
            PriorityCustomers = new HashSet<PriorityCustomers>();
            PriorityCustomersNotification = new HashSet<PriorityCustomersNotification>();
            SrsReconcileDetl = new HashSet<SrsReconcileDetl>();
            SrsReconcileHdr = new HashSet<SrsReconcileHdr>();
        }

        public string LocationCode { get; set; }
        public string Description { get; set; }
        public string PizzaToppingGroup { get; set; }
        public string StorePhone { get; set; }
        public string StoreAddress { get; set; }
        public byte? MaxStations { get; set; }
        public byte? MaxCreditCard { get; set; }
        public DateTime? SystemDate { get; set; }
        public string TaxIdNumber { get; set; }
        public string TaxSlipLine1 { get; set; }
        public string TaxSlipLine2 { get; set; }
        public string TaxSlipLine3 { get; set; }
        public string TaxSlipLine4 { get; set; }
        public string TaxSlipLine5 { get; set; }
        public string TaxSlipLine6 { get; set; }
        public string TaxSlipLine7 { get; set; }
        public string TaxSlipLine8 { get; set; }
        public byte OverrideProcessingDate { get; set; }
        public byte CcSettlementAttempted { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }

        public virtual CallerIdSettings CallerIdSettings { get; set; }
        public virtual CreditCardSettings CreditCardSettings { get; set; }
        public virtual ICollection<AccountTypes> AccountTypes { get; set; }
        public virtual ICollection<Accounts> Accounts { get; set; }
        public virtual ICollection<AddressDefinitionType> AddressDefinitionType { get; set; }
        public virtual ICollection<AddressDefinitions> AddressDefinitions { get; set; }
        public virtual ICollection<AddressLookup> AddressLookup { get; set; }
        public virtual ICollection<AddressTypes> AddressTypes { get; set; }
        public virtual ICollection<AodLog> AodLog { get; set; }
        public virtual ICollection<AppControl> AppControlDefaultLocationCodeNavigation { get; set; }
        public virtual ICollection<AppControl> AppControlLocationCodeNavigation { get; set; }
        public virtual ICollection<ApplicationUpdateHistory> ApplicationUpdateHistory { get; set; }
        public virtual ICollection<ArAgingMethodTypes> ArAgingMethodTypes { get; set; }
        public virtual ICollection<ArAgingMethodTypesDescriptions> ArAgingMethodTypesDescriptions { get; set; }
        public virtual ICollection<ArTermTypes> ArTermTypes { get; set; }
        public virtual ICollection<ArTermTypesDescriptions> ArTermTypesDescriptions { get; set; }
        public virtual ICollection<ArTransactionStatusTypes> ArTransactionStatusTypes { get; set; }
        public virtual ICollection<ArTransactionStatusTypesDescriptions> ArTransactionStatusTypesDescriptions { get; set; }
        public virtual ICollection<ArTransactionTypes> ArTransactionTypes { get; set; }
        public virtual ICollection<ArTransactionTypesDescriptions> ArTransactionTypesDescriptions { get; set; }
        public virtual ICollection<ArTransactions> ArTransactions { get; set; }
        public virtual ICollection<ArTransactionsDetail> ArTransactionsDetail { get; set; }
        public virtual ICollection<AttributeGroupAttributes> AttributeGroupAttributes { get; set; }
        public virtual ICollection<AttributeGroups> AttributeGroups { get; set; }
        public virtual ICollection<Attributes> Attributes { get; set; }
        public virtual ICollection<BumpBarKey> BumpBarKey { get; set; }
        public virtual ICollection<CallerId> CallerId { get; set; }
        public virtual ICollection<CallerIdConnectionTypes> CallerIdConnectionTypes { get; set; }
        public virtual ICollection<CallerIdLog> CallerIdLog { get; set; }
        public virtual ICollection<CashDrawerAudit> CashDrawerAudit { get; set; }
        public virtual ICollection<City> City { get; set; }
        public virtual ICollection<ControlProperties> ControlProperties { get; set; }
        public virtual ICollection<ControlledFiles> ControlledFiles { get; set; }
        public virtual ICollection<CountType> CountType { get; set; }
        public virtual ICollection<CouponTypes> CouponTypes { get; set; }
        public virtual ICollection<Coupons> Coupons { get; set; }
        public virtual ICollection<CreditCardAccounts> CreditCardAccounts { get; set; }
        public virtual ICollection<CreditCardActionCodes> CreditCardActionCodes { get; set; }
        public virtual ICollection<CreditCardActionCodesDescriptions> CreditCardActionCodesDescriptions { get; set; }
        public virtual ICollection<CreditCardEntryMethods> CreditCardEntryMethods { get; set; }
        public virtual ICollection<CreditCardEntryMethodsDescriptions> CreditCardEntryMethodsDescriptions { get; set; }
        public virtual ICollection<CreditCardNumberRanges> CreditCardNumberRanges { get; set; }
        public virtual ICollection<CreditCardProcessingTypes> CreditCardProcessingTypes { get; set; }
        public virtual ICollection<CreditCardTransactionTypes> CreditCardTransactionTypes { get; set; }
        public virtual ICollection<CreditCardTransactionTypesDescriptions> CreditCardTransactionTypesDescriptions { get; set; }
        public virtual ICollection<CreditCards> CreditCards { get; set; }
        public virtual ICollection<CreditCardsDescriptions> CreditCardsDescriptions { get; set; }
        public virtual ICollection<CurrencyCommonBills> CurrencyCommonBills { get; set; }
        public virtual ICollection<CurrencyExchange> CurrencyExchange { get; set; }
        public virtual ICollection<CurrencyType> CurrencyType { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<CustomerDaily> CustomerDaily { get; set; }
        public virtual ICollection<CustomerProfileData> CustomerProfileData { get; set; }
        public virtual ICollection<CustomerProfileTypes> CustomerProfileTypes { get; set; }
        public virtual ICollection<DailyInventory> DailyInventory { get; set; }
        public virtual ICollection<DailyInventoryDetail> DailyInventoryDetail { get; set; }
        public virtual ICollection<DailyInventoryPrep> DailyInventoryPrep { get; set; }
        public virtual ICollection<DailyInventoryPrepDetail> DailyInventoryPrepDetail { get; set; }
        public virtual ICollection<DailySummary> DailySummary { get; set; }
        public virtual ICollection<DateIntervalTypes> DateIntervalTypes { get; set; }
        public virtual ICollection<DayOfWeekValues> DayOfWeekValues { get; set; }
        public virtual ICollection<DefaultCurrencyHistory> DefaultCurrencyHistory { get; set; }
        public virtual ICollection<Deliveries> Deliveries { get; set; }
        public virtual ICollection<DeliveryAmount> DeliveryAmount { get; set; }
        public virtual ICollection<DeliveryTypeCodes> DeliveryTypeCodes { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<EmployeeCashDrop> EmployeeCashDrop { get; set; }
        public virtual ICollection<MenuItemTypes1> MenuItemTypes1 { get; set; }
        public virtual ICollection<OloOts> OloOts { get; set; }
        public virtual ICollection<OrderWallet> OrderWallet { get; set; }
        public virtual ICollection<OvenDescription> OvenDescription { get; set; }
        public virtual ICollection<PriorityCustomerCategory> PriorityCustomerCategory { get; set; }
        public virtual ICollection<PriorityCustomers> PriorityCustomers { get; set; }
        public virtual ICollection<PriorityCustomersNotification> PriorityCustomersNotification { get; set; }
        public virtual ICollection<SrsReconcileDetl> SrsReconcileDetl { get; set; }
        public virtual ICollection<SrsReconcileHdr> SrsReconcileHdr { get; set; }
    }
}
