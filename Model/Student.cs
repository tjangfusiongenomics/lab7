using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AQLiteWeb.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string School { get; set; }
        public DateTime StartDate { get; set; }
    }
}
