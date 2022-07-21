using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.FasadeStructural
{
    /// <summary>
    /// Client know order and place order only
    /// </summary>
    /// Structural Pattern
    ///We want to provide a simple interface to a complex subsystem. Subsystems often get more complex as they evolve.
    // There are many dependencies between clients and the implementation classes
    public class OrderFacade
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Place Order Started");
            Product product = new Product();
            product.GetProductDetails();
            Payment payment = new Payment();
            payment.MakePayment();
            Invoice invoice = new Invoice();
            invoice.Sendinvoice();
            Console.WriteLine("Order Placed Successfully");
        }
    }
}
