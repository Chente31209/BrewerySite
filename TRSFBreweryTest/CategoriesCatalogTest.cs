using System;
using Xunit;
using TRSFBrewery;

namespace TRSFBreweryTest
{
    public class CategoriesCatalogTest
    {
        [Theory]
        [InlineData("-1,Unique")]
        [InlineData("4,German Ale")]
        [InlineData("11,Other Style")]
        [InlineData(12)]
        public void ParseTest(string row)
        {
            CategoriesCatalog CC=new CategoriesCatalog();
            var result=CC.Parse(row);
            Assert.IsType(typeof(Style), result);

        }
    }
}