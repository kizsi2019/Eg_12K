using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_testing
{
    public class worldsdumbestfunctiontests
    {
        public static void WorldDumbestFunction_ReturnPikachuIfZero_ReturnString()
        {
			try
			{
                int num = 1;
                worldsdumbestfunction worldDumbest = new worldsdumbestfunction();

                string result = worldDumbest.ReturnsPikachuIfZero(num);

                if (result == "PIKACHU")
                {
                    Console.WriteLine("Passed: WorldDumbestFunction_ReturnPikachuIfZero_ReturnString()");
                }
                else
                {
                    Console.WriteLine("Failed: WorldDumbestFunction_ReturnPikachuIfZero_ReturnString()");
                }
			}
			catch (Exception ex)
			{

                Console.WriteLine(ex);
            }
        }
    }
}
