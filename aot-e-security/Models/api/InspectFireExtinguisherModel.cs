using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aot_e_security.Models.DB;

namespace aot_e_security.Models.api
{
    public class InspectFireExtinguisherModel
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
        public long ReqPassVehicleId { get; set; }
        public string Status { get; set; }

    }

    public class InspectFireExtinguisherFunction
    {
        private eSecurityContext db = new eSecurityContext();

        public IQueryable<InspectFireExtinguisher> InspectFireExtinguisherQuery(InspectFireExtinguisherModel IFExForm)
        {
            IQueryable<InspectFireExtinguisher> InspectFireExtinguisherQuery = db.InspectFireExtinguisher;
            if (IFExForm.Id > 0)
            {
                InspectFireExtinguisherQuery = InspectFireExtinguisherQuery.Where(IFex => IFex.Id == IFExForm.Id);
            }
            if (!String.IsNullOrEmpty(IFExForm.EtlSystem))
            {
                InspectFireExtinguisherQuery = InspectFireExtinguisherQuery.Where(IFex => IFex.EtlSystem.Contains(IFExForm.EtlSystem));
            }
            return InspectFireExtinguisherQuery;
        }

        public bool Update(InspectFireExtinguisherModel model)
        {
            try
            {
                db.Database.BeginTransaction();
                var IFExQuery = db.InspectFireExtinguisher.FirstOrDefault(IFEx => IFEx.Id == model.Id);
                IFExQuery.SystemDate = DateTime.Now;
                IFExQuery.SystemStaff = model.SystemStaff;
                IFExQuery.UpdateDate = DateTime.Now;
                IFExQuery.UpdateStaff = model.UpdateStaff;
                IFExQuery.EtlSystem = model.EtlSystem;
                IFExQuery.EtlTable = model.EtlTable;
                IFExQuery.EtlField = model.EtlField;
                IFExQuery.EtlValue = model.EtlValue;
                IFExQuery.ReqPassVehicleId = model.ReqPassVehicleId;
                IFExQuery.Status = model.Status;

                db.SaveChanges();
                db.Database.CurrentTransaction.Commit();
                return true;

            }
            catch(Exception ex)
            {
                db.Database.CurrentTransaction.Rollback();
                Console.WriteLine(ex);
                return false;
            }
        }

        public bool Insert(InspectFireExtinguisherModel model)
        {
            try
            {
                db.Database.BeginTransaction();
                InspectFireExtinguisher IFEx = new InspectFireExtinguisher();

                IFEx.SystemDate = DateTime.Now;
                IFEx.SystemStaff = model.SystemStaff;
                IFEx.UpdateDate = DateTime.Now;
                IFEx.UpdateStaff = model.UpdateStaff;
                IFEx.EtlSystem = model.EtlSystem;
                IFEx.EtlTable = model.EtlTable;
                IFEx.EtlField = model.EtlField;
                IFEx.EtlValue = model.EtlValue;
                IFEx.ReqPassVehicleId = model.ReqPassVehicleId;
                IFEx.Status = model.Status;

                db.InspectFireExtinguisher.Add(IFEx);
                db.SaveChanges();
                db.Database.CurrentTransaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                db.Database.CurrentTransaction.Rollback();
                Console.WriteLine(ex);
                return false;
            }
        }
    }

}
