using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class ViolationPersonOffender
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
        public long? ViolationPersonId { get; set; }
        public string PersonCode { get; set; }
        public string TitleCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nickname { get; set; }
        public string ReferenceCode { get; set; }
        public string PassPersonNumber { get; set; }
        public string CardTypeCode { get; set; }
        public string CardNumber { get; set; }
        public DateTime? CardExpireDate { get; set; }
        public string CompanyCode { get; set; }
        public string FunctionCode { get; set; }
        public string Address { get; set; }
        public string LinkUrno { get; set; }
        public DateTime? BirthDate { get; set; }
        public string NationalityCode { get; set; }
        public string RaceCode { get; set; }
        public string ReligionCode { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Height { get; set; }
        public string Shape { get; set; }
        public string Skin { get; set; }
        public string Head { get; set; }
        public string HairColor { get; set; }
        public string Eyebrow { get; set; }
        public string EyeColor { get; set; }
        public string Ear { get; set; }
        public string Nose { get; set; }
        public string Mouth { get; set; }
        public string Mustache { get; set; }
        public string Arm { get; set; }
        public string Leg { get; set; }
        public string Scar { get; set; }
        public string Walking { get; set; }
        public string Habit { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Occupation { get; set; }
        public string OccupationHistory1 { get; set; }
        public string OccupationHistory2 { get; set; }
        public string Talent { get; set; }
        public string MaritalStatusCode { get; set; }
        public string SpouseName { get; set; }
        public string FatherOccupation { get; set; }
        public string MotherOccupation { get; set; }
        public int? Frequency { get; set; }
    }
}
