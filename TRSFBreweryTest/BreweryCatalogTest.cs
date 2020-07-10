using System;
using Xunit;
using TRSFBrewery;

namespace TRSFBreweryTest
{
    public class BreweryCatalogTest
    {
        [Theory]
        [InlineData("3,3 Fonteinen Brouwerij Ambachtelijke Geuzestekerij,Hoogstraat 2A,,Beersel,Vlaams Brabant,,Belgium,32-02-/-306-71-03,http://www.3fonteinen.be/index.htm,,,2010-07-22 20:00:20")]
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