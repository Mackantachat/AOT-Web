using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aot_e_security.Models.DB;

namespace aot_e_security.Models.api
{
    public class ViolationPersonModel
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
        public DateTime? ViolationDate { get; set; }
        public DateTime? ArrestDate { get; set; }
        public string Description { get; set; }
        public string ViolationPlaceCode { get; set; }
        public string ResolveMethodCode { get; set; }
        public string ResolveMethod { get; set; }
        public string ResolveDetail { get; set; }
        public string ActuationCode { get; set; }
        public string ActuationResult { get; set; }
        public string PenaltyCode { get; set; }
        public string PenaltyDurationCode { get; set; }
        public decimal? FineAmount { get; set; }
        public string FinePayer { get; set; }
        public string FineReceiptNumber { get; set; }
        public string Remark { get; set; }
        public string Unit { get; set; }
        public DateTime? StartViolationDate { get; set; }
        public DateTime? EndViolationDate { get; set; }
        public string Behavior { get; set; }
        public string Supervisor { get; set; }
        public string License { get; set; }
        public string VehicleTypeCode { get; set; }
        public string VehicleBrandCode { get; set; }
        public string VehicleColorCode { get; set; }
        public string Place { get; set; }
        public string Point { get; set; }
        public string Property { get; set; }
        public string FlagReport { get; set; }
        public string Status { get; set; }
    }
    public class ViolationPersonFunction
    {
        private eSecurityContext db = new eSecurityContext();

        public IQueryable<ViolationPerson> ViolationPersonQuery(ViolationPersonModel vipForm)
        {
            IQueryable<ViolationPerson> violationPersonQuery = db.ViolationPerson;
            if (vipForm.Id > 0)
            {
                violationPersonQuery = violationPersonQuery.Where(ipv => ipv.Id == vipForm.Id);
            }
            if (!String.IsNullOrEmpty(vipForm.EtlSystem))
            {
                violationPersonQuery = violationPersonQuery.Where(ipv => ipv.EtlSystem.Contains(vipForm.EtlSystem));
            }
            return violationPersonQuery;
        }
        public bool Update(ViolationPersonModel model)
        {
            try
            {
                db.Database.BeginTransaction();
                var vipQuery = db.ViolationPerson.FirstOrDefault(vip => vip.Id == model.Id);
                vipQuery.SystemDate = model.SystemDate;
                vipQuery.SystemStaff = model.SystemStaff;
                vipQuery.UpdateDate = model.UpdateDate;
                vipQuery.UpdateStaff = model.UpdateStaff;
                vipQuery.EtlSystem = model.EtlSystem;
                vipQuery.EtlTable = model.EtlTable;
                vipQuery.EtlField = model.EtlField;
                vipQuery.EtlValue = model.EtlValue;
                vipQuery.Code = model.Code;
                vipQuery.PersonCode = model.PersonCode;
                vipQuery.ViolationDate = model.ViolationDate;
                vipQuery.ArrestDate = model.ArrestDate;
                vipQuery.Description = model.Description;
                vipQuery.ViolationPlaceCode = model.ViolationPlaceCode;
                vipQuery.ResolveMethodCode = model.ResolveMethodCode;
                vipQuery.ResolveMethod = model.ResolveMethod;
                vipQuery.ResolveDetail = model.ResolveDetail;
                vipQuery.ActuationCode = model.ActuationCode;
                vipQuery.ActuationResult = model.ActuationResult;
                vipQuery.PenaltyCode = model.PenaltyCode;
                vipQuery.PenaltyDurationCode = model.PenaltyDurationCode;
                vipQuery.FineAmount = model.FineAmount;
                vipQuery.FinePayer = model.FinePayer;
                vipQuery.FineReceiptNumber = model.FineReceiptNumber;
                vipQuery.Remark = model.Remark;
                vipQuery.Unit = model.Unit;
                vipQuery.StartViolationDate = model.StartViolationDate;
                vipQuery.EndViolationDate = model.EndViolationDate;
                vipQuery.Behavior = model.Behavior;
                vipQuery.Supervisor = model.Supervisor;
                vipQuery.License = model.License;
                vipQuery.VehicleTypeCode = model.VehicleTypeCode;
                vipQuery.VehicleBrandCode = model.VehicleBrandCode;
                vipQuery.VehicleColorCode = model.VehicleColorCode;
                vipQuery.Place = model.Place;
                vipQuery.Point = model.Point;
                vipQuery.Property = model.Property;
                vipQuery.FlagReport = model.FlagReport;
                vipQuery.Status = model.Status;

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
        public bool Insert(ViolationPersonModel model)
        {
            try
            {
                db.Database.BeginTransaction();
                ViolationPerson vipQuery = new ViolationPerson();
                //var person = db.Person.FirstOrDefault(p => p.Id == modal.id);
                vipQuery.SystemDate = model.SystemDate;
                vipQuery.SystemStaff = model.SystemStaff;
                vipQuery.UpdateDate = model.UpdateDate;
                vipQuery.UpdateStaff = model.UpdateStaff;
                vipQuery.EtlSystem = model.EtlSystem;
                vipQuery.EtlTable = model.EtlTable;
                vipQuery.EtlField = model.EtlField;
                vipQuery.EtlValue = model.EtlValue;
                vipQuery.Code = model.Code;
                vipQuery.PersonCode = model.PersonCode;
                vipQuery.ViolationDate = model.ViolationDate;
                vipQuery.ArrestDate = model.ArrestDate;
                vipQuery.Description = model.Description;
                vipQuery.ViolationPlaceCode = model.ViolationPlaceCode;
                vipQuery.ResolveMethodCode = model.ResolveMethodCode;
                vipQuery.ResolveMethod = model.ResolveMethod;
                vipQuery.ResolveDetail = model.ResolveDetail;
                vipQuery.ActuationCode = model.ActuationCode;
                vipQuery.ActuationResult = model.ActuationResult;
                vipQuery.PenaltyCode = model.PenaltyCode;
                vipQuery.PenaltyDurationCode = model.PenaltyDurationCode;
                vipQuery.FineAmount = model.FineAmount;
                vipQuery.FinePayer = model.FinePayer;
                vipQuery.FineReceiptNumber = model.FineReceiptNumber;
                vipQuery.Remark = model.Remark;
                vipQuery.Unit = model.Unit;
                vipQuery.StartViolationDate = model.StartViolationDate;
                vipQuery.EndViolationDate = model.EndViolationDate;
                vipQuery.Behavior = model.Behavior;
                vipQuery.Supervisor = model.Supervisor;
                vipQuery.License = model.License;
                vipQuery.VehicleTypeCode = model.VehicleTypeCode;
                vipQuery.VehicleBrandCode = model.VehicleBrandCode;
                vipQuery.VehicleColorCode = model.VehicleColorCode;
                vipQuery.Place = model.Place;
                vipQuery.Point = model.Point;
                vipQuery.Property = model.Property;
                vipQuery.FlagReport = model.FlagReport;
                vipQuery.Status = model.Status;

                db.ViolationPerson.Add(vipQuery);
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
