using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class InvoiceNumber
    {
        public string LocationCode { get; set; }
        public string InvoiceNumber1 { get; set; }
        public int OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? GrossAmount { get; set; }
        public decimal? Tax { get; set; }
        public decimal? TotalAmount { get; set; }
        public string RoiCustomer { get; set; }
        public string Instruction { get; set; }
        public string Types { get; set; }
        public string DeviceType { get; set; }
        public string Platform { get; set; }
        public string Browser { get; set; }
        public string PaymentGateway { get; set; }
        public string CustomField1 { get; set; }
        public string CustomField2 { get; set; }
        public string CustomField3 { get; set; }
        public string CustomField4 { get; set; }
        public string CustomField5 { get; set; }
        public string CustomField6 { get; set; }
        public string CustomField7 { get; set; }
        public string CustomField8 { get; set; }
        public string CustomField9 { get; set; }
        public string CustomField10 { get; set; }
    }
}
