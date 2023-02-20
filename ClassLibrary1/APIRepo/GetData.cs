using DataAccessLayer.Model;
using System.Collections.Generic;
using System.Linq;

namespace BuisnessLayer.APIRepo
{
    public class GetData : IGetData
    {
        DBClass db = new DBClass();
        public List<Student> GetAllStudents()
        {
            List<Student> list = db.Students.ToList();
            return list;
        }
    }
}
