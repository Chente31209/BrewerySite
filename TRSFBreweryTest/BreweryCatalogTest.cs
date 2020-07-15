using System;
using Xunit;
using TRSFBrewery;

namespace TRSFBreweryTest
{
    public class BreweryCatalogTest
    {
        [Theory]
        [InlineData("1423 \",\"Brasserie du Bouffay\",\"54 Rue des Monceaux\",,\"Carquefou\",,\"44470\",\"France\",,,,\"La Brasserie du Bouffay est situ\",\"2011-10-04 00:24:33")]
        [InlineData("54,Atlanta Brewing Company,2323 Defoor Hills Rd NW,,Atlanta,Georgia,30318,United States,404-355-5558,http://www.atlantabrewing.com/,,,2010-07-22 20:00:20")]
        [InlineData("364,Cervecera Nacional,Va Ricardo J. Alfaro y Transistmica,,El Dorado,,,Panama,507-236-1400,,,,2010-07-22 20:00:20")]
        
        public void ParseTest(string row)
        {
            BreweryCatalog BC=new BreweryCatalog();
            var result=BC.Parse(row);
            Assert.IsType(typeof(Brewery), result);

        }
    }
}