using FakeItEasy;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace XUnitTest.test
{
    public class nyolcas
    {
        [Fact]
        public void Statisztika_Test()
        {
            // Arrange
            var fakeVersenyzok = new List<Versenyzo2>
            {
                new Versenyzo2 { NoiVersenyzo = false, Kategoria = "A" },
                new Versenyzo2 { NoiVersenyzo = false, Kategoria = "B" },
                new Versenyzo2 { NoiVersenyzo = true, Kategoria = "A" },
                new Versenyzo2 { NoiVersenyzo = false, Kategoria = "A" }
            };

            var expectedStat = new Dictionary<string, int>
            {
                { "A", 2 },
                { "B", 1 }
            };

            var hetes = new Hetes(); // assuming Hetes is the class containing the provided code

            // Act
            var stat = hetes.CalculateStatistics(fakeVersenyzok);

            // Assert
            stat.Should().BeEquivalentTo(expectedStat);
        }

        
    }
    public class Versenyzo2
    {
        public bool NoiVersenyzo { get; set; }
        public string Kategoria { get; set; }
    }

    public class Hetes
    {
        public Dictionary<string, int> CalculateStatistics(List<Versenyzo2> versenyzok)
        {
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

            return stat;
        }
    }
}
