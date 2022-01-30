using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class PersonViolation
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
        public string ViolationCode { get; set; }
        public string PersonCode { get; set; }
        public DateTime? ViolationDate { get; set; }
        public string ViolationGuilt { get; set; }
        public string Description { get; set; }
        public DateTime? ArrestDate { get; set; }
        public string ViolationPlaceCode { get; set; }
        public string ResolveMethodCode { get; set; }
        public string ActuationCode { get; set; }
        public string ActuationResult { get; set; }
        public string PassStatus { get; set; }
        public DateTime? EndViolationDate { get; set; }
        public string StaffGroupCode { get; set; }
        public string PvAirCode { get; set; }
        public string Remark { get; set; }
        public string FilePath { get; set; }
        public string Status { get; set; }
    }
}
