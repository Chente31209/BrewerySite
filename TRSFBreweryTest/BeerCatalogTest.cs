using System;
using Xunit;
using TRSFBrewery;

namespace TRSFBreweryTest
{
    public class BeerCatalogTest
    {
        [Theory]
        [InlineData("269,1126,Amber,3,33,5,10,0,0,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,")]
        
        public void ParseTest(String row)
        {
            BeerCatalog beer=new BeerCatalog();

            var result=beer.Parse(row);
            Assert.IsType(typeof(Beer), result);
            Assert.True(result.Beer_name.Length>0);

        }
    }
}