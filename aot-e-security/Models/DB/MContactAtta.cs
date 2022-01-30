using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class MContactAtta
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
        public string TitleCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardTypeCode { get; set; }
        public string CardNumber { get; set; }
        public DateTime? ExpireDate { get; set; }
        public DateTime? BirthDate { get; set; }
        public string NationalityCode { get; set; }
        public string RaceCode { get; set; }
        public string GenderCode { get; set; }
        public string ReligionCode { get; set; }
        public string MaritalStatusCode { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Remark { get; set; }
        public string Status { get; set; }
    }
}
