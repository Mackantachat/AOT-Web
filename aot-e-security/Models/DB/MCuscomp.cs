using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class MCuscomp
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
        public string PartnerCode { get; set; }
        public string CompName1 { get; set; }
        public string CompName2 { get; set; }
        public string CompName3 { get; set; }
        public string CompName4 { get; set; }
        public string BranchNum { get; set; }
        public string Street { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string TaxNum { get; set; }
        public string Status { get; set; }
    }
}
