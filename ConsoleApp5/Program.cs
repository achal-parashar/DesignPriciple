//using ConsoleApp5.SOLID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ConsoleApp5.Entity;
using x = ConsoleApp5.Entity;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            InterviewProgram.DisplayCity();

        }
        
    }
    public class class1
    {
        public virtual string DoSomething()
        {
            return "class1";
        }
    }
    public class class2 : class1
    {
        public override string DoSomething()
        {
            return "class2";
        }
    }
    public class class3 : class2
    {
        public string DoSomething()
        {
            return "Class3";
        }
    }
}
