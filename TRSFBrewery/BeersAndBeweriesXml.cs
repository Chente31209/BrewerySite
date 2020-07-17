using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TRSFBrewery
{
    public class BeersAndBeweriesXml
    {
        public string Name_Beer { get; set; }
        public string Name_Bewery { get; set; }

    }
    
    public class BeerList
    {
        public List<BeersAndBeweriesXml> lista { get; set; }
    }
}