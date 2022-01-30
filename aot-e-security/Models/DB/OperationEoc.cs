using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class OperationEoc
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
        public DateTime? ReporterDate { get; set; }
        public string ReporterName { get; set; }
        public string ReporterCompany { get; set; }
        public string ReporterTel { get; set; }
        public DateTime? RecepientDate { get; set; }
        public string RecepientName { get; set; }
        public string RecepientCompany { get; set; }
        public string RecepientTel { get; set; }
        public string Resolution { get; set; }
        public string FlightCompany { get; set; }
        public string FlightNickname { get; set; }
        public string FlightModel { get; set; }
        public string FlightFuelHour { get; set; }
        public string FlightFuelMinute { get; set; }
        public string FlightOrigin { get; set; }
        public DateTime? FlightDepartureDate { get; set; }
        public string FlightDestination { get; set; }
        public DateTime? FlightArrivalDate { get; set; }
        public string FlightType { get; set; }
        public int? CrewTotal { get; set; }
        public int? CrewPassengerMale { get; set; }
        public int? CrewPassengerFemale { get; set; }
        public int? CrewVip { get; set; }
        public int? CrewPatient { get; set; }
        public int? CrewChild { get; set; }
        public int? CrewStaffMale { get; set; }
        public int? CrewStaffFemale { get; set; }
        public int? HijackerMale { get; set; }
        public string HijackerMaleNationality { get; set; }
        public string HijackerMaleAge { get; set; }
        public string HijackerFemale { get; set; }
        public string HijackerFemaleNationality { get; set; }
        public string HijackerFemaleAge { get; set; }
        public string WeaponType { get; set; }
        public int? WeaponCarbine { get; set; }
        public int? WeaponMachineGun { get; set; }
        public int? WeaponAirgun { get; set; }
        public int? WeaponRifle { get; set; }
        public int? WeaponShotgun { get; set; }
        public int? WeaponOther { get; set; }
        public int? WeaponBomb { get; set; }
        public string WeaponOt { get; set; }
        public string Behavior1 { get; set; }
        public string Behavior2 { get; set; }
        public string Request { get; set; }
        public string LinkUrno { get; set; }
    }
}
