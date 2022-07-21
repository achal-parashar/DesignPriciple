using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class OrderService
    {

        //Need to be declared as private readonly and injected as abstration
        public static IServiceLocator ServiceLocator { get; set; }
        //use private readonly so that after instantiation no modifications can be made
        private string _accountGuid;

        //rewrite constructor to invoke dependencies
        public OrderService(string accountGuid)
        {

            _accountGuid = accountGuid;
        }


        // Function doing multiple task
        //Number of parameters are many reduce to 3 or below
        public async void CreateOrderAsync(Guid usedId, string userEmail, Guid accountId, int price, int amount, string ModelIP, string[] data)

        {

            try

            {

                Guid guid = new Guid(_accountGuid);//better we conver string to Guid and compare
                if (accountId == Guid.Parse(_accountGuid))

                {

                    if (price == 0 || price < 0) // can be written as  if(price <= 0)

                        throw new Exception("Invalid price exception");// avoid magic string declare const on global level 

                    if (amount == 0 || amount > 10)

                        throw new Exception("Invalid amount exception");// avoid magic string declare const on global level 



                    System.IO.StreamWriter file = new System.IO.StreamWriter(ModelIP);// club code inside using block to dispose
                                                                                      //We can use short name since scope is very limited  use d or dv instead of dataV
                    foreach (string dataV in data)

                    {

                        // If the line doesn't contain the word 'Time', write the line to the file 

                        if (!dataV.Contains("Time"))//Make sure case sensitive comparison needed else it will write for time
                                                    //!string.Equals(dataV, "Time", StringComparison.OrdinalIgnoreCase)

                        {

                            file.WriteLine(dataV);

                        }

                    }



                    var o = new Order();

                    var i2 = "@gmail.com";//Avoid using magic string

                    o.Price = price * amount + 2.15;

                    o.Path = ModelIP;

                    var ro = ServiceLocator.GetInstance<IRepositoryOrder>();
                    // we can invoke IRepositoryOrder interface abstration instead of using reflection
                    //Make sure case insensitive 
                    if (userEmail.Contains(i2))

                    {

                        o.Price = o.Price * 0.0124;

                    }


                    //ModelIP parameter  is unnecessary 
                    //Better to create a class which hold most of the propert ans single object should 
                    //Serve the purpose
                    //Function returning void but we are holding this output not sure about usecase.
                    var r = await ro.SavingExecute(o, ModelIP, userEmail, usedId, accountId);
                }

                else

                {
                    //Reason may be minningless in this case please add some check to describe why it faild 
                    //Only comparing account can not make sure wether it support order creation or not.
                    throw new Exception("This account does not support order creation.");// avoid using magic string

                }

            }

            catch (Exception ex)

            {

                throw;

            }

        }

    }
}
