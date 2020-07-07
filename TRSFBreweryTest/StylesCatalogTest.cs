using System;
using Xunit;
using TRSFBrewerConsole;

namespace TRSFBreweryTest
{
    public class StylesCatalogTest
    {
        [Fact]
        public void ParseTest()
        {
            StylesCatalog styles=new StylesCatalog();
            styles.Parse();

        }
    }
}