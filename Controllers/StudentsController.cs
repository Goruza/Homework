using HomeworkV3.DTO;
using HomeworkV3.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeworkV3.Data;

namespace HomeworkV3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly Context _context;
        // GET: StudentsController
        public StudentsController (Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentsDTO>>> GetStudents()
        {
            var Student = from students in _context.students
            join students_description in _context.students_description on students.id equals students_description.id
            select new StudentsDTO
            {
                id = students.id,
                Students_Id = students_description.Students_Id,
                Students_grade = students.grade,
                Students_Age = students_description.Students_Age,
                Students_First_Name = students_description.Students_First_Name,
                Students_Last_Name = students_description.Students_Last_Name,
                Students_Adress = students_description.Students_Adress,
                Students_Country = students_description.Students_Country
            };

            return await Student.ToListAsync();
        }

        [HttpGet("{id}")]
        public ActionResult<StudentsDTO> GetStudents_byID(int id)
        {
            var Student = from students in _context.students
            join students_description in _context.students_description on students.id equals students_description.id
            select new StudentsDTO
            {
                id = students.id,
                Students_Id = students_description.Students_Id,
                Students_grade = students.grade,
                Students_Age = students_description.Students_Age,
                Students_First_Name = students_description.Students_First_Name,
                Students_Last_Name = students_description.Students_Last_Name,
                Students_Adress = students_description.Students_Adress,
                Students_Country = students_description.Students_Country
            };

            var students_by_id = Student.ToList().Find(x => x.id == id);

            if (students_by_id == null)
            {
                return NotFound();
            }

            return students_by_id;
        }
    }
}
