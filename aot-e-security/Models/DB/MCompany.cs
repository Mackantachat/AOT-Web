using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class MCompany
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
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string ArNumber { get; set; }
        public string AddressCode { get; set; }
        public string Status { get; set; }
        public string FlagGroup { get; set; }
        public string GroupCode { get; set; }
        public string PaymentPass { get; set; }
        public string PaymentFine { get; set; }
        public string PaymentPerson { get; set; }
        public string PaymentPersonFine { get; set; }
        public string PaymentPersonTemp { get; set; }
        public string PaymentPersonTempFine { get; set; }
        public string PaymentVehicleTemp { get; set; }
        public string PaymentVehicleTempFine { get; set; }
    }
}
