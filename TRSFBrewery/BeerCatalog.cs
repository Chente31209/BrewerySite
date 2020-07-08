using System;
using System.Collections.Generic;
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
            Brewery Brewery = new Brewery();
            try
            {
                Beer beer = new Beer();
                if (!string.IsNullOrEmpty(Row) && !string.IsNullOrWhiteSpace(Row))
                {
                    var Breweries = Row.Split(',');
                    if (Breweries.Length == 10)
                    {
                        beer.Id = int.Parse(Breweries[0]);
                        beer.brewery_id = int.Parse(Breweries[0]);
                        beer.name = Breweries[3];
                        beer.cat_id = int.Parse(Breweries[0]);
                        beer.style_id = int.Parse(Breweries[0]);
                        beer.abv = Breweries[6];
                        beer.ibu = Breweries[7];
                        beer.srm = Breweries[7];
                        beer.upc = Breweries[8];
                        beer.descript = Breweries[9];
                    }
                    return beer;
                }
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
        public List<Beer> GetlistBeer(String FileName)
        {
            List<Beer> listBeer = new List<Beer>();
            var Line = load(FileName);
            foreach (var item in Line)
            {
                var notnull = Parse(item);
                if (notnull != null)
                    listBeer.Add(notnull);

            }
            return listBeer;

        }
    }
}