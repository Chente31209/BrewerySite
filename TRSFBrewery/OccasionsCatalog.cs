using System;
using System.Collections.Generic;
namespace TRSFBrewery
{
    public class OccasionsCatalog : Catalog
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Row"></param>
        /// <returns></returns>

        public Occasions Parse(String Row)
        {
            try
            {
                Occasions occasions = new Occasions();
                if (!string.IsNullOrEmpty(Row) && !string.IsNullOrWhiteSpace(Row))
                {
                    var occ = Row.Split(',');
                    if (occ.Length == 5)
                    {
                        occasions.BreweryDBStyleName=occ[0];
                        occasions.BreweryDBCategory=occ[1];
                        occasions.CraftBeerCategory=occ[2];
                        occasions.Scenario=occ[3];
                        occasions.Description=occ[4];


                    }
                    return occasions;
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
        public List<Occasions> GetlistOccasions(String FileName)
        {
            List<Occasions> listOccasions = new List<Occasions>();
            var Line = load(FileName);
            foreach (var item in Line)
            {
                var notnull = Parse(item);
                if (notnull != null)
                    listOccasions.Add(notnull);

            }
            return listOccasions;

        }
    }
}