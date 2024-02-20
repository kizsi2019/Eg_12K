using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTest.test
{
    public class hetes
    {
        [Fact]
        public void Test_GyoztesFerfiRovidTav()
        {
            // Arrange
            var versenyzok = new[]
            {
                new Versenyzo1 { Rajtszam = 1, Nev = "John Doe", Egyesulet = "ACME", Ido = 100, Tav = "Rövid", Kategoria = "ff" },
                new Versenyzo1 { Rajtszam = 2, Nev = "Jane Smith", Egyesulet = "XYZ", Ido = 90, Tav = "Rövid", Kategoria = "ff" },
                new Versenyzo1 { Rajtszam = 3, Nev = "Alice Johnson", Egyesulet = "ABC", Ido = 110, Tav = "Rövid", Kategoria = "ff" }
            };

            // Act
            var gyoztesFerfiRovidTav = VersenyHelper.GetGyoztesFerfiRovidTav(versenyzok);

            // Assert
            gyoztesFerfiRovidTav.Should().NotBeNull();
            gyoztesFerfiRovidTav.Rajtszam.Should().Be(2);
            gyoztesFerfiRovidTav.Nev.Should().Be("Jane Smith");
            gyoztesFerfiRovidTav.Egyesulet.Should().Be("XYZ");
            gyoztesFerfiRovidTav.Ido.Should().Be(90);
        }

    }
    public class Versenyzo1
    {
        public int Rajtszam { get; set; }
        public string Nev { get; set; }
        public string Egyesulet { get; set; }
        public int Ido { get; set; }
        public string Tav { get; set; }
        public string Kategoria { get; set; }
    }

    public static class VersenyHelper
    {
        public static Versenyzo1 GetGyoztesFerfiRovidTav(Versenyzo1[] versenyzok)
        {
            Versenyzo1 gyoztesFerfiRovidTav = null;
            foreach (var v in versenyzok)
            {
                if (v.Tav == "Rövid" && v.Kategoria == "ff")
                {
                    if (gyoztesFerfiRovidTav == null)
                    {
                        gyoztesFerfiRovidTav = v;
                    }
                    else
                    {
                        if (v.Ido < gyoztesFerfiRovidTav.Ido)
                        {
                            gyoztesFerfiRovidTav = v;
                        }
                    }
                }
            }
            return gyoztesFerfiRovidTav;
        }
    }
}
