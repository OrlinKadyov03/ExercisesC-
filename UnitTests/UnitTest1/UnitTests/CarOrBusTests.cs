using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1.UnitTests
{
    public class CarOrBusTests
    {
		// The 3 AAA!
        public static void CarOrBus_ReturnCarIfZero_ReturnString() 
        {
			try
			{				int num = 0;
				CarOrBus carOrBus = new CarOrBus();
				string result = carOrBus.ReturnCarIfZero(num);
				if (result == "Car!")
				{
					Console.WriteLine("PASSED! CarOrBus_ReturnCarIfZero_ReturnString");
				}
				else
				{
					Console.WriteLine("Failed! CarOrBus_ReturnCarIfZero_ReturnString");
				}
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex);
			}
        }
    }
}
