using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.SOLID
{
    //Class is open for extension but closed for modifications
    //behaviour can be extended
    //The easiest way to implement the Open-Closed Principle in
    //C# is to add the new functionalities by creating new derived classes which should be inherited from the original base class.
    //So supporst OCP base class may have below extension points
    //Virtual methods, abstract methods, interface inheritance etc.
    public class OpenCLose
    {
        public double GetDiscount( double amount,string type)
        {
            double finalamount = 0;
            //problem is more type more blocks addeda and this class modified all the time
            if(type=="1")
            {
                finalamount = amount - 10;
            }
            else if (type == "2")
            {
                finalamount = amount - 20;
            }
            return finalamount;
        }
    }

    //Now code with open close
    public abstract class Invoice
    {
        public virtual double GetDiscount(double amount)
        {
            return amount - 10;
        }
        public abstract double GiveFree();
    }
    public class FinalInvoice : Invoice
    {
        public override double GetDiscount(double amount)
        {
            return amount - 20;
        }
        public override double GiveFree()
        {
            return 0;
        }
    }
}
