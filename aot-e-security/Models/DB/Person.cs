using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class Person
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
        public string SalaryCode { get; set; }
        public string TitleCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string NickName { get; set; }
        public string GenderCode { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Address { get; set; }
        public string PProvince { get; set; }
        public string CountryCode { get; set; }
        public string NationalityNumber { get; set; }
        public string PassportNumber { get; set; }
        public string CardTypeCode { get; set; }
        public string CardNumber { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string MaritalStatusCode { get; set; }
        public string NationalityCode { get; set; }
        public string RaceCode { get; set; }
        public string HairColorCode { get; set; }
        public string EyeColorCode { get; set; }
        public string Scar { get; set; }
        public string PresentCompanyCode { get; set; }
        public string OldCompanyCode { get; set; }
        public string SubDivisionCode { get; set; }
        public string SubcontractCode { get; set; }
        public string FunctionCode { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Remark { get; set; }
        public string FlagViolation { get; set; }
        public string PersonTypeCode { get; set; }
        public int? FlagNoneCard { get; set; }
        public int? FlagBlacklist { get; set; }
        public DateTime? RetireDate { get; set; }
        public string PathPic { get; set; }
        public string PAirCode { get; set; }
        public string PathPicSign { get; set; }
        public string ViolationCode { get; set; }
        public string DefectiveWorkCode { get; set; }
        public string RtpSendCode { get; set; }
        public string RtpCode { get; set; }
        public string TrainingCode { get; set; }
        public string CertificateCode { get; set; }
        public string PasspersCode { get; set; }
        public string ChangeCode { get; set; }
        public string Status { get; set; }
    }
}
