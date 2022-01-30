using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class PersonAttachment
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
        public string FileExtension { get; set; }
        public string DocumentTypeCode { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public string RefNumber { get; set; }
        public string RefLocation { get; set; }
        public string DriverLicenseTypeId { get; set; }
        public string DocumentUrl { get; set; }
        public string PreviewUrl { get; set; }
        public string DocumentNumber { get; set; }
        public string Remark { get; set; }
    }
}
