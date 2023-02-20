using BuisnessLayer.APIRepo;
using DataAccessLayer.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;



namespace ServiceLayer.Controllers
{
    public class StudentController : ApiController
    {
        private readonly IGetData _getdata;
        public StudentController(IGetData getdata)
        {
            _getdata = getdata;
        }

        DBClass db = new DBClass();

        [HttpGet]
        public IHttpActionResult GetStudents()
        {
            var list = _getdata.GetAllStudents();
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

        [HttpPost]
        public IHttpActionResult PostStudents(Student std)
        {

            db.Students.Add(std);
            db.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteStudentd(int id)
        {
            var std = db.Students.Where(x => x.Std_id == id).FirstOrDefault();
            db.Students.Remove(std);
            db.SaveChanges();
            return Ok();
        }
    }
}
