using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeCashDrop = new HashSet<EmployeeCashDrop>();
            MobInEmployeeLog = new HashSet<MobInEmployeeLog>();
        }

        public string LocationCode { get; set; }
        public string EmployeeCode { get; set; }
        public short StatusCode { get; set; }
        public short AdminLevel { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string GovernmentId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Telephone { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string Email { get; set; }
        public bool? RightHanded { get; set; }
        public string InsuranceCo { get; set; }
        public string InsurancePolicy { get; set; }
        public DateTime? InsExpDate { get; set; }
        public string CarRegistration { get; set; }
        public DateTime? RegExpiration { get; set; }
        public string LicensePlate { get; set; }
        public string DlNumber { get; set; }
        public DateTime? DlExpiration { get; set; }
        public string DlRegion { get; set; }
        public bool? CarInspection { get; set; }
        public DateTime? InspectionDate { get; set; }
        public bool? MvrPass { get; set; }
        public DateTime? MvrCheckDate { get; set; }
        public string EmergencyContact { get; set; }
        public string EmergencyPhone { get; set; }
        public short? PayTypeCode { get; set; }
        public string FoodHandlerLicense { get; set; }
        public DateTime? FoodHandlerExpiration { get; set; }
        public string UserId { get; set; }
        public byte[] Password { get; set; }
        public short? LanguageCode { get; set; }
        public string Track1Data { get; set; }
        public string Track2Data { get; set; }
        public string Track3Data { get; set; }
        public bool AllowKeyboardAuth { get; set; }
        public bool AllowMsrAuth { get; set; }
        public bool AllowBiometricAuth { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Added { get; set; }
        public DateTime? PasswordExpiryDate { get; set; }
        public string EmpType { get; set; }
        public DateTime? LastUpdated { get; set; }
        public short? ResetPassword { get; set; }
        public byte[] OldPassword { get; set; }
        public DateTime? SyncTime { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
        public virtual ICollection<EmployeeCashDrop> EmployeeCashDrop { get; set; }
        public virtual ICollection<MobInEmployeeLog> MobInEmployeeLog { get; set; }
    }
}
