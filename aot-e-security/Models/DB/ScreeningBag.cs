using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class ScreeningBag
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
        public string TitleCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string NationalityCode { get; set; }
        public string RaceCode { get; set; }
        public string CardTypeCode { get; set; }
        public string CardNumber { get; set; }
        public string PassengerType { get; set; }
        public string DepartureFrom { get; set; }
        public string DepartureAirline { get; set; }
        public string DepartureFlight { get; set; }
        public string DestinationTo { get; set; }
        public string DestinationAirline { get; set; }
        public string DestinationFlight { get; set; }
        public string ShiftNumber { get; set; }
        public string PropertyType { get; set; }
        public string ScreeningPierCode { get; set; }
        public string ScreeningRowCode { get; set; }
        public string ScreeningToolCode { get; set; }
        public DateTime? ScreeningDate { get; set; }
        public string ScreeningStaff { get; set; }
        public string ScreeningPosition { get; set; }
        public string BagCheckStaff { get; set; }
        public string BagCheckPosition { get; set; }
        public string InformAirline { get; set; }
        public string InformAirlineDetail { get; set; }
        public string InformSecurity { get; set; }
        public string InformSecurityDetail { get; set; }
        public string InformOther { get; set; }
        public string InformOtherDetail { get; set; }
        public string Suggestion { get; set; }
        public string ResolveDescription { get; set; }
        public string HeadOfficer { get; set; }
        public int? TurnNumber { get; set; }
        public string Remark { get; set; }
        public string Occupaton { get; set; }
        public string Part { get; set; }
        public string Resolution1 { get; set; }
        public string Resolution2 { get; set; }
        public string Resolution3 { get; set; }
        public string Resolution3Detail { get; set; }
        public string InformOperation { get; set; }
    }
}
