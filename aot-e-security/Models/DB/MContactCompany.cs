using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class MContactCompany
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
        public string CompanyType { get; set; }
        public string Code { get; set; }
        public string Tel { get; set; }
        public string Building { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public string ContactTel { get; set; }
        public string Address { get; set; }
        public string HomeTel { get; set; }
        public string Fax { get; set; }
        public string FlagLocation { get; set; }
        public string TitleCode { get; set; }
        public string Remark { get; set; }
        public string Status { get; set; }
    }
}
