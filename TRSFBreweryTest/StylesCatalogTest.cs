using System;
using Xunit;
using TRSFBrewery;

namespace TRSFBreweryTest
{
    public class StylesCatalogTest
    {
        [Theory]
        //[InlineData(@"1,1,, ,  , , , , ,5.5,20,40,5,5,,,1.008,1.016,Stein")]

       // [InlineData(@"81,7,Dortmunder/European-Style Export,Dortmunder has medium hop bitterness. Hop flavor and aroma from noble hops are perceptible but low. Sweet malt flavor can be low and should not be caramel-like. The color of this style is straw to deep golden. The body will be medium bodied. Fruity esters, chill haze, and diacetyl should not be perceived.,5,6,23,29,3,6,,,1.01,1.014,Flute  ")]

        [InlineData(@"141,11,Winter Warmer,anomaly 4,4.5,5,50,20,15,20,,,1.008,1.012,Nonic Pint")]
        [InlineData(12,23,45,6)]// linea incorecta 
        public void ParseTest(string row)
        {
            StylesCatalog styles=new StylesCatalog();
            var result=styles.Parse(row);
            Assert.IsType(typeof(Style), result);

        }
    }
}