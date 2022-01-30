using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class Training
    {
        public long Id { get; set; }
        public DateTime SystemDate { get; set; }
        public string SystemStaff { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateStaff { get; set; }
        public string Code { get; set; }
        public DateTime? TrainingDate { get; set; }
        public string TrainingLocation { get; set; }
        public string Lecturer { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string TrainingResults { get; set; }
        public string TrainingScore { get; set; }
        public DateTime? TrainingDatePassed { get; set; }
        public string DatePassedTest { get; set; }
        public string TnGroupCode { get; set; }
        public string TnRecAirCode { get; set; }
        public string Remark { get; set; }
        public string PsCode { get; set; }
        public string TrainingRegisterCode { get; set; }
        public string Status { get; set; }
    }
}
