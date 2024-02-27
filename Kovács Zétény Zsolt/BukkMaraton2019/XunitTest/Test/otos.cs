using BukkMaraton2019;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace XunitTest.Test
{

    public class otos
    {
        public class Versenyzo1
        {
            public bool NoiVersenyzo { get; set; }
            public string Tav { get; set; }
            public bool TobbMintHat { get; set; }
        }

        [Fact]
        public void NoiVersenyzokSzamaRovidTavon_Valid()
        {
            // Arrange
            var versenyzok = new List<Versenyzo1>
        {
            new Versenyzo1 { NoiVersenyzo = true, Tav = "Rövid" },
            new Versenyzo1 { NoiVersenyzo = true, Tav = "Rövid" },
            new Versenyzo1 { NoiVersenyzo = false, Tav = "Rövid" },
            new Versenyzo1 { NoiVersenyzo = true, Tav = "Hosszú" }
        };

            var sut = new VersenyFeldolgozas();

            // Act
            var noiVersenyzoRovidTavon = sut.CountFemaleRunnersOnShortTrack(versenyzok);

            // Assert
            noiVersenyzoRovidTavon.Should().Be(2);
        }

        [Fact]
        public void VanTobbMintHatErmetSzerzo_Valid()
        {
            // Arrange
            var versenyzok = new List<Versenyzo1>
        {
            new Versenyzo1 { TobbMintHat = false },
            new Versenyzo1 { TobbMintHat = true },
            new Versenyzo1 { TobbMintHat = false }
        };

            var sut = new VersenyFeldolgozas();

            // Act
            var tobbMintHat = sut.HasMoreThanSixMedals(versenyzok);

            // Assert
            tobbMintHat.Should().BeTrue();
        }

        [Fact]
        public void NoiVersenyzokSzamaRovidTavon_EmptyList()
        {
            // Arrange
            var versenyzok = new List<Versenyzo1>(); // Üres lista

            var sut = new VersenyFeldolgozas();

            // Act
            var noiVersenyzoRovidTavon = sut.CountFemaleRunnersOnShortTrack(versenyzok);

            // Assert
            noiVersenyzoRovidTavon.Should().Be(0);
        }
        public class VersenyFeldolgozas
        {
            public int CountFemaleRunnersOnShortTrack(List<Versenyzo> versenyzok)
            {
                int noiVersenyzoRovidTavon = 0;
                foreach (var item in versenyzok)
                {
                    if (item.NoiVersenyzo && item.Tav == "Rövid")
                    {
                        noiVersenyzoRovidTavon++;
                    }
                }
                return noiVersenyzoRovidTavon;
            }

            public bool HasMoreThanSixMedals(List<Versenyzo1> versenyzok)
            {
                foreach (var item in versenyzok)
                {
                    if (item.TobbMintHat)
                    {
                        return true;
                    }
                }
                return false;
            }

            internal object CountFemaleRunnersOnShortTrack(List<Versenyzo1> versenyzok)
            {
                throw new NotImplementedException();
            }
        }

    }
}

