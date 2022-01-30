using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class PersonRtp
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
        public string RtpCode { get; set; }
        public string PersonCode { get; set; }
        public string DocumentNumber { get; set; }
        public string RtpNumber { get; set; }
        public DateTime? DocumentDate { get; set; }
        public DateTime? RtpDate { get; set; }
        public DateTime? DocumentReceiveDate { get; set; }
        public DateTime? RtpReceiveDate { get; set; }
        public string CheckingStatus { get; set; }
        public string FilePath { get; set; }
        public string RtpDurationCode { get; set; }
        public DateTime? RtpExpireDate { get; set; }
        public string RtpResult { get; set; }
        public string RtpAirCode { get; set; }
        public string RtpStaffGroupCode { get; set; }
        public string Status { get; set; }
    }
}
