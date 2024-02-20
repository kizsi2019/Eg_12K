using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnitTest1.Test
{
    public class hatos
    {
        [Fact]
        public void TobbMintHat_Should_ReturnTrue_When_VersenyzokContainTobbMintHat()
        {
            // Arrange
            var versenyzok = new List<Versenyzo>
            {
                new Versenyzo { TobbMintHat = false },
                new Versenyzo { TobbMintHat = true },
                new Versenyzo { TobbMintHat = false }
            };

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

    public class Versenyzo
    {
        public bool TobbMintHat { get; set; }
    }
}

