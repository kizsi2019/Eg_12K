using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_TestCourse
{
    public class WorldDumbestFunctionTests
    {
        // Naming Convention ClassName_MethodName_ExpectedResults
        public static void WorldDumbestFunction_ReturnPikacuIfZero_ReturnString()
        {
            try
            {
                //Arrange - Intézkedés - szerezd e a változókat osztályokat függvényeket
                int num = 1;
                WorldsDubestFunction worldDumbest = new WorldsDubestFunction();
                // Act - cselekvés - futtasd a függvényt
                string result = worldDumbest.ReturnsPikachuIfZero(num);

                //Assert - érvényesítés - bármit ad vissza úgy legyen ahogy akarom
                if (result == "PIKACHU!!!!")
                {
                    Console.WriteLine("Passed: WorldDumbestFunction_ReturnPikacuIfZero_ReturnString");
                }
                else
                {
                    Console.WriteLine("Failed: WorldDumbestFunction_ReturnPikacuIfZero_ReturnString");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
    }
}
