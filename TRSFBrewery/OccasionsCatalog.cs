using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TRSFBrewery
{
    public class OccasionsCatalog : Catalog
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Row"></param>
        /// <returns></returns>

        public async Task <Occasions> Parse(String Row)
        {
            Loogers logError = new Loogers();
            try
            {
                Occasions occasions = new Occasions();
                if (!string.IsNullOrEmpty(Row) && !string.IsNullOrWhiteSpace(Row))
                {
                    var occ = Row.Split(',');
                    if (occ.Length == 5)
                    {
                        occasions.BreweryDBStyleName = occ[0];
                        occasions.BreweryDBCategory = occ[1];
                        occasions.CraftBeerCategory = occ[2];
                        occasions.Scenario = occ[3];
                        occasions.Description = occ[4];
                        return occasions;
                    }
                    else
                    return null;

                }
                else
                return null;


            }
            catch (Exception e)
            {
               await  logError.LogError(e.Message,"4");
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>

        public async Task<List<Occasions>> GetlistOccasions(String FileName)
        {
            List<Occasions> listOccasions = new List<Occasions>();
            var Line = await loadAsync(FileName);
            foreach (var item in Line)
            {
                var notnull = await Parse(item);
                if (notnull != null)
                    listOccasions.Add(notnull);

            }
            return listOccasions;

        }
    }
}