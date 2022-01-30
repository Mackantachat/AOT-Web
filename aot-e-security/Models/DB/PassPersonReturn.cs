using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class PassPersonReturn
    {
        public long Id { get; set; }
        public DateTime SystemDate { get; set; }
        public string SystemStaff { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateStaff { get; set; }
        public string EtlSystem { get; set; }
        public string EtlTable { get; set; }
        public string EtlField { get; set; }
        public string EtlValue { get; set; }
        public string PassNumber { get; set; }
        public string FlagReturnCard { get; set; }
        public decimal? FineAmount { get; set; }
        public string OrderNumber { get; set; }
    }
}
