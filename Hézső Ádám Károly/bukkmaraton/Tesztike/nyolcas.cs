using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesztike
{
    internal class nyolcas
    {
        public class Versenyzo
        {
            public string Kategoria { get; set; }
            public bool NoiVersenyzo { get; set; }
        }

        public class VersenyzoTeszt
        {
            [Fact]
            public void StatisztikaTeszt()
            {
                // Arrange
                List<Versenyzo> versenyzok = new List<Versenyzo>
        {
            new Versenyzo { Kategoria = "ff", NoiVersenyzo = false },
            new Versenyzo { Kategoria = "ff", NoiVersenyzo = true },
            new Versenyzo { Kategoria = "nk", NoiVersenyzo = false },
            new Versenyzo { Kategoria = "nk", NoiVersenyzo = false },
            new Versenyzo { Kategoria = "nk", NoiVersenyzo = false }
        };

                // Act
                Dictionary<string, int> stat = new Dictionary<string, int>();
                foreach (var v in versenyzok)
                {
                    if (!v.NoiVersenyzo)
                    {
                        if (stat.ContainsKey(v.Kategoria))
                        {
                            stat[v.Kategoria]++;
                        }
                        else
                        {
                            stat.Add(v.Kategoria, 1);
                        }
                    }
                }

                // Assert
                stat.Should().ContainKey("ff").And.ContainKey("nk");
                stat["ff"].Should().Be(1, "mivel csak egy férfi versenyző volt az ff kategóriában");
                stat["nk"].Should().Be(3, "mivel három férfi versenyző volt a nk kategóriában");
            }
        }
    }
}
