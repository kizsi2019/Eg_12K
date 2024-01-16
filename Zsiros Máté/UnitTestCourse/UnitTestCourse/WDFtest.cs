using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestCourse
{
    public class WDFtest
    {
        public static void WDF_ReturnPikachuIfZero_ReturnString()
        {
            try
            {
                int num = 1;
                WDF wdf = new WDF();

                string result = wdf.ReturnsPikachuIfZero(num);

                if(result == "PIKACHU!")
                {
                    Console.WriteLine("Passat!: WDF_ReturnPikachuIfZero_ReturnString");
                }
                else
                {
                    Console.WriteLine("Failed: WDF_ReturnPikachuIfZero_ReturnString");
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
