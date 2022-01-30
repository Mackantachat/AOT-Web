using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class MContactGovernment
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
        public string Tel { get; set; }
        public string Building { get; set; }
        public string Contact1TitleCode { get; set; }
        public string Contact1Name { get; set; }
        public string Contact1Surname { get; set; }
        public string Contact1Position { get; set; }
        public string Contact1OfficeTel { get; set; }
        public string Contact1HomeTel { get; set; }
        public string Contact1Address { get; set; }
        public string Contact2TitleCode { get; set; }
        public string Contact2Name { get; set; }
        public string Contact2Surname { get; set; }
        public string Contact2Position { get; set; }
        public string Contact2OfficeTel { get; set; }
        public string Contact2HomeTel { get; set; }
        public string Contact2Address { get; set; }
        public string Contact3TitleCode { get; set; }
        public string Contact3Name { get; set; }
        public string Contact3Surname { get; set; }
        public string Contact3Position { get; set; }
        public string Contact3OfficeTel { get; set; }
        public string Contact3HomeTel { get; set; }
        public string Contact3Address { get; set; }
        public string Fax { get; set; }
        public string FlagLocation { get; set; }
        public string Remark { get; set; }
        public string Status { get; set; }
    }
}
