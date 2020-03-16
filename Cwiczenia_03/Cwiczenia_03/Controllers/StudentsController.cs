using Cwiczenia_03.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia_03.Controllers
{
   
   
    [ApiController]
    [Route("api/students")]
    public class StudentsController: ControllerBase
    {
        [HttpGet]
        public string GetStudents(string orderBy)
        {
            return $"Jan, Anna, Katarzyna posortowane ={orderBy}";
        }

/*        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {


            return NotFound("NIE ZNALEZIONO STUDENT");
        }*/
        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }
    }
}