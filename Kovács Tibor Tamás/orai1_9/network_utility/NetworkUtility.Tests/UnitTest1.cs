using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NetworkUtility.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public string SendPing()
        {
            return "Success : Ping Sent:";
        }
        public int PingTimeout(int a, int b)
        {
            return a + b;
        }
        public void TestMethod1()
        {
        }
    }
}
