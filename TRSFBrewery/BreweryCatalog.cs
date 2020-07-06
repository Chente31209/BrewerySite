using System;
using System.Collections.Generic;
namespace TRSFBrewery
{
    public class BreweryCatalog : Catalog
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Row"></param>
        /// <returns></returns>

        public Brewery Parse(String Row)
        {
            try
            {
                Brewery Brewery = new Brewery();
                if (!string.IsNullOrEmpty(Row) && !string.IsNullOrWhiteSpace(Row))
                {
                    var Breweries = Row.Split(',');
                    if (Breweries.Length == 12)
                    {
                        Brewery.Id=int.Parse(Breweries[0]);
                        Brewery.name=Breweries[1];
                        Brewery.address1=Breweries[2];
                        Brewery.address2=Breweries [3];
                        Brewery.city=Breweries[4];
                        Brewery.state=Breweries[5];
                        Brewery.code=Breweries[6];
                        Brewery.country=Breweries[7];
                        Brewery.phone=Breweries[8];
                        Brewery.website=Breweries[9];
                        Brewery.filepath=Breweries[10];
                        Brewery.descript=Breweries[11];
                        Brewery.last_mod=Breweries[12];
                       

                    }
                    return Brewery;
                }
                return null;


            }
            catch (Exception e)
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        public List<Brewery> GetlistBrewery(String FileName)
        {
            List<Brewery> listBrewery = new List<Brewery>();
            var Line = load(FileName);
            foreach (var item in Line)
            {
                var notnull = Parse(item);
                if (notnull != null)
                    listBrewery.Add(notnull);

            }
            return listBrewery;

        }
    }
}