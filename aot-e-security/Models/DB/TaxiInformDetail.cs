using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class TaxiInformDetail
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
        public long TaxiInformId { get; set; }
        public DateTime? InformDate { get; set; }
        public string InformTitleCode { get; set; }
        public string InformName { get; set; }
        public string InformSurname { get; set; }
        public string Resolution { get; set; }
        public string LinkUrno { get; set; }
    }
}
