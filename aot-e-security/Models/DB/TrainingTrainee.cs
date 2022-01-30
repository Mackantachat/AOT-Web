using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class TrainingTrainee
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
        public string FlagValidNationality { get; set; }
        public string MessageValidNationality { get; set; }
        public string FlagValidDriver { get; set; }
        public string MessageValidDriver { get; set; }
        public string FlagValidMedical { get; set; }
        public string MessageValidMedical { get; set; }
        public string Remark { get; set; }
        public string TraineeStatus { get; set; }
        public string TraineeStatusPerson { get; set; }
        public string Status { get; set; }
    }
}
