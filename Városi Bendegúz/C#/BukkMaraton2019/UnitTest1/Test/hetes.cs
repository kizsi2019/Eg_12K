using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1.Test
{
    public class hetes
    {
        [Fact]
        public void KeresGyoztesFerfiRovidTavon_KerseOsszesVersenyzot_AkkorTalaljaMegAGyoztest()
        {
            // Arrange
            var versenyzo1 = new Versenyzo
            {
                Rajtszam = "1",
                Nev = "Versenyzo1",
                Egyesulet = "Egyesulet1",
                Ido = new TimeSpan(0, 1, 1),
                Tav = "Rövid",
                Kategoria = "ff"
            };

            var versenyzo2 = new Versenyzo
            {
                Rajtszam = "2",
                Nev = "Versenyzo2",
                Egyesulet = "Egyesulet2",
                Ido = new TimeSpan(0, 1, 2),
                Tav = "Rövid",
                Kategoria = "ff"
            };

            var versenyzok = new List<Versenyzo> { versenyzo1, versenyzo2 };
            var versenyzoKereses = new VersenyzoKereses();

            // Act
            var gyoztes = versenyzoKereses.KeresGyoztesFerfiRovidTavon(versenyzok);

            // Assert
            gyoztes.Should().NotBeNull();
            gyoztes.Rajtszam.Should().Be("1");
            gyoztes.Nev.Should().Be("Versenyzo1");
            gyoztes.Egyesulet.Should().Be("Egyesulet1");
            gyoztes.Ido.Should().Be(new TimeSpan(0, 1, 1));
            gyoztes.Tav.Should().Be("Rövid");
            gyoztes.Kategoria.Should().Be("ff");
        }
        public Versenyzo GyoztesFerfiRovidTav { get; private set; }
    }
}