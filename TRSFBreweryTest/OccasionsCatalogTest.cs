using System;
using Xunit;
using TRSFBrewery;

namespace TRSFBreweryTest
{
    public class OccasionsCatalogTest
    {
        [Theory]

        [InlineData("German-Style Altbier,German Origin Ales,Hybrid Beer,Backyard BBQ,\"Beers for a barbecue can stand up to the heat and can also pair well with BBQ favorites like hot dogs and burgers. These include red ales, wheat, specialty flavors, and German-style beers.\"")]
        
        public void ParseTest(string row)
        {
            OccasionsCatalog OC=new OccasionsCatalog();
            var result=OC.Parse(row);
            Assert.IsType(typeof(Occasions), result);

        }
    }
}