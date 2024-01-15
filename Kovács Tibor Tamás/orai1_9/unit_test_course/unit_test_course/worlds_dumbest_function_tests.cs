using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_test_course
{
    class worlds_dumbest_function_tests
    {
        // Naming Convention ClassName_MethodName_ExpectedResults
        public static void worlds_dumbest_function_ReturnPikachuIfZero_ReturnString()
        {
            try
            {
                //Arrange - Intézkedés 
                int num = 0;
                worlds_dumbest_function worldDumbest = new worlds_dumbest_function();

                //Act - cselekvés - futtasd a függvényt
                string result = worldDumbest.ReturnsPikachuIfZero(num);
                if (result == "PIKACHU!")
                {
                    Console.WriteLine("Passed");
                }
                else
                {
                    Console.WriteLine("Failed");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
