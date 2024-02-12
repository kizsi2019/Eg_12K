using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitestCourse.Tests
{
    public class WorldsDumbestFunctionTests
    {
        // Naming Convetion ClassName_MethodName_EspectedResults
        public static void WordDumbestFunction_ReturnPikachuIfZero_ReturnString()
        {
            try
            {
                //Arrange-Intézkedés - szerezd be a változóidat, osztályokat, függvényket
                int num = 0;
                WorldsDumbestFunction worldsDumbest = new WorldsDumbestFunction();

                // Act-Cselekvés - futtasd a függvényt
                string result = worldsDumbest.ReturnsPikachuIfZero(num);

                // Assert-Érvényesítés - bármit ad vissza az úgy van ahogy akarom
                if (result == "PIKACHU!")
                {
                    Console.WriteLine("PASSED: WorldsDumbestFunction.ReturnsPikachuIfZero_ReturnsString");
                }
                else
                {
                    Console.WriteLine("FAILED: WorldsDumbestFunction.ReturnsPikachuIfZero_ReturnsString");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
    }
}
