using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using BukkMaraton2019;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        static List<Versenyzo> versenyzok = Program.Import();

        [TestMethod]
        public void TestDataCount()
        {
            Assert.AreNotEqual(0, versenyzok.Count);
        }

        [TestMethod]
        public void TestNegyedik()
        {
            //661 sor van a fájlban
            //Math.Round(((691.0 - 661.0) / 691) * 100, 2) ~= 4.34
            Assert.AreEqual(
                4.34, 
                Math.Round(Program.Negyedik(versenyzok), 2));
        }

        [TestMethod]
        public void TestOtodik()
        {
            Assert.AreEqual(49, Program.Otodik(versenyzok));
        }

        [TestMethod]
        public void TestHatodik()
        {
            Assert.AreEqual(true, Program.Hatodik(versenyzok));
        }

        [TestMethod]
        public void TestHetedik()
        {
            Versenyzo versenyzo = Program.Hetedik(versenyzok);

            Assert.AreEqual("R322", versenyzo.Rajtszam);
            Assert.AreEqual("ff", versenyzo.Kategoria);
            Assert.AreEqual("Csontó Ádám", versenyzo.Nev);
            Assert.AreEqual("Buruczki Training System", versenyzo.Egyesulet);
            Assert.AreEqual("1:32:27", versenyzo.Ido);
        }

        [TestMethod]
        public void TestNyolcadik()
        {
            Dictionary<string, int> dict = Program.Nyolcadik(versenyzok);

            Assert.AreEqual(78, dict["m3f"]);
            Assert.AreEqual(197, dict["m2f"]);
            Assert.AreEqual(71, dict["ff"]);
            Assert.AreEqual(128, dict["m1f"]);
            Assert.AreEqual(17, dict["u13f"]);
            Assert.AreEqual(18, dict["u19f"]);
            Assert.AreEqual(15, dict["m4f"]);
            Assert.AreEqual(16, dict["u17f"]);
            Assert.AreEqual(6, dict["1f"]);
            Assert.AreEqual(17, dict["u15f"]);
        }
    }
}
