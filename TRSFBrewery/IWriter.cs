using System;
using System.Xml.Serialization;
using System.IO;

namespace TRSFBrewery
{
    public interface IWriter
    {
        void Write()
        {
            Searchin searchin= new Searchin();
            var SS =searchin.searchInBeerandBreweryAsync();

            string FileName=@"..\\Files\\BeersAndBeweries.xml";
            
                
                
        }
    }
}

