using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.SOLID
{
    //Subtypes can be substituted for their base types 
    //Child class must not remove behaviour of base class
    //
    public class LSVP
    {
        public string FilePath { get; set; }
        public virtual void ReadFile()
        {
            // Read File logic  
            Console.WriteLine($"Base File {FilePath} has been read");
        }
        public virtual void WriteFile()
        {
            //Write File Logic  
            Console.WriteLine($"Base File {FilePath} has been written");
        }
    }
    public class AdminDataFileUser : LSVP
    {
        public override void ReadFile()
        {
            // Read File logic  
            Console.WriteLine($"File {FilePath} has been read");
        }

        public override void WriteFile()
        {
            //Write File Logic  
            Console.WriteLine($"File {FilePath} has been written");
        }
    }
    public class RegularDataFileUser : LSVP
    {
        public override void ReadFile()
        {
            // Read File logic  
            Console.WriteLine($"File {FilePath} has been read");
        }

        public override void WriteFile()
        {
            //Write File Logic  
            throw new NotImplementedException();
        }
    }



    //Correctway
    public interface IFileReader
    {
        void ReadFile(string filePath);
    }

    public interface IFileWriter
    {
        void WriteFile(string filePath);
    }
    public class AdminDataFileUserFixed : IFileReader, IFileWriter
    {
        public void ReadFile(string filePath)
        {
            // Read File logic    
            Console.WriteLine($"File {filePath} has been read");
        }

        public void WriteFile(string filePath)
        {
            //Write File Logic    
            Console.WriteLine($"File {filePath} has been written");
        }
    }

    public class RegularDataFileUserFixed : IFileReader
    {
        public void ReadFile(string filePath)
        {
            // Read File logic    
            Console.WriteLine($"File {filePath} has been read");
        }
    }
}
