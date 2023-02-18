using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiceLayer.Controllers
{
    public class StudentController : ApiController
    {
        DBClass db = new DBClass();

        [HttpGet]
        public IHttpActionResult GetStudents()
        {
            List<Student> list = db.Students.ToList();
            return Ok(list);
        }

        [HttpGet]
        public IHttpActionResult GetStudentById(int id)
        {
            var student = db.Students.SingleOrDefault(x => x.Std_id == id);
            return Ok(student);
        }

        [HttpPut]
        public IHttpActionResult PutStudent(Student std)
        {
            var student = db.Students.Where(x => x.Std_id == std.Std_id).FirstOrDefault();
            if (student != null)
            {
                student.Std_id = std.Std_id;
                student.Std_FirstName = std.Std_FirstName;
                student.Std_LastName = std.Std_LastName;
                db.SaveChanges();

            }
            return Ok(student);
        }

    }
}
