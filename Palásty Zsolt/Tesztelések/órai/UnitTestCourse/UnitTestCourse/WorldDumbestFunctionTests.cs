using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestCourse
{
    public class WorldDumbestFunctionTests
    {
        // Naming Convention ClassName_MethodName_ExpectedResults
        public static void WorldDumbestFunction_ReturnPikachuIfZero_ReturnString()
        {
            try
            {
                //Arrange - Intézkedés - szerezd be a változókat, osztályokat, függvényeket
                int num = 1;
                WorldsDumbestFunction worldDumbest = new WorldsDumbestFunction();

                // Act - cselekvés - futtasd a függvényt
                string result = worldDumbest.ReturnsPikachuIfZero(num);

                // Assert - érvényesítés - bármit ad vissza úgy legyen ahogy akarom
                if (result == "PIKACHU!")
                {
                    Console.WriteLine("Passed: WorldDumbestFunction_ReturnPikachuIfZero_ReturnString");

                }
                else
                {
                    
                        Console.WriteLine("Failed: WorldDumbestFunction_ReturnPikachuIfZero_ReturnString");
                    
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

    }
}
