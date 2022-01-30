using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class PassPersonTemp
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
        public string TiteCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FunctionCode { get; set; }
        public string Subcontract { get; set; }
        public string NationalityNumber { get; set; }
        public string CardTypeCode { get; set; }
        public string CardNumber { get; set; }
        public string PassNumber { get; set; }
        public string PassIssueLocationCode { get; set; }
        public string PassDurationCode { get; set; }
        public DateTime? StartDurationDate { get; set; }
        public DateTime? EndDatationDate { get; set; }
        public int? Frequency { get; set; }
        public string RestrictAreaCode { get; set; }
        public string PassPersonTempTypeCode { get; set; }
        public string PassPersonTempReasonCode { get; set; }
        public decimal? EquipmentAmount { get; set; }
        public decimal? FeeAmount { get; set; }
        public decimal? FineAmount { get; set; }
        public decimal? TotalAmount { get; set; }
        public DateTime? ExpireDate { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public string InvoiceDate { get; set; }
        public string DocumentNumber { get; set; }
        public string Remark { get; set; }
        public string AgentTitleCode { get; set; }
        public string AgentName { get; set; }
        public string AgentSurname { get; set; }
        public string AgentCompanyCode { get; set; }
        public string AgentFunctionality { get; set; }
        public string OldUrno { get; set; }
        public long? OldPassPersonTempId { get; set; }
        public string Status { get; set; }
        public DateTime? CreateCardDate { get; set; }
    }
}
