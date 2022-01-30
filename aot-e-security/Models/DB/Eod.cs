using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class Eod
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
        public string InformPosition { get; set; }
        public string InformCompanyCode { get; set; }
        public string InformAddress { get; set; }
        public string FounderTitleCode { get; set; }
        public string FounderName { get; set; }
        public string FounderSurname { get; set; }
        public string FounderPosition { get; set; }
        public string FounderCompanyCode { get; set; }
        public string FounderAddress { get; set; }
        public string InformantName { get; set; }
        public string OperationStaff1 { get; set; }
        public string OperationStaff2 { get; set; }
        public string EodTypeCode { get; set; }
        public string EodDescription { get; set; }
        public string ViolationPlaceCode { get; set; }
        public string PlaceDescription { get; set; }
        public string Resolution { get; set; }
        public string Result { get; set; }
        public DateTime? SendDate { get; set; }
        public string RecipientTitleCode { get; set; }
        public string RecipientName { get; set; }
        public string RecipientSurname { get; set; }
        public string RecipientPosition { get; set; }
        public string RecipientCompanyCode { get; set; }
        public string RecipientAddress { get; set; }
        public string SendName { get; set; }
    }
}
