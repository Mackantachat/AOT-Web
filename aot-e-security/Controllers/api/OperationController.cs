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
    public class OperationController : ControllerBase
    {
        // ใช้เพื่อ select ข้อมูลทั้งหมด
        // เรียกใช้งาน Method GET >> Url: http://localhost:5000/api/InspectVehicle
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new OperationFunction().OperationQuery(new OperationModel()).ToList());
        }

        // ใช้เพื่อ select ข้อมูลของ ID นั้น ๆ
        // เรียกใช้งาน Method GET >> Url: http://localhost:5000/api/InspectVehicle/1
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(new OperationFunction().OperationQuery(new OperationModel()).FirstOrDefault(ope => ope.Id == id));
        }

        // ใช้เพื่อค้นหาข้อมูลข้อมูล
        // เรียกใช้งาน Method POST >> Url: http://localhost:5000/api/InspectVehicle
        [HttpPost]
        public IActionResult POST([FromBody]OperationModel opeForm)
        {
            var operationQuery = new OperationFunction().OperationQuery(opeForm);
            List<OperationModel> listOperation = new List<OperationModel>();
            foreach (var operation in operationQuery.ToList())
            {
                listOperation.Add(new OperationModel
                {
                    Id = operation.Id,
                    SystemDate = DateTime.Now,
                    SystemStaff = operation.SystemStaff,
                    UpdateDate = DateTime.Now,
                    UpdateStaff = operation.UpdateStaff,
                    EtlSystem = operation.EtlSystem,
                    EtlTable = operation.EtlTable,
                    EtlField = operation.EtlField,
                    EtlValue = operation.EtlValue,
                    Code = operation.Code,
                    EventDescription = operation.EventDescription,
                    EventDate = operation.EventDate,
                    TypeEmergencyCode = operation.TypeEmergencyCode,
                    Remark = operation.Remark,
                    FlagPhone = operation.FlagPhone,
                    FlagDaily = operation.FlagDaily,
                    FlagVerbal = operation.FlagVerbal,
                    FlagRapid = operation.FlagRapid,
                    FlagEmergency = operation.FlagEmergency,
                    FlagBomb = operation.FlagBomb,
                    FlagAnalyze = operation.FlagAnalyze,
                    FlagEoc = operation.FlagEoc,
                    FlagAui = operation.FlagAui,
                    Notifications = operation.Notifications,
                    NotificationsTime = operation.NotificationsTime,
                    TmcCode = operation.TmcCode,
                    ApCode = operation.ApCode,
                    DivisionCode = operation.DivisionCode,
                    CompanyCode = operation.CompanyCode,
                    Status = operation.Status,

                });
            }
            return Ok(listOperation);
        }
        // ใช้เพื่อ Update ข้อมูลข้อมูล
        // เรียกใช้งาน Method PATCH >> Url: http://localhost:5000/api/InspectVehicle
        [HttpPatch]
        public IActionResult Patch([FromBody]OperationModel model)
        {
            return Ok(new { status = new OperationFunction().Update(model) });
        }
        // ใช้เพื่อ insert ข้อมูลข้อมูล
        // เรียกใช้งาน Method PUT >> Url: http://localhost:5000/api/InspectVehicle
        [HttpPut]
        public IActionResult Put([FromBody]OperationModel model)
        {
            return Ok(new { status = new OperationFunction().Insert(model) });
        }
        // ใช้เพื่อ delete ข้อมูลข้อมูล
        // เรียกใช้งาน Method DELETE >> Url: http://localhost:5000/api/InspectVehicle
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(new { status = new OperationFunction().Update(new OperationModel { Id = id, Status = "YES" }) });
        }

    }
}