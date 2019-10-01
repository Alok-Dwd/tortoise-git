using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class EodDataSyncMailfailover
    {
        public string LocationCode { get; set; }
        public DateTime SystemDate { get; set; }
        public string MailMessage { get; set; }
        public decimal? MailSendFlag { get; set; }
        public DateTime? Added { get; set; }
    }
}
