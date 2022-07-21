using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.SOLID
{
    //Client should not forced to depend on methods they ate not using
    //Inteface should be cohesive so basically operations belongs together goes to interface
    public interface IUnit
    {
        public void GetAllUnit();
        public void GetUnitColor();
        
    } 

    public interface IUnitWithReg
    {
        public void GetAllUnitWithReg();
    }

    public class Ausplin : IUnit
    {
        void IUnit.GetAllUnit()
        {
            throw new NotImplementedException();
        }

        void IUnit.GetUnitColor()
        {
            throw new NotImplementedException();
        }
    }
    public class MobileMini : IUnit,IUnitWithReg
    {
        public void GetAllUnitWithReg()
        {
            throw new NotImplementedException();
        }

        void IUnit.GetAllUnit()
        {
            throw new NotImplementedException();
        }

        void IUnit.GetUnitColor()
        {
            throw new NotImplementedException();
        }
    }
}
