using System;
using TRSFBrewery;
using System.Threading.Tasks;

namespace TRSFBrewerConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Searchin searhin = new Searchin();
            BeerCatalog beerCatalog =new  BeerCatalog();
            Serialization serialization =new Serialization();
            //searhin.searchIn("Unique");

            //await searhin.ExpBr();
            
           // await searhin.searchInBeerandBreweryAsync();

            //await searhin.searchBeerAsync() ;

             await beerCatalog.getBeerAsync("O");
             serialization.Write();

             

           
        }
    }
}
