using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesztike
{
    internal class hatos
    { 

        public class Versenyzo
        {
            public bool TobbMintHat { get; set; }
        }

        public class VersenyzoTeszt
        {
            [Fact]
            public void TobbMintHatVersenyzokVizsgalata_HaVoltIlyenVersenyzo_AkkorVisszaadjaHogyVolt()
            {
                // Arrange
                List<Versenyzo> versenyzok = new List<Versenyzo>
                {
                new Versenyzo { TobbMintHat = false },
                new Versenyzo { TobbMintHat = true },
                new Versenyzo { TobbMintHat = false }
                };

                bool tobbMintHat = false;

                // Act
                foreach (var v in versenyzok)
                {
                    if (v.TobbMintHat)
                    {
                        tobbMintHat = true;
                        break;
                    }
                }

                // Assert
                tobbMintHat.Should().BeTrue("mivel volt olyan versenyző, akinek több volt a hat, mint hat");
            }

            [Fact]
            public void TobbMintHatVersenyzokVizsgalata_HaNemVoltIlyenVersenyzo_AkkorVisszaadjaHogyNemVolt()
            {
                // Arrange
                List<Versenyzo> versenyzok = new List<Versenyzo>
                {
                new Versenyzo { TobbMintHat = false },
                new Versenyzo { TobbMintHat = false },
                new Versenyzo { TobbMintHat = false }
                };

                bool tobbMintHat = false;

                // Act
                foreach (var v in versenyzok)
                {
                    if (v.TobbMintHat)
                    {
                        tobbMintHat = true;
                        break;
                    }
                }

                // Assert
                tobbMintHat.Should().BeFalse("mivel nem volt olyan versenyző, akinek több volt a hat, mint hat");
            }
        }
    }
}
