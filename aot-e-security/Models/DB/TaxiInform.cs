using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class TaxiInform
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
        public DateTime? InformDate { get; set; }
        public string InformTitleCode { get; set; }
        public string InformName { get; set; }
        public string InformSurname { get; set; }
        public string InformAddress { get; set; }
        public string InformTel { get; set; }
        public string TaxiInformTypeCode { get; set; }
        public DateTime? EventDate { get; set; }
        public string DriverPersonCode { get; set; }
        public string DriverTitleCode { get; set; }
        public string DriverName { get; set; }
        public string DriverSurname { get; set; }
        public string VehicleLicense { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Description { get; set; }
        public string Resolution { get; set; }
        public string Remark { get; set; }
        public string VehicleColor { get; set; }
        public string VehicleBrand { get; set; }
    }
}
