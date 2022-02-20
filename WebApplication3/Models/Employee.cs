using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string ename { get; set; }
        public int econtact { get; set; }
        public string email { get; set; }

        public Location location { get; set; }

    }
}
