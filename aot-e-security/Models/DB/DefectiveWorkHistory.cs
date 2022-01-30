using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class DefectiveWorkHistory
    {
        public long Id { get; set; }
        public DateTime SystemDate { get; set; }
        public string SystemStaff { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateStaff { get; set; }
        public string Code { get; set; }
        public string PsCode { get; set; }
        public DateTime? DateOfOperation { get; set; }
        public string DetailsDefectiveWork { get; set; }
        public string WorkPlace { get; set; }
        public string Resolution { get; set; }
        public string AnOperation { get; set; }
        public string ResultsOfOperations { get; set; }
        public DateTime? EndDate { get; set; }
        public string DwhGroupCode { get; set; }
        public string DwhRecAirCode { get; set; }
        public string Remark { get; set; }
        public int? TrainingStaff { get; set; }
        public int? TrainingStatus { get; set; }
        public string PathFile { get; set; }
        public string DefectiveWorkCode { get; set; }
        public string ScreeningPassengerCode { get; set; }
        public string TrainingCurriculumCode { get; set; }
        public string Status { get; set; }
    }
}
