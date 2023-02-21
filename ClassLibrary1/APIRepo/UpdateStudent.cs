using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.APIRepo
{
    public class UpdateStudent : IUpdateStudent
    {
        DBClass db = new DBClass();

        public Student Edit(Student std)
        {
            var student = db.Students.Where(x => x.Std_id == std.Std_id).FirstOrDefault();
            if (student != null)
            {
                student.Std_id = std.Std_id;
                student.Std_FirstName = std.Std_FirstName;
                student.Std_LastName = std.Std_LastName;
                db.SaveChanges();

            }

            return student;
        }
    }
}

