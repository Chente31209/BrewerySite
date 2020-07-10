using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TRSFBrewery
{
    public class CategoriesCatalog : Catalog
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Row"></param>
        /// <returns></returns>

        public Categories Parse(String Row)
        {
            Loogers loogers=new Loogers();
            try
            {
                Categories categories = new Categories();
                if (!string.IsNullOrEmpty(Row) && !string.IsNullOrWhiteSpace(Row))
                {
                    var categor = Row.Split(',');
                    if (categor.Length == 2)
                    {
                        categories.Id=int.Parse(categor[0]);
                        categories.cat_name=categor[1];
                        return categories;
                    }
                    else 
                    return null;
                }
                else 
                return null;


            }
            catch (Exception e)
            {
                loogers.LogError(e.Message);
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        public async Task <List<Categories>> GetlistCategories(String FileName)
        {
            List<Categories> listCategories = new List<Categories>();
            var Line =await loadAsync(FileName);
            foreach (var item in Line)
            {
                var notnull = Parse(item);
                if (notnull != null)
                    listCategories.Add(notnull);

            }
            return listCategories;

        }
    }
}