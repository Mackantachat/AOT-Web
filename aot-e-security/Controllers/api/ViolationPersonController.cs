using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aot_e_security.Models.api;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aot_e_security.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViolationPersonController : ControllerBase
    {
        // ใช้เพื่อ select ข้อมูลทั้งหมด
        // เรียกใช้งาน Method GET >> Url: http://localhost:5000/api/ViolationPerson
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new ViolationPersonFunction().ViolationPersonQuery(new ViolationPersonModel()).ToList());
        }

        // ใช้เพื่อ select ข้อมูลของ ID นั้น ๆ
        // เรียกใช้งาน Method GET >> Url: http://localhost:5000/api/ViolationPerson/1
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(new ViolationPersonFunction().ViolationPersonQuery(new ViolationPersonModel()).FirstOrDefault(vip => vip.Id == id));
        }

        // ใช้เพื่อค้นหาข้อมูลข้อมูล
        // เรียกใช้งาน Method POST >> Url: http://localhost:5000/api/ViolationPerson
        [HttpPost]
        public IActionResult POST([FromBody]ViolationPersonModel vipForm)
        {
            var violationPersonQuery = new ViolationPersonFunction().ViolationPersonQuery(vipForm);
            List<ViolationPersonModel> listViolationPerson = new List<ViolationPersonModel>();
            foreach (var violationPerson in violationPersonQuery.ToList())
            {
                listViolationPerson.Add(new ViolationPersonModel
                {
                    Id = violationPerson.Id,
                    SystemDate = violationPerson.SystemDate,
                    SystemStaff = violationPerson.SystemStaff,
                    UpdateDate = violationPerson.UpdateDate,
                    UpdateStaff = violationPerson.UpdateStaff,
                    EtlSystem = violationPerson.EtlSystem,
                    EtlTable = violationPerson.EtlTable,
                    EtlField = violationPerson.EtlField,
                    EtlValue = violationPerson.EtlValue,
                    Code = violationPerson.Code,
                    PersonCode = violationPerson.PersonCode,
                    ViolationDate = violationPerson.ViolationDate,
                    ArrestDate = violationPerson.ArrestDate,
                    Description = violationPerson.Description,
                    ViolationPlaceCode = violationPerson.ViolationPlaceCode,
                    ResolveMethodCode = violationPerson.ResolveMethodCode,
                    ResolveMethod = violationPerson.ResolveMethod,
                    ResolveDetail = violationPerson.ResolveDetail,
                    ActuationCode = violationPerson.ActuationCode,
                    ActuationResult = violationPerson.ActuationResult,
                    PenaltyCode = violationPerson.PenaltyCode,
                    PenaltyDurationCode = violationPerson.PenaltyDurationCode,
                    FineAmount = violationPerson.FineAmount,
                    FinePayer = violationPerson.FinePayer,
                    FineReceiptNumber = violationPerson.FineReceiptNumber,
                    Remark = violationPerson.Remark,
                    Unit = violationPerson.Unit,
                    StartViolationDate = violationPerson.StartViolationDate,
                    EndViolationDate = violationPerson.EndViolationDate,
                    Behavior = violationPerson.Behavior,
                    Supervisor = violationPerson.Supervisor,
                    License = violationPerson.License,
                    VehicleTypeCode = violationPerson.VehicleTypeCode,
                    VehicleBrandCode = violationPerson.VehicleBrandCode,
                    VehicleColorCode = violationPerson.VehicleColorCode,
                    Place = violationPerson.Place,
                    Point = violationPerson.Point,
                    Property = violationPerson.Property,
                    FlagReport = violationPerson.FlagReport,
                    Status = violationPerson.Status

                });
            }
            return Ok(listViolationPerson);
        }

        // ใช้เพื่อ Update ข้อมูลข้อมูล
        // เรียกใช้งาน Method PATCH >> Url: http://localhost:5000/api/ViolationPerson
        [HttpPatch]
        public IActionResult Patch([FromBody]ViolationPersonModel model)
        {
            return Ok(new { status = new ViolationPersonFunction().Update(model) });
        }

        // ใช้เพื่อ insert ข้อมูลข้อมูล
        // เรียกใช้งาน Method PUT >> Url: http://localhost:5000/api/ViolationPerson
        [HttpPut]
        public IActionResult Put([FromBody]ViolationPersonModel model)
        {
            return Ok(new { status = new ViolationPersonFunction().Insert(model) });
        }
        // ใช้เพื่อ delete ข้อมูลข้อมูล
        // เรียกใช้งาน Method DELETE >> Url: http://localhost:5000/api/ViolationPerson
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(new { status = new ViolationPersonFunction().Update(new ViolationPersonModel { Id = id, Status = "Active" }) });
        }

    }
}