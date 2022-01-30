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
    public class ViolationVihicleController : ControllerBase
    {
        // ใช้เพื่อ select ข้อมูลทั้งหมด
        // เรียกใช้งาน Method GET >> Url: http://localhost:5000/api/ViolationVihicle
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new ViolationVihicleFunction().ViolationVihicleQuery(new ViolationVihicleModel()).ToList());
        }
        // ใช้เพื่อ select ข้อมูลของ ID นั้น ๆ
        // เรียกใช้งาน Method GET >> Url: http://localhost:5000/api/ViolationVihicle/1
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(new ViolationVihicleFunction().ViolationVihicleQuery(new ViolationVihicleModel()).FirstOrDefault(p => p.Id == id));
        }


        // ใช้เพื่อค้นหาข้อมูลข้อมูล
        // เรียกใช้งาน Method POST >> Url: http://localhost:5000/api/ViolationVihicle
        [HttpPost]
        public IActionResult POST([FromBody]ViolationVihicleModel pForm)
        {
            var violationVihicleQuery = new ViolationVihicleFunction().ViolationVihicleQuery(pForm);
            List<ViolationVihicleModel> listViolationVihicle = new List<ViolationVihicleModel>();
            foreach (var violationVihicle in violationVihicleQuery.ToList())
            {
                listViolationVihicle.Add(new ViolationVihicleModel
                {
                    Id = violationVihicle.Id,
                    SystemDate = violationVihicle.SystemDate,
                    SystemStaff = violationVihicle.SystemStaff,
                    UpdateDate = violationVihicle.UpdateDate,
                    UpdateStaff = violationVihicle.UpdateStaff,
                    EtlSystem = violationVihicle.EtlSystem,
                    EtlTable = violationVihicle.EtlTable,
                    EtlField = violationVihicle.EtlField,
                    EtlValue = violationVihicle.EtlValue,
                    Code = violationVihicle.Code,
                    PersonCode = violationVihicle.PersonCode,
                    VehicleCode = violationVihicle.VehicleCode,
                    Status = violationVihicle.Status

                });
            }
            return Ok(listViolationVihicle);
        }

        // ใช้เพื่อ Update ข้อมูลข้อมูล
        // เรียกใช้งาน Method PATCH >> Url: http://localhost:5000/api/ViolationVihicle
        [HttpPatch]
        public IActionResult Patch([FromBody]ViolationVihicleModel model)
        {
            return Ok(new { status = new ViolationVihicleFunction().Update(model) });
        }

        // ใช้เพื่อ insert ข้อมูลข้อมูล
        // เรียกใช้งาน Method PUT >> Url: http://localhost:5000/api/ViolationVihicle
        [HttpPut]
        public IActionResult Put([FromBody]ViolationVihicleModel model)
        {
            return Ok(new { status = new ViolationVihicleFunction().Insert(model) });
        }

        // ใช้เพื่อ delete ข้อมูลข้อมูล
        // เรียกใช้งาน Method DELETE >> Url: http://localhost:5000/api/ViolationVihicle
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(new { status = new ViolationVihicleFunction().Update(new ViolationVihicleModel { Id = id, Status = "Active" }) });
        }
    }
}