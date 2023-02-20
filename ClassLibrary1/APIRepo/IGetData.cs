using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.APIRepo
{
    public interface IGetData
    {
        List<Student> GetAllStudents();
    }
}
