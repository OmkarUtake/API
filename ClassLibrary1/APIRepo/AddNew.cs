using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.APIRepo
{
    public class AddNew : IAddNew
    {
        DBClass db = new DBClass();
        public void AddStudentd(Student std)
        {
            db.Students.Add(std);
            db.SaveChanges();
        }
    }
}
