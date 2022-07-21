using ConsoleApp5.FasadeStructural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.FactoryStructural
{

       //The Object needs to be extended to the subclasses
       // Classes don’t know what exact sub-classes it has to create
       //The Product implementation going to change over time and the Client remains unchanged
        public class CreditCardFactory
        {
            public static ICreditCard GetCreditCard(string cardType)
            {
                ICreditCard cardDetails = null;

                if (cardType == "MoneyBack")
                {
                    cardDetails = new MoneyBack();
                }
                else if (cardType == "Titanium")
                {
                    cardDetails = new Titanium();
                }
                else if (cardType == "Platinum")
                {
                    cardDetails = new Platinum();
                }

                return cardDetails;
            }
        
        }
}
