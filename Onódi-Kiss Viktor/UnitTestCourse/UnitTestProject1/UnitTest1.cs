using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTestCourse;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program prog = new Program();
            Assert.AreEqual("PIKACHU!", prog.ReturnsPikachuIfZero(0));
            Assert.AreNotEqual("Sajnos nem Pikachu", prog.ReturnsPikachuIfZero(0));

            Assert.AreEqual("Sajnos nem Pikachu", prog.ReturnsPikachuIfZero(12314));
            Assert.AreNotEqual("PIKACHU!", prog.ReturnsPikachuIfZero(12314));
        }
    }
}
