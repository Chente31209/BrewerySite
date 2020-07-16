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
            Loogers logError = new Loogers();
            try
            {
                Beer beer = new Beer();
                if (!string.IsNullOrEmpty(Row) && !string.IsNullOrWhiteSpace(Row))
                {
                    var Breweries = Row.Split(',');
                    if (Breweries.Length >= 10)
                    {
                        if (int.TryParse(Breweries[0].Trim('"'), out int Id))
                        {
                            if (int.TryParse((Breweries[1]).Trim('"'), out int Brewery_id))
                            {
                                if (int.TryParse((Breweries[3]).Trim('"'), out int Cat_id))
                                {
                                    if (int.TryParse((Breweries[4]).Trim('"'), out int Style_id))
                                    {
                                        beer.Id = Id;
                                        beer.brewery_id = Brewery_id;
                                        beer.Beer_name = Breweries[2];
                                        beer.cat_id = Cat_id;
                                        beer.style_id = Style_id;
                                        beer.abv = Breweries[5];
                                        beer.ibu = Breweries[6];
                                        beer.srm = Breweries[7];
                                        beer.upc = Breweries[8];
                                        beer.descript = Breweries[9];
                                        return beer;
                                        }
                                    else
                                    {
                                        logError.LogError($"El valor que no se puede conbertir es {Breweries[4]} ", "1");
                                        return null;
                                    }
                                }
                                else
                                {
                                    logError.LogError($"El valor que no se puede conbertir es {Breweries[3]} ", "1");
                                    return null;
                                }


                            }
                            else
                            {
                                logError.LogError($"El valor que no se puede conbertir es {Breweries[1]} ", "1");
                                return null;
                            }
                        }
                        else
                        {
                            logError.LogError($"El valor que no se puede conbertir es {Breweries[0]} ", "1");
                            return null;
                        }
                    }
                    else
                        return null;

                }
                else
                    return null;


            }
            catch (Exception e)
            {
                logError.LogError(e.Message, "1 Beer catalog");
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        public async Task<List<Beer>> GetlistBeerAsync(String FileName)
        {
            List<Beer> listBeer = new List<Beer>();
            var Line = await loadAsync(FileName);
            foreach (var item in Line)
            {
                var notnull = Parse(item);
                if (notnull != null)
                    listBeer.Add(notnull);

            }/*
            foreach (var item in listBeer)
            {
                Console.WriteLine($"{item.Id} {item.Beer_name}");
            }*/
            return listBeer;
        }
        /// <summary>
        /// en ete metodo se realisa la busqueda 
        /// </summary>
        /// <param name="name"></param>
        public async Task getBeerAsync(string name)
        {
            Searchin searchin = new Searchin();
            await searchin.searchBeerAsync(name);

        }
    }
}