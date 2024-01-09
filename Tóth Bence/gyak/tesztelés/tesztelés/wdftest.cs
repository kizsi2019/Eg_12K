using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tesztelés
{
    public class wdftest
    {
        public static void WorldDumbestFunctions_ReturnPikachuIfZero_ReturnString()
        {
            try
            {
                //Arange - Intézkedés - szerezd be a változókat, osztályokat, függvényeket
                int num = 1;
                wdf worldDumbest = new wdf();

                //Act - cselekvés - futtasd a függvényt
                string result = worldDumbest.ReturnsPikachuIfZero(num);
                if (result == "PIKACHU") 
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
