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
    public class PersonController : ControllerBase
    {
        // ใช้เพื่อ select ข้อมูลทั้งหมด
        // เรียกใช้งาน Method GET >> Url: http://localhost:5000/api/Person
        [HttpGet] 
        public IActionResult Get()
        {
            return Ok(new PersonFunction().PersonQuery(new PersonModel()).ToList());
        }

        // ใช้เพื่อ select ข้อมูลของ ID นั้น ๆ
        // เรียกใช้งาน Method GET >> Url: http://localhost:5000/api/Person/1
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(new PersonFunction().PersonQuery(new PersonModel()).FirstOrDefault(p => p.Id == id));
        }

        //[HttpPost]
        //public IActionResult Post([FromBody] PersonModel pForm)
        //{
        //}

        // ใช้เพื่อค้นหาข้อมูลข้อมูล
        // เรียกใช้งาน Method POST >> Url: http://localhost:5000/api/Person
        [HttpPost]
        public IActionResult POST([FromBody]PersonModel pForm) 
        {
            var pQuery = new PersonFunction().PersonQuery(pForm);
            List<PersonModel> listPreson = new List<PersonModel>();
            foreach (var person in pQuery.ToList()) 
            {
                listPreson.Add(new PersonModel 
                { 
                    id = person.Id,
                    p_air_code = person.PAirCode,
                    code = person.Code,
                    name = person.Name,
                    surname = person.Surname,
                    nationality_number = person.NationalityNumber,
                    address = person.Address,
                    present_company_code = person.PresentCompanyCode,
                    salary_code = person.SalaryCode,
                    flag_violation = person.FlagViolation,
                    flag_blacklist = (int)person.FlagBlacklist
                });
            }
            return Ok(listPreson);
        }

        // ใช้เพื่อ Update ข้อมูลข้อมูล
        // เรียกใช้งาน Method PATCH >> Url: http://localhost:5000/api/Person
        [HttpPatch]
        public IActionResult Patch([FromBody]PersonModel modal)
        {
            return Ok(new { status = new PersonFunction().Update(modal) });
        }

        // ใช้เพื่อ insert ข้อมูลข้อมูล
        // เรียกใช้งาน Method PUT >> Url: http://localhost:5000/api/Person
        [HttpPut]
        public IActionResult Put([FromBody]PersonModel modal)
        {
            return Ok(new { status = new PersonFunction().Insert(modal) });
        }

        // ใช้เพื่อ delete ข้อมูลข้อมูล
        // เรียกใช้งาน Method DELETE >> Url: http://localhost:5000/api/Person
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(new { status = new PersonFunction().Update(new PersonModel { id = id, status = "D" }) });
        }
    }
}