using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Entity
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public static List<Department> GetAllDepartments()
        {
            return new List<Department>()
        {
            new Department { ID = 1, Name = "IT"},
            new Department { ID = 2, Name = "HR"},
            new Department { ID = 3, Name = "PayRoll"},
             new Department { ID = 3, Name = "Finance"},
        };
        }
    }
}
