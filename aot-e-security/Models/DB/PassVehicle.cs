using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class PassVehicle
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
        public string PresentCompanyCode { get; set; }
        public string VehicleNumber { get; set; }
        public string VehicleTypeCode { get; set; }
        public string VehicleBrandCode { get; set; }
        public string VehicleColorCode { get; set; }
        public string VehicleLicense { get; set; }
        public string PassNumber { get; set; }
        public string PassVehicleReasonCode { get; set; }
        public string FeeType { get; set; }
        public decimal? Weight { get; set; }
        public decimal? WeightDlt { get; set; }
        public decimal? FeeAmount { get; set; }
        public decimal? FineAmount { get; set; }
        public string ExpireDate { get; set; }
        public string InvoiceDate { get; set; }
        public string Remark { get; set; }
        public string WheelNumber { get; set; }
        public decimal? FeeWeight { get; set; }
        public string LetterNumber { get; set; }
        public string ReviewDate { get; set; }
        public string ApproveDate { get; set; }
        public string ApproveStaff { get; set; }
        public string VehicleFunctionCode { get; set; }
        public string OrderNumber { get; set; }
        public string Status { get; set; }
    }
}
