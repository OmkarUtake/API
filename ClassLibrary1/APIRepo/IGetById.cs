using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.APIRepo
{
    public interface IGetById
    {
        Student StudentByID(int id);
    }

}
