using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesztike
{
    internal class hetes
    {
        public class Versenyzo
        {
            public string Tav { get; set; }
            public string Kategoria { get; set; }
            public int Ido { get; set; }
            public int Rajtszam { get; set; }
            public string Nev { get; set; }
            public string Egyesulet { get; set; }
        }

        public class VersenyzoTeszt
        {
            [Fact]
            public void GyoztesFerfiRovidTavTeszt()
            {
                // Arrange
                List<Versenyzo> versenyzok = new List<Versenyzo>
        {
            new Versenyzo { Tav = "Rövid", Kategoria = "ff", Ido = 100, Rajtszam = 1, Nev = "Teszt Versenyző", Egyesulet = "Teszt Egyesület" },
            new Versenyzo { Tav = "Hosszú", Kategoria = "ff", Ido = 150, Rajtszam = 2, Nev = "Teszt Versenyző 2", Egyesulet = "Teszt Egyesület 2" },
            new Versenyzo { Tav = "Rövid", Kategoria = "ff", Ido = 90, Rajtszam = 3, Nev = "Teszt Versenyző 3", Egyesulet = "Teszt Egyesület 3" },
            new Versenyzo { Tav = "Rövid", Kategoria = "nk", Ido = 95, Rajtszam = 4, Nev = "Teszt Versenyző 4", Egyesulet = "Teszt Egyesület 4" }
        };

                // Act
                Versenyzo gyoztesFerfiRovidTav = null;
                foreach (var v in versenyzok)
                {
                    if (v.Tav == "Rövid" && v.Kategoria == "ff")
                    {
                        if (gyoztesFerfiRovidTav == null || v.Ido < gyoztesFerfiRovidTav.Ido)
                        {
                            gyoztesFerfiRovidTav = v;
                        }
                    }
                }

                // Assert
                gyoztesFerfiRovidTav.Should().NotBeNull("mivel volt olyan versenyző a férfi rövid táv kategóriában");
                gyoztesFerfiRovidTav.Rajtszam.Should().Be(3, "mivel ez a tesztesetben a leggyorsabb versenyző");
                gyoztesFerfiRovidTav.Nev.Should().Be("Teszt Versenyző 3", "mivel ez a tesztesetben a leggyorsabb versenyző");
                gyoztesFerfiRovidTav.Egyesulet.Should().Be("Teszt Egyesület 3", "mivel ez a tesztesetben a leggyorsabb versenyző");
                gyoztesFerfiRovidTav.Ido.Should().Be(90, "mivel ez a tesztesetben a leggyorsabb idő");
            }
        }
    }
}
