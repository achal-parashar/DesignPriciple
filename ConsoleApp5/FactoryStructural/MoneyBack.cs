using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.FactoryStructural
{
    public class MoneyBack : ICreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }
        public int GetCreditLimit()
        {
            return 15000;
        }
        public int GetAnnualCharge()
        {
            return 500;
        }
    }
}
