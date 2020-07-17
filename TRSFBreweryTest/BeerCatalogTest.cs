using System;
using Xunit;
using TRSFBrewery;

namespace TRSFBreweryTest
{
    public class BeerCatalogTest
    {
        [Theory]
        [InlineData("5894,1416,Vivant Tripel,5,61,9.25,10,0,0,\"A classic golden ale, with subtle esters of banana and bubblegum. This beer pours with a creamy head and ends with a sweetness of light Belgian candi sugars. Our brewmaster aged this ale for an extended period to round out the flavors. A great traditional\",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,")]
        
        public void ParseTest(String row)
        {
            BeerCatalog beer=new BeerCatalog();

            var result=beer.Parse(row);
            Assert.IsType(typeof(Beer), result);
            Assert.True(result.Beer_name.Length>0);

        }
    }
}