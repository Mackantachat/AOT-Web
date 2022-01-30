using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class PersonTraining
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
        public string PersonCode { get; set; }
        public DateTime? TrainDate { get; set; }
        public string TrainCode { get; set; }
        public string TrainName { get; set; }
        public string TrainResult { get; set; }
        public DateTime? PassDate { get; set; }
        public string PtRecAirCode { get; set; }
        public string PtStaffRec { get; set; }
        public string PtGroupCode { get; set; }
    }
}
