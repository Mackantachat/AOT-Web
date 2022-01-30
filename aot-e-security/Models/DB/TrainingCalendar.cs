using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class TrainingCalendar
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
        public string TrainingCurriculumCode { get; set; }
        public string Code { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? TotalSeat { get; set; }
        public int? BookSeat { get; set; }
        public int? MaxScore { get; set; }
        public int? PassScore { get; set; }
        public string Remark { get; set; }
        public string TrainingDayoffCode { get; set; }
        public DateTime? OpenDay { get; set; }
        public DateTime? OffDay { get; set; }
        public string TrainingTrainerCode { get; set; }
        public string Status { get; set; }
    }
}
