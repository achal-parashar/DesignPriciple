using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    //A class has only one reason to change
    //In other words a class have only one responsibility
    

    /* Violating Class*/
    public class SingleResponsibility
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DepartmentName { get; set; }
        public void SetEmployee()
        {

        }
        public void SetDepartmentEmployee()
        {

        }
        
        public void Print()
        {

        }
    }
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void SetEmployee()
        {

        }
      
    }
    public class Department
    {
        
        public string DepartmentName { get; set; }
    
        public void SetDepartmentEmployee()
        {

        }

    }
    public class Print
    {
        public void PrintFile()
        {

        }

    }
}
