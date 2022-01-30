using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class OperationEmergency
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
        public string DivisionCode { get; set; }
        public string RecepientName { get; set; }
        public string SenderName { get; set; }
        public string Tel { get; set; }
        public DateTime? InformDate { get; set; }
        public string Remark { get; set; }
        public string LinkUrno { get; set; }
    }
}
