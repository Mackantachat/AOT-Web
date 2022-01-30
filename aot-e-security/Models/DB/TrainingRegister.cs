using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class TrainingRegister
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
        public string TrainingCalendarCode { get; set; }
        public string Code { get; set; }
        public string PersonCode { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public int? MaxScore { get; set; }
        public DateTime? EvaluateDate { get; set; }
        public int? EvaluateScore { get; set; }
        public string EvaluateStatus { get; set; }
        public string TrainingStatus { get; set; }
        public string TrainingChannelCode { get; set; }
        public int? PassScore { get; set; }
        public DateTime? RegisDate { get; set; }
        public string TrainingPunishmentCode { get; set; }
        public DateTime? TrainingExpirDate { get; set; }
        public string Email { get; set; }
        public string TrainingCode { get; set; }
        public string Remark { get; set; }
        public string Status { get; set; }
    }
}
