using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestCourse
{
    public class WDFTest
    {
        //Name conertion Class_Name_MethodName_ExpectedResults
        public static void WorldDumbestFunction_ReturnPikachuIfZero_ReturnString()
        {
            try
            {
                //Arrange - Intézkedés - szerezd be a változókat, osztályokat, függvényeket
                int num = 0;
                WDF wordDumbest = new WDF();

                //Act - cselekvés - futtasd a függvényt 

                string result = wordDumbest.ReturnsPikachuIfZero(num);

                //Assert - érvényesítés - bármit ad vissza úgy legyen ahogy akarom
                if(result == "PIKACHU")
                {
                    Console.WriteLine("Passed:WorldDumbestFunction_ReturnPikachuIfZero_ReturnString");
                }
                else
                {
                    Console.WriteLine("Failed:WorldDumbestFunction_ReturnPikachuIfZero_ReturnString");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
