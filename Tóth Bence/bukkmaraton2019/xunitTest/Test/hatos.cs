using FakeItEasy;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTest.test
{
    public class hatos
    {
        [Fact]
        public void TestTobbMintHat()
        {
            // Arrange
            var versenyzok = A.CollectionOfDummy<Versenyzok>(3);
            // Setting one of the versenyzok to have TobbMintHat true
            versenyzok[1].TobbMintHat = true;

            // Act
            bool tobbMintHat = false;
            foreach (var v in versenyzok)
            {
                if (v.TobbMintHat)
                {
                    tobbMintHat = true;
                    break;
                }
            }

            // Assert
            tobbMintHat.Should().BeTrue();
        }
    }
    public class Versenyzok
    {
        public bool TobbMintHat { get; set; }
    }
}