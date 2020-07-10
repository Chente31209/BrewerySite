using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TRSFBrewery
{
    public class BeerCatalog : Catalog
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Row"></param>
        /// <returns></returns>

        public Beer Parse(String Row)
        {
            Loogers logError=new Loogers();
            try
            {
                Beer beer = new Beer();
                if (!string.IsNullOrEmpty(Row) && !string.IsNullOrWhiteSpace(Row))
                {
                    var Breweries = Row.Split(',');
                    if (Breweries.Length >= 10)
                    {
                        beer.Id = int.Parse(Breweries[0]);
                        beer.brewery_id = int.Parse(Breweries[1]);
                        beer.name = Breweries[2];
                        beer.cat_id = int.Parse(Breweries[3]);
                        beer.style_id = int.Parse(Breweries[4]);
                        beer.abv = Breweries[5];
                        beer.ibu = Breweries[6];
                        beer.srm = Breweries[7];
                        beer.upc = Breweries[8];
                        beer.descript = Breweries[9];
                        return beer;
                    }
                    else
                    return null;
                    
                }
                else
                return null;


            }
            catch (Exception e)
            {
                logError.LogError(e.Message);
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        public async Task <List<Beer>>  GetlistBeerAsync(String FileName)
        {
            List<Beer> listBeer = new List<Beer>();
            var Line = await loadAsync(FileName);
            foreach (var item in Line)
            {
                var notnull = Parse(item);
                if (notnull != null)
                    listBeer.Add(notnull);

            }
            return listBeer;
        }
        /// <summary>
        /// en ete metodo se realisa la busqueda 
        /// </summary>
        /// <param name="name"></param>
        public async Task getBeerAsync (string name )
        {
            Searchin searchin= new Searchin();
            await searchin.searchBeerAsync(name);

        }
    }
}