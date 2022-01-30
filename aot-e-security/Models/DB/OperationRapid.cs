using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class OperationRapid
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
        public long OperationId { get; set; }
        public string InformTo { get; set; }
        public DateTime? InformDate { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public string Cause { get; set; }
        public string Damage { get; set; }
        public string Resolution { get; set; }
        public string NextOperation { get; set; }
        public string RelatedPerson { get; set; }
        public string ReporterName { get; set; }
        public string ReporterPosition { get; set; }
        public string LinkUrno { get; set; }
    }
}
