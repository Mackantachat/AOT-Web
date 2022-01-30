using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class PersonCertificate
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
        public string PersonCode { get; set; }
        public string CertificateNumber { get; set; }
        public DateTime? CertificateDate { get; set; }
        public DateTime? CerReceiveDate { get; set; }
        public DateTime? CerExpireDate { get; set; }
        public string CerDescription { get; set; }
        public string StaffGroupCode { get; set; }
        public string CerAirCode { get; set; }
        public string FilePath { get; set; }
        public string Status { get; set; }
    }
}
