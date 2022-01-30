using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aot_e_security.Models.DB;

namespace aot_e_security.Models.api
{
    public class ViolationVihicleModel
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
        public string PersonCode { get; set; }
        public string VehicleCode { get; set; }
        public string Status { get; set; }
    }
    public class ViolationVihicleFunction
    {
        private eSecurityContext db = new eSecurityContext();

        public IQueryable<ViolationVihicle> ViolationVihicleQuery(ViolationVihicleModel vivForm)
        {
            IQueryable<ViolationVihicle> violationVihicleQuery = db.ViolationVihicle;
            if (vivForm.Id > 0)
            {
                violationVihicleQuery = violationVihicleQuery.Where(viv => viv.Id == vivForm.Id);
            }
            if (!String.IsNullOrEmpty(vivForm.EtlSystem))
            {
                violationVihicleQuery = violationVihicleQuery.Where(viv => viv.EtlSystem.Contains(vivForm.EtlSystem));
            }
            return violationVihicleQuery;
        }

        public bool Update(ViolationVihicleModel model)
        {
            try
            {
                db.Database.BeginTransaction();
                var vivQuery = db.ViolationVihicle.FirstOrDefault(viv => viv.Id == model.Id);
                vivQuery.SystemDate = DateTime.Now;
                vivQuery.SystemStaff = model.SystemStaff;
                vivQuery.UpdateDate = DateTime.Now;
                vivQuery.UpdateStaff = model.UpdateStaff;
                vivQuery.EtlSystem = model.EtlSystem;
                vivQuery.EtlTable = model.EtlTable;
                vivQuery.EtlField = model.EtlField;
                vivQuery.EtlValue = model.EtlValue;
                vivQuery.Code = model.Code;
                vivQuery.PersonCode = model.PersonCode;
                vivQuery.VehicleCode = model.VehicleCode;
                vivQuery.Status = model.Status;

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

        public bool Insert(ViolationVihicleModel model)
        {
            try
            {
                db.Database.BeginTransaction();
                ViolationVihicle viv = new ViolationVihicle();
                //var person = db.Person.FirstOrDefault(p => p.Id == modal.id);
                viv.SystemDate = DateTime.Now;
                viv.SystemStaff = model.SystemStaff;
                viv.UpdateDate = DateTime.Now;
                viv.UpdateStaff = model.UpdateStaff;
                viv.EtlSystem = model.EtlSystem;
                viv.EtlTable = model.EtlTable;
                viv.EtlField = model.EtlField;
                viv.EtlValue = model.EtlValue;
                viv.Code = model.Code;
                viv.PersonCode = model.PersonCode;
                viv.VehicleCode = model.VehicleCode;
                viv.Status = model.Status;

                db.ViolationVihicle.Add(viv);
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
