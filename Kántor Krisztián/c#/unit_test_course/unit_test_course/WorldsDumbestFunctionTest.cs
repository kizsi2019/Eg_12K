using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace unit_test_course
{
    internal class WorldsDumbestFunctionTest
    {
        //Naming Convention Class_Name_MethodName_ExpectedResult

        public static void world_dumbest_function_ReturnPikachiIfZero_ReturnString()
        {
            try
            {
                //Arrange- Intézkedés
                int num = 1;
                WorldDumbestFunction worldDumbest = new WorldDumbestFunction();

                //Act - Cselekvés - futtasd a fügvényt
                string result = worldDumbest.ReturnsPikachuIfZero(num);
                if (result == "Pikachu") Console.WriteLine("Goot!");
                else Console.WriteLine("Nich goot");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
