using System;
using Xunit;
using TRSFBrewery;

namespace TRSFBreweryTest
{
    public class OccasionsCatalogTest
    {
        [Theory]
        [InlineData("German-Style Altbier,German Origin Ales,Hybrid Beer,Backyard BBQ,Beers for a barbecue can stand up to the heat and can also pair well with BBQ favorites like hot dogs and burgers. These include red ales, wheat, specialty flavors, and German-style beers.")]
        [InlineData("Wood- and Barrel-Aged Strong Beer,Hybrid/Mixed Beer,Hybrid Beer,Cozy by the Fire,Get toasty while sipping on one of these beers, which are generally dark (brownish reds to nearly black), malty sweet, and chewy. Their robust flavors demand that you savor them, which is okay because these beers do well served cold or warm. These include stouts, porters, and beers with unique flavors like chocolate and coffee.")]
        [InlineData("Non-Alcoholic (Beer) Malt Beverages,Hybrid/Mixed Beer,Specialty Beer,Shotgun,These beers are the easiest to drink (or chug) without filling you up too fast. These beers are often lagers or pale ales, or light beers. These are great for a party, sporting events, or when you want to down a cold one--fast.")]
        
        public void ParseTest(string row)
        {
            OccasionsCatalog OC=new OccasionsCatalog();
            var result=OC.Parse(row);
            Assert.IsType(typeof(Occasions), result);

        }
    }
}