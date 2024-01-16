using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_test_course
{
    internal class world_dumbest_function_tests
    {
        public static void world_dumbest_functoinReturnsPikachuIfZeroReturnString()
        {
			try
			{
                int num = 0;
                world_dumbest_functoin worldDumbest=new world_dumbest_functoin();
                string result = worldDumbest.ReturnsPikachuIfZero(num);
                if (result == "Pika-pika") { Console.WriteLine("world_dumbest_functoinReturnsPikachuIfZeroReturnString"); }
                else
                {

                }
			}
			catch (Exception ex)
			{

                Console.WriteLine(ex); ;
			}
        }
    }
}
