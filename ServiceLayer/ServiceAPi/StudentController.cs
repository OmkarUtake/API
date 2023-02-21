using BuisnessLayer.APIRepo;
using ClassLibrary1.APIRepo;
using DataAccessLayer.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;



namespace ServiceLayer.Controldlers
{
    public class StudentController : ApiController
    {
        //Fields
        private readonly IGetData _getdata;
        private readonly IGetById _getById;
        private readonly IUpdateStudent _updateStudent;
        private readonly IAddNew _addNew;
        private readonly IDelete _delete;

        //Constructor Used for Injection
        public StudentController(IGetData getdata, IGetById getById, IUpdateStudent updateStudent, IAddNew addNew, IDelete delete)
        {
            _getdata = getdata;
            _getById = getById;
            _updateStudent = updateStudent;
            _addNew = addNew;
            _delete = delete;
        }

        //Controller
        [HttpGet]
        public IHttpActionResult GetStudents()
        {
            var list = _getdata.GetAllStudents();
            return Ok(list);
        }

        [HttpGet]
        public IHttpActionResult GetStudentById(int id)
        {
            var student = _getById.StudentByID(id);
            return Ok(student);
        }

        [HttpPut]
        public IHttpActionResult PutStudent(Student std)
        {
            var student = _updateStudent.Edit(std);
            return Ok(student);
        }

        [HttpPost]
        public IHttpActionResult PostStudents(Student std)
        {
            _addNew.AddStudentd(std);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteStudentd(int id)
        {
            _delete.DeleteStudent(id);
            return Ok();
        }
    }
}
