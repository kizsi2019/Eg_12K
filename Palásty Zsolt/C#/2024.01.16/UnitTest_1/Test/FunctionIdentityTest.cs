using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_1.Test
{
    public static class FunctionIdentityTest
    {
        //Naming Converstations -> ClassName_MethodeName_ExeptedResult

        public static void FunctionIdentity_ReturnIdentityOfNumber_ReturnString()
        {
            try
            {
                //Arrange = Go get your variables, whatever you need, your classes, go get functions
                int number = 10;
                FunctionIdentity functionIdentity = new FunctionIdentity();
                
                //Act = Execute this function
                string result = functionIdentity.ReturnIdentityOfNumber(number);

                //Assert = Whatever is returned is it what you want
                if(result == "The number is positive")
                {
                    Console.WriteLine("PASSED: FunctionIdentity_ReturnIdentityOfNumber_ReturnString");
                }
                else
                {
                    Console.WriteLine("FILED: FunctionIdentity_ReturnIdentityOfNumber_ReturnString");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
