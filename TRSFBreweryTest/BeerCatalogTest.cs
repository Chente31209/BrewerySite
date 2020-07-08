using System;
using Xunit;
using TRSFBrewery;

namespace TRSFBreweryTest
{
    public class BeerCatalogTest
    {
        [Theory]
        [InlineData("21,1142,Bigfoot 2001,-1,-1,9.6,10,0,0")]
        [InlineData("146,1392,Yeti Special Export,8,95,7,10,0,0")]
        [InlineData("218,501,Summer Common,-1,-1,4.5,10,0,0")]
        [InlineData($" \" hola mindo \" ")]
        public void ParseTest()
        {
            TRSFBrewery.Beer beer=new TRSFBrewery.Beer();
            var result=beer.Parse(row);
            Assert.IsType(typeof(Style), result);

        }
    }
}