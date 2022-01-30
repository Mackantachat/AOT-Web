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
    public class InspectVehicleController : ControllerBase
    {
        // ใช้เพื่อ select ข้อมูลทั้งหมด
        // เรียกใช้งาน Method GET >> Url: http://localhost:5000/api/InspectVehicle
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new InspectVehicleFunction().InspectVehicleQuery(new InspectVehicleModel()).ToList());
        }

        // ใช้เพื่อ select ข้อมูลของ ID นั้น ๆ
        // เรียกใช้งาน Method GET >> Url: http://localhost:5000/api/InspectVehicle/1
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(new InspectVehicleFunction().InspectVehicleQuery(new InspectVehicleModel()).FirstOrDefault(p => p.Id == id));
        }

        //[HttpPost]
        //public IActionResult Post([FromBody] PersonModel pForm)
        //{
        //}

        // ใช้เพื่อค้นหาข้อมูลข้อมูล
        // เรียกใช้งาน Method POST >> Url: http://localhost:5000/api/InspectVehicle
        [HttpPost]
        public IActionResult POST([FromBody]InspectVehicleModel pForm)
        {
            var inspectVehicleQuery = new InspectVehicleFunction().InspectVehicleQuery(pForm);
            List<InspectVehicleModel> listInspectVehicle = new List<InspectVehicleModel>();
            foreach (var inspectVehicle in inspectVehicleQuery.ToList())
            {
                listInspectVehicle.Add(new InspectVehicleModel
                {
                    Id = inspectVehicle.Id,
                    SystemDate = inspectVehicle.SystemDate,
                    SystemStaff = inspectVehicle.SystemStaff,
                    UpdateDate = inspectVehicle.UpdateDate,
                    UpdateStaff = inspectVehicle.UpdateStaff,
                    EtlSystem = inspectVehicle.EtlSystem,
                    EtlTable = inspectVehicle.EtlTable,
                    EtlField = inspectVehicle.EtlField,
                    EtlValue = inspectVehicle.EtlValue,
                    ReqPassVehicleId = inspectVehicle.ReqPassVehicleId,
                    Status = inspectVehicle.Status

                });
            }
            return Ok(listInspectVehicle);
        }

        // ใช้เพื่อ Update ข้อมูลข้อมูล
        // เรียกใช้งาน Method PATCH >> Url: http://localhost:5000/api/InspectVehicle
        [HttpPatch]
        public IActionResult Patch([FromBody]InspectVehicleModel model)
        {
            return Ok(new { status = new InspectVehicleFunction().Update(model) });
        }

        // ใช้เพื่อ insert ข้อมูลข้อมูล
        // เรียกใช้งาน Method PUT >> Url: http://localhost:5000/api/InspectVehicle
        [HttpPut]
        public IActionResult Put([FromBody]InspectVehicleModel model)
        {
            return Ok(new { status = new InspectVehicleFunction().Insert(model) });
        }

        // ใช้เพื่อ delete ข้อมูลข้อมูล
        // เรียกใช้งาน Method DELETE >> Url: http://localhost:5000/api/InspectVehicle
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(new { status = new InspectVehicleFunction().Update(new InspectVehicleModel { Id = id, Status = "Active" }) });
        }
    }
}