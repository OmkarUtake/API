using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Student
    {
        [Key]
        public int Std_id { get; set; }
        public string Std_FirstName { get; set; }
        public string Std_LastName { get; set; }
    }
}
