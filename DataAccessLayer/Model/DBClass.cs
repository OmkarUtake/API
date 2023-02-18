using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class DBClass : DbContext
    {
        public DbSet<Student> Students { get; set; }
     
    }
}
