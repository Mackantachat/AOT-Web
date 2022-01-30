using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class OperationDaily
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
        public DateTime? ReceiveDate { get; set; }
        public string TitleCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? TurnNumber { get; set; }
        public string SenderTitleCode { get; set; }
        public string SenderName { get; set; }
        public string SenderSurname { get; set; }
        public int? SenderTurnNumber { get; set; }
        public int? WorkHour { get; set; }
        public string Tool { get; set; }
        public string Description { get; set; }
        public DateTime? SendDate { get; set; }
        public string ReceipentTitleCode { get; set; }
        public string ReceipentName { get; set; }
        public string ReceipentSurname { get; set; }
        public int? ReceipentTurnNumber { get; set; }
        public string LinkUrno { get; set; }
    }
}
