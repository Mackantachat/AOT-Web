using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class DepositWeapon
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
        public string Airline { get; set; }
        public string CheckinCounterCode { get; set; }
        public DateTime? ScreeningDate { get; set; }
        public string FlightNumber { get; set; }
        public string DocumentNumber { get; set; }
        public string ReceiveStaff { get; set; }
        public string ReceiveCompany { get; set; }
        public string SenderStaff { get; set; }
        public string SenderCompany { get; set; }
        public string Remark { get; set; }
        public string OccupationCode { get; set; }
        public string ZoneCode { get; set; }
        public string TitleCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Destination { get; set; }
        public string BuildingType { get; set; }
        public string Seat { get; set; }
        public string ProvinceCode { get; set; }
    }
}
