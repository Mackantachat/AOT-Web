using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aot_e_security.Models.DB;

namespace aot_e_security.Models.api
{
    public class OperationModel
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
        public string EventDescription { get; set; }
        public DateTime? EventDate { get; set; }
        public string TypeEmergencyCode { get; set; }
        public string Remark { get; set; }
        public string FlagPhone { get; set; }
        public string FlagDaily { get; set; }
        public string FlagVerbal { get; set; }
        public string FlagRapid { get; set; }
        public string FlagEmergency { get; set; }
        public string FlagBomb { get; set; }
        public string FlagAnalyze { get; set; }
        public string FlagEoc { get; set; }
        public string FlagAui { get; set; }
        public string Notifications { get; set; }
        public DateTime? NotificationsTime { get; set; }
        public string TmcCode { get; set; }
        public string ApCode { get; set; }
        public string DivisionCode { get; set; }
        public string CompanyCode { get; set; }
        public string Status { get; set; }
    }
    public class OperationFunction
    {
        private eSecurityContext db = new eSecurityContext();
        public IQueryable<Operation> OperationQuery(OperationModel opeForm)
        {
            IQueryable<Operation> operationQuery = db.Operation;
            if (opeForm.Id > 0)
            {
                operationQuery = operationQuery.Where(ope => ope.Id == opeForm.Id);
            }
            if (!String.IsNullOrEmpty(opeForm.EtlSystem))
            {
                operationQuery = operationQuery.Where(ope => ope.EtlSystem.Contains(opeForm.EtlSystem));
            }
            return operationQuery;
        }
        public bool Update(OperationModel model)
        {
            try
            {
                db.Database.BeginTransaction();
                var opeQuery = db.Operation.FirstOrDefault(ope => ope.Id == model.Id);
                opeQuery.SystemDate = DateTime.Now;
                opeQuery.SystemStaff = model.SystemStaff;
                opeQuery.UpdateDate = DateTime.Now;
                opeQuery.UpdateStaff = model.UpdateStaff;
                opeQuery.EtlSystem = model.EtlSystem;
                opeQuery.EtlTable = model.EtlTable;
                opeQuery.EtlField = model.EtlField;
                opeQuery.EtlValue = model.EtlValue;
                opeQuery.Code = model.Code;
                opeQuery.EventDescription = model.EventDescription;
                opeQuery.EventDate = model.EventDate;
                opeQuery.TypeEmergencyCode = model.TypeEmergencyCode;
                opeQuery.Remark = model.Remark;
                opeQuery.FlagPhone = model.FlagPhone;
                opeQuery.FlagDaily = model.FlagDaily;
                opeQuery.FlagVerbal = model.FlagVerbal;
                opeQuery.FlagRapid = model.FlagRapid;
                opeQuery.FlagEmergency = model.FlagEmergency;
                opeQuery.FlagBomb = model.FlagBomb;
                opeQuery.FlagAnalyze = model.FlagAnalyze;
                opeQuery.FlagEoc = model.FlagEoc;
                opeQuery.FlagAui = model.FlagAui;
                opeQuery.Notifications = model.Notifications;
                opeQuery.NotificationsTime = model.NotificationsTime;
                opeQuery.TmcCode = model.TmcCode;
                opeQuery.ApCode = model.ApCode;
                opeQuery.DivisionCode = model.DivisionCode;
                opeQuery.CompanyCode = model.CompanyCode;
                opeQuery.Status = model.Status;

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
        public bool Insert(OperationModel model)
        {
            try
            {
                db.Database.BeginTransaction();
                Operation ope = new Operation();
                //var operation = db.Operation.FirstOrDefault(ope => ope.Id == model.id);
                ope.SystemDate = DateTime.Now;
                ope.SystemStaff = model.SystemStaff;
                ope.UpdateDate = DateTime.Now;
                ope.UpdateStaff = model.UpdateStaff;
                ope.EtlSystem = model.EtlSystem;
                ope.EtlTable = model.EtlTable;
                ope.EtlField = model.EtlField;
                ope.EtlValue = model.EtlValue;
                ope.Code = model.Code;
                ope.EventDescription = model.EventDescription;
                ope.EventDate = model.EventDate;
                ope.TypeEmergencyCode = model.TypeEmergencyCode;
                ope.Remark = model.Remark;
                ope.FlagPhone = model.FlagPhone;
                ope.FlagDaily = model.FlagDaily;
                ope.FlagVerbal = model.FlagVerbal;
                ope.FlagRapid = model.FlagRapid;
                ope.FlagEmergency = model.FlagEmergency;
                ope.FlagBomb = model.FlagBomb;
                ope.FlagAnalyze = model.FlagAnalyze;
                ope.FlagEoc = model.FlagEoc;
                ope.FlagAui = model.FlagAui;
                ope.Notifications = model.Notifications;
                ope.NotificationsTime = model.NotificationsTime;
                ope.TmcCode = model.TmcCode;
                ope.ApCode = model.ApCode;
                ope.DivisionCode = model.DivisionCode;
                ope.CompanyCode = model.CompanyCode;
                ope.Status = model.Status;

                db.Operation.Add(ope);
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
