 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aot_e_security.Models.DB;

namespace aot_e_security.Models.api
{
    public class PersonModel
    {
        public long id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string middle_name { get; set; }
        public string gender_code { get; set; }
        public string code { get; set; }
        public string address { get; set; }
        public string country_code { get; set; }
        public string nationality_number { get; set; }
        public string passport_number { get; set; }
        public string card_type_code { get; set; }
        public string card_number { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public string marital_status_code { get; set; }
        public string nationality_code { get; set; }
        public string race_code { get; set; }
        public string hair_color_code { get; set; }
        public string eye_color_code { get; set; }
        public string present_company_code { get; set; }
        public string old_company_code { get; set; }
        public string sub_division_code { get; set; }
        public string scar { get; set; }
        public string function_code { get; set; }
        public string father_name { get; set; }
        public string mother_name { get; set; }
        public string remark { get; set; }
        public string system_staff { get; set; }
        public string status { get; set; }
        public string update_staff { get; set; }
        public string etl_system { get; set; }
        public string etl_table { get; set; }
        public string etl_field { get; set; }
        public string etl_value { get; set; }
        public string title_code { get; set; }
        public DateTime update_date { get; set; }
        public DateTime retire_date { get; set; }
        public DateTime create_card_date { get; set; }
        public DateTime expire_card_date { get; set; }
        public DateTime birth_date { get; set; }
        public DateTime sys_time { get; set; }
        public DateTime system_date { get; set; }
        public string violation_code { get; set; }
        public string path_pic { get; set; }
        public string nick_name { get; set; }
        public string defective_work_code { get; set; }
        public string rtp_code { get; set; }
        public string training_code { get; set; }
        public string certificate_code { get; set; }
        public string passpers_code { get; set; }
        public string change_code { get; set; }
        public string flag_violation { get; set; }
        public string flag_aot { get; set; }
        public int flag_blacklist { get; set; }
        public int flag_foreign { get; set; }
        public string salary_code { get; set; }
        public string p_air_code { get; set; }


        //private eSecurityContext db = new eSecurityContext();
        //public void PersonQuery()
        //{
        //    var pQuery = db.Person.ToList();
        //    var pQ2 = (from p in db.Person select new { p }).ToList();
        //}
    }

    public class PersonFunction 
    {
        private eSecurityContext db = new eSecurityContext();

        public IQueryable<Person> PersonQuery(PersonModel pForm)
        {
            IQueryable<Person> personQuery = db.Person;
            if (pForm.id > 0)
            {
                personQuery = personQuery.Where(p => p.Id == pForm.id);
            }
            if (!String.IsNullOrEmpty(pForm.name))
            {
                personQuery = personQuery.Where(p => p.Name.Contains(pForm.name));
            }
            return personQuery;
        }

        public bool Update(PersonModel modal) 
        {
            try 
            {
                db.Database.BeginTransaction();
                var pQuery = db.Person.FirstOrDefault(p => p.Id == modal.id);
                pQuery.SystemDate = DateTime.Now;
                pQuery.SystemStaff = modal.system_staff;
                pQuery.UpdateDate = DateTime.Now;
                pQuery.UpdateStaff = modal.update_staff;
                pQuery.PathPic = modal.path_pic;
                pQuery.Code = modal.code;

                pQuery.NationalityNumber = modal.nationality_number;
                pQuery.PassportNumber = modal.passport_number;

                pQuery.FlagViolation = modal.flag_violation;
                pQuery.TitleCode = modal.title_code;
                pQuery.Name = modal.name;
                pQuery.MiddleName = modal.middle_name;
                pQuery.Surname = modal.surname;
                pQuery.NickName = modal.nick_name;
                pQuery.GenderCode = modal.gender_code;
                pQuery.BirthDate = modal.birth_date;
                pQuery.NationalityCode = modal.nationality_code;
                pQuery.RaceCode = modal.race_code;
                pQuery.Tel = modal.tel;
                pQuery.MaritalStatusCode = modal.marital_status_code;
                pQuery.Scar = modal.scar;
                pQuery.CardTypeCode = modal.card_type_code;
                pQuery.CardNumber = modal.card_number;
                pQuery.HairColorCode = modal.hair_color_code;
                pQuery.EyeColorCode = modal.eye_color_code;
                pQuery.FatherName = modal.father_name;
                pQuery.MotherName = modal.mother_name;
                pQuery.Email = modal.email;
                pQuery.Address = modal.address;

                pQuery.FlagBlacklist = modal.flag_blacklist;
                pQuery.PAirCode = modal.p_air_code;
                pQuery.OldCompanyCode = modal.old_company_code;
                pQuery.PresentCompanyCode = modal.present_company_code;
                pQuery.SubDivisionCode = modal.sub_division_code;
                pQuery.FunctionCode = modal.function_code;
                pQuery.RetireDate = modal.retire_date;
                pQuery.Status = modal.status;
                pQuery.Remark = modal.remark;
                pQuery.CertificateCode = modal.certificate_code;
                pQuery.ChangeCode = modal.change_code;
                pQuery.DefectiveWorkCode = modal.defective_work_code;
                pQuery.PasspersCode = modal.passpers_code;
                pQuery.ViolationCode = modal.violation_code;
                pQuery.RtpCode = modal.rtp_code;
                pQuery.TrainingCode = modal.training_code;

                db.SaveChanges();
                db.Database.CurrentTransaction.Commit();
                return true;
            }
            catch (Exception err)
            {
                db.Database.CurrentTransaction.Rollback();
                Console.WriteLine(err);
                return false;
            }
        }

        public bool Insert(PersonModel modal) 
        {
            try
            {
                db.Database.BeginTransaction();
                Person person = new Person();
                //var person = db.Person.FirstOrDefault(p => p.Id == modal.id);
                person.SystemDate = DateTime.Now;
                person.SystemStaff = modal.system_staff;
                person.UpdateDate = DateTime.Now;
                person.UpdateStaff = modal.update_staff;
                person.PathPic = modal.path_pic;
                person.Code = modal.code;

                person.NationalityNumber = modal.nationality_number;
                person.PassportNumber = modal.passport_number;

                person.FlagViolation = modal.flag_violation;
                person.TitleCode = modal.title_code;
                person.Name = modal.name;
                person.MiddleName = modal.middle_name;
                person.Surname = modal.surname;
                person.NickName = modal.nick_name;
                person.GenderCode = modal.gender_code;
                person.BirthDate = modal.birth_date;
                person.NationalityCode = modal.nationality_code;
                person.RaceCode = modal.race_code;
                person.Tel = modal.tel;
                person.MaritalStatusCode = modal.marital_status_code;
                person.Scar = modal.scar;
                person.CardTypeCode = modal.card_type_code;
                person.CardNumber = modal.card_number;
                person.HairColorCode = modal.hair_color_code;
                person.EyeColorCode = modal.eye_color_code;
                person.FatherName = modal.father_name;
                person.MotherName = modal.mother_name;
                person.Email = modal.email;
                person.Address = modal.address;

                person.FlagBlacklist = modal.flag_blacklist;
                person.PAirCode = modal.p_air_code;
                person.OldCompanyCode = modal.old_company_code;
                person.PresentCompanyCode = modal.present_company_code;
                person.SubDivisionCode = modal.sub_division_code;
                person.FunctionCode = modal.function_code;
                person.RetireDate = modal.retire_date;
                person.Status = modal.status;
                person.Remark = modal.remark;
                person.CertificateCode = modal.certificate_code;
                person.ChangeCode = modal.change_code;
                person.DefectiveWorkCode = modal.defective_work_code;
                person.PasspersCode = modal.passpers_code;
                person.ViolationCode = modal.violation_code;
                person.RtpCode = modal.rtp_code;
                person.TrainingCode = modal.training_code;

                db.Person.Add(person);
                db.SaveChanges();
                db.Database.CurrentTransaction.Commit();
                return true;
            }
            catch (Exception err)
            {
                db.Database.CurrentTransaction.Rollback();
                Console.WriteLine(err);
                return false;
            }
        }
    }

}
