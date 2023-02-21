using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.APIRepo
{
    
    public class GetById : IGetById
    {
        DBClass db = new DBClass();
        public Student StudentByID(int id)
        {
            var student = db.Students.SingleOrDefault(x => x.Std_id == id);
            return student;

        }
      
    }
}
