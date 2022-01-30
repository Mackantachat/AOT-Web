using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class GuardAircraft
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
        public string GuardAircraftNumber { get; set; }
        public string Flight { get; set; }
        public string RegistrationMark { get; set; }
        public DateTime? StartDate { get; set; }
        public string StartSupervisor { get; set; }
        public DateTime? EndDate { get; set; }
        public string EndSupervisor { get; set; }
        public int? GuardDay { get; set; }
        public int? GuardHour { get; set; }
        public int? GuardMinute { get; set; }
        public int? StaffAmount { get; set; }
        public string GuardSupervisor { get; set; }
        public string BuildingType { get; set; }
        public int? GuardAmount { get; set; }
        public string Agent { get; set; }
    }
}
