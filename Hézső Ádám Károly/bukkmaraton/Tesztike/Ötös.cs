using FakeItEasy;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesztike
{
    internal class Ötös
    {
        public void Test_NoiVersenyzoRovidTavon_CountsCorrectly()
        {
            // Arrange
            var versenyzok = A.CollectionOfFake<Versenyzo>(5);
            foreach (var v in versenyzok)
            {
                v.NoiVersenyzo = true;
                v.Tav = "Rövid";
            }
            // Adding a male competitor to verify that it's not counted
            versenyzok[3].NoiVersenyzo = false;

            var expectedCount = 4;

            // Act
            int noiVersenyzoRovidTavon = 0;
            foreach (var v in versenyzok)
            {
                if (v.NoiVersenyzo && v.Tav == "Rövid")
                {
                    noiVersenyzoRovidTavon++;
                }
            }

            // Assert
            noiVersenyzoRovidTavon.Should().Be(expectedCount);
        }
    }
    public class Versenyzo
    {
        public bool NoiVersenyzo { get; set; }
        public string Tav { get; set; }
    }
}

