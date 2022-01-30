using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class Cardexchange
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
        public string SerialNumber { get; set; }
        public string ApproveCode { get; set; }
        public string PasspersCode { get; set; }
        public string PassNumber { get; set; }
        public string PersonCode { get; set; }
        public string TitleCode { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public string PresentCompanyCode { get; set; }
        public string PresentCompany { get; set; }
        public string OldCompanyCode { get; set; }
        public string Subcontract { get; set; }
        public string FunctionCode { get; set; }
        public string FunctionName { get; set; }
        public string NationalityNumber { get; set; }
        public string CardTypeCode { get; set; }
        public string CardNumber { get; set; }
        public string PassIssueLocationCode { get; set; }
        public string PassDurationCode { get; set; }
        public DateTime? StartDurationDate { get; set; }
        public DateTime? EndDatationDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string Expiry { get; set; }
        public int? Frequency { get; set; }
        public string RestrictAreaCode { get; set; }
        public string RestrictArea { get; set; }
        public string PassPersonTempTypeCode { get; set; }
        public string PAirportCode { get; set; }
        public string PAirport { get; set; }
        public string PAirportEng { get; set; }
        public int? TriggerPrint { get; set; }
    }
}
