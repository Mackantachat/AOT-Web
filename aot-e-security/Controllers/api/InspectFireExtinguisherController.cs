using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using aot_e_security.Models;
using aot_e_security.Models.api;

namespace aot_e_security.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class InspectFireExtinguisherController : ControllerBase
    {
       
        // ใช้เพื่อ select ข้อมูลทั้งหมด
        // เรียกใช้งาน Method GET >> Url: http://localhost:53973/api/InspectFireExtinguisher
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new InspectFireExtinguisherFunction().InspectFireExtinguisherQuery(new InspectFireExtinguisherModel()).ToList());
        }

        // ใช้เพื่อ select ข้อมูลของ ID นั้น ๆ
        // เรียกใช้งาน Method GET >> Url: http://localhost:53973/api/InspectFireExtinguisher/1
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(new InspectFireExtinguisherFunction().InspectFireExtinguisherQuery(new InspectFireExtinguisherModel()).FirstOrDefault(IFEx => IFEx.Id == id));
        }

        // ใช้เพื่อค้นหาข้อมูลข้อมูล
        // เรียกใช้งาน Method POST >> Url: http://localhost:53973/api/InspectFireExtinguisher
        [HttpPost]
        public IActionResult POST([FromBody]InspectFireExtinguisherModel IFExForm)
        {
            var IFExQuery = new InspectFireExtinguisherFunction().InspectFireExtinguisherQuery(IFExForm);
            List<InspectFireExtinguisherModel> listInspectFireExtinguishers = new List<InspectFireExtinguisherModel>();
            foreach (var IFEx in IFExQuery.ToList())
            {
                listInspectFireExtinguishers.Add(new InspectFireExtinguisherModel
                {
                    Id = IFEx.Id,
                    SystemDate = IFEx.SystemDate,
                    SystemStaff = IFEx.SystemStaff,
                    UpdateDate = IFEx.UpdateDate,
                    UpdateStaff = IFEx.UpdateStaff,
                    EtlSystem = IFEx.EtlSystem,
                    EtlTable = IFEx.EtlTable,
                    EtlField = IFEx.EtlField,
                    EtlValue = IFEx.EtlValue,
                    ReqPassVehicleId = IFEx.ReqPassVehicleId,
                    Status = IFEx.Status
                });
            }
            return Ok(listInspectFireExtinguishers);
        }
        // ใช้เพื่อ Update ข้อมูลข้อมูล
        // เรียกใช้งาน Method PATCH >> Url: http://localhost:5000/api/Person
        [HttpPatch]
        public IActionResult Patch([FromBody]InspectFireExtinguisherModel model)
        {
            return Ok(new { status = new InspectFireExtinguisherFunction().Update(model) });
        }

        // ใช้เพื่อ insert ข้อมูลข้อมูล
        // เรียกใช้งาน Method PUT >> Url: http://localhost:5000/api/Person
        [HttpPut]
        public IActionResult Put([FromBody]InspectFireExtinguisherModel model)
        {
            return Ok(new { status = new InspectFireExtinguisherFunction().Insert(model) });
        }

        // ใช้เพื่อ delete ข้อมูลข้อมูล
        // เรียกใช้งาน Method DELETE >> Url: http://localhost:5000/api/Person
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(new { status = new InspectFireExtinguisherFunction().Update(new InspectFireExtinguisherModel { Id = id, Status = "D" }) });
        }
    }
}