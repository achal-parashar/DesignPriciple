using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public sealed class Singleton
    {
        //Thread safe since its instantiated at the time of aplication start
        //private static readonly Singleton _instance = new Singleton();
        //private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>(()=>new Singleton());
        private static Singleton _instance = null;
        private static readonly object lockObject = new object();
        private static int counter = 0;
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());   
        }
        public Singleton GetInstance 
        { 
            get 
            {
                lock(lockObject)
                {
                    if (_instance is null)
                        _instance = new Singleton();
                    return _instance;
                }
                //return _instance.Value;
               // return _instance;
            } 
        }
    }
}
