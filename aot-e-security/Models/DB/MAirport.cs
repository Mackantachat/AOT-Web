using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class MAirport
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
        public string Code { get; set; }
        public string ProfitCenter { get; set; }
        public string AbbreEh { get; set; }
        public string NameEn { get; set; }
        public string AbbreTh { get; set; }
        public string NameTh { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string GenaralData { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
