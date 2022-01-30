using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class PassVehicleTemp
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
        public string VehicleCode { get; set; }
        public string AgentCompanyCode { get; set; }
        public string AgentSubcompany { get; set; }
        public string AgentName { get; set; }
        public DateTime? StartDurationDate { get; set; }
        public DateTime? EndDatationDate { get; set; }
        public int? Frequency { get; set; }
        public string VehicleNumber { get; set; }
        public string VehicleTypeCode { get; set; }
        public string VehicleBrandCode { get; set; }
        public string VehicleColorCode { get; set; }
        public string VehicleLicense { get; set; }
        public string PassNumber { get; set; }
        public string PassIssueLocationCode { get; set; }
        public string PassDurationCode { get; set; }
        public string FeeType { get; set; }
        public decimal? Weight { get; set; }
        public decimal? WeightDlt { get; set; }
        public decimal? FeeAmount { get; set; }
        public string Remark { get; set; }
        public decimal? FeeWeight { get; set; }
        public string VehicleFunctionCode { get; set; }
        public string Status { get; set; }
    }
}
