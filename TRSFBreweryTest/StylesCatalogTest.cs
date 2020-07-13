using System;
using Xunit;
using TRSFBrewery;

namespace TRSFBreweryTest
{
    public class StylesCatalogTest
    {
        [Theory]
        

        [InlineData("141,11,Winter Warmer,anomaly 4,4.5,5,50,20,15,20,,,1.008,1.012,Nonic Pint")]

        public void ParseTest(string row)
        {
            StylesCatalog styles = new StylesCatalog();
            var result = styles.Parse(row);
            Assert.IsType(typeof(Style), result);

        }

        [Theory]
        [InlineData("jdnargñeorfhgñopdfijb")]// linea incorecta 
        public void ParseTestIncorect(string row)
        {
            StylesCatalog styles = new StylesCatalog();
            var result = styles.Parse(row);
            Assert.IsType(typeof(Style), result);

        }


    }
}