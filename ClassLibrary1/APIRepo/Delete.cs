using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.APIRepo
{
    public class Delete : IDelete
    {
        DBClass db = new DBClass();

        public void DeleteStudent(int id)
        {
            var std = db.Students.Where(x => x.Std_id == id).FirstOrDefault();
            db.Students.Remove(std);
            db.SaveChanges();
        }
    }
}
