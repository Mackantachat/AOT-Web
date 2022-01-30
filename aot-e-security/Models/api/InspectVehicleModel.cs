using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aot_e_security.Models.DB;

namespace aot_e_security.Models.api
{
    public class InspectVehicleModel 
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
    public class InspectVehicleFunction
    {
        private eSecurityContext db = new eSecurityContext();

        public IQueryable<InspectVehicle> InspectVehicleQuery(InspectVehicleModel ipvForm)
        {
            IQueryable<InspectVehicle> inspectVehicleQuery = db.InspectVehicle;
            if (ipvForm.Id > 0)
            {
                inspectVehicleQuery = inspectVehicleQuery.Where(ipv => ipv.Id == ipvForm.Id);
            }
            if (!String.IsNullOrEmpty(ipvForm.EtlSystem))
            {
                inspectVehicleQuery = inspectVehicleQuery.Where(ipv => ipv.EtlSystem.Contains(ipvForm.EtlSystem));
            }
            return inspectVehicleQuery;
        }

        public bool Update(InspectVehicleModel model)
        {
            try
            {
                db.Database.BeginTransaction();
                var ipvQuery = db.InspectVehicle.FirstOrDefault(p => p.Id == model.Id);
                ipvQuery.SystemDate = DateTime.Now;
                ipvQuery.SystemStaff = model.SystemStaff;
                ipvQuery.UpdateDate = DateTime.Now;
                ipvQuery.UpdateStaff = model.UpdateStaff;
                ipvQuery.EtlSystem = model.EtlSystem;
                ipvQuery.EtlTable = model.EtlTable;
                ipvQuery.EtlField = model.EtlField;
                ipvQuery.EtlValue = model.EtlValue;
                ipvQuery.ReqPassVehicleId = model.ReqPassVehicleId;
                ipvQuery.Status = model.Status;

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

        public bool Insert(InspectVehicleModel model)
        {
            try
            {
                db.Database.BeginTransaction();
                InspectVehicle ipv = new InspectVehicle();
                //var person = db.Person.FirstOrDefault(p => p.Id == modal.id);
                ipv.SystemDate = DateTime.Now;
                ipv.SystemStaff = model.SystemStaff;
                ipv.UpdateDate = DateTime.Now;
                ipv.UpdateStaff = model.UpdateStaff;
                ipv.EtlSystem = model.EtlSystem;
                ipv.EtlTable = model.EtlTable;
                ipv.EtlField = model.EtlField;
                ipv.EtlValue = model.EtlValue;
                ipv.ReqPassVehicleId = model.ReqPassVehicleId;
                ipv.Status = model.Status;

                db.InspectVehicle.Add(ipv);
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
