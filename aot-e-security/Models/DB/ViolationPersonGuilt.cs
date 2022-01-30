using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class ViolationPersonGuilt
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
        public long? ViolationPersonId { get; set; }
        public string ViolationGuiltCode { get; set; }
        public string Description { get; set; }
        public string LinkUrno { get; set; }
    }
}
