using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1
{
    public class CarOrBus
    {
        public string ReturnCarIfZero(int num)
        {
            if (num == 0)
            {
                return "Car!";
            }
            else
            {
                return "Bus!";
            }
        }
            
    }
}
