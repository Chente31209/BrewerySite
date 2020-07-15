using System;
using static System.Console;
using System.Linq;
using System.Threading.Tasks;

namespace TRSFBrewery
{
    public class Searchin
    {
        // rutas de los catalogos 
        static String StylesFile = @"..\\Files\\styles.csv";
        static String BeerFile = @"..\\Files\\beers-cleaned.csv";
        static String BreweryFile = @"..\\Files\\breweries.csv";
        static String OccasionsFile = @"..\\Files\\Occasions.csv";
        static String CategoriesFile = @"..\\Files\\categories.csv";

        // objetos de los catalogos 
        BeerCatalog BC = new BeerCatalog();
        BreweryCatalog BrC = new BreweryCatalog();
        CategoriesCatalog CC = new CategoriesCatalog();
        OccasionsCatalog OC = new OccasionsCatalog();
        StylesCatalog SC = new StylesCatalog();
        // variables de los objetos 
        /// <summary>
        /// este metodo esta creado para al inroducir algunos ateres te muestre  el Beer,  brewery  y el estilo de la misma 
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public async Task searchBeerAsync(/*String Name*/)
        {
            var beer = await BC.GetlistBeerAsync(BeerFile);
            var style = await SC.getListStyleAsync(StylesFile);
            var brewery = await BrC.GetlistBrewery(BreweryFile);
            WriteLine($"|-.........->");
            var bee = from bc in beer
                      join sc in style 
                      on bc.style_id equals sc.Id into ps
                      join br in brewery
                      on bc.brewery_id equals br.Id into sp
                      
                      //where bc.Id==5
                      select (beer: bc, ps.FirstOrDefault().style_name,sp.FirstOrDefault().name);
            foreach (var i in bee)
            {
                //WriteLine($"{bee.FirstOrDefault().beer.Beer_name}  {bee.FirstOrDefault().style_name}");
               WriteLine($"|-----------------------------------------|");
               WriteLine($"{i.beer.Beer_name} | {i.style_name} | {i.name}");

            } WriteLine($"<-.........-|");
        }

        /// <summary>
        /// este metodo tiene la funionalidad de buar y mostrar el id de una tegoria dasa por el usario 
        /// </summary>
        /// <param name="cat"></param>
        /// <returns></returns>
        public async Task searchIn(String cat)
        {
            var ctaegoris = await CC.GetlistCategoriesAsync(CategoriesFile);

            var SearchInCC = from c in ctaegoris
                             where c.cat_name == cat
                             select (c);
            foreach (var i in SearchInCC)
            {
                WriteLine($"la ctegoria que buscas {i.cat_name} tiene el id de {i.Id}");

            }

        }


        public async Task searchInBeerandBreweryAsync()
        {
             WriteLine($"open==>");
            var beer = await BC.GetlistBeerAsync(BeerFile);
            var brewery = await BrC.GetlistBrewery(BreweryFile);

            var iWriterM = from b in beer
                           join br in brewery
                           on b.brewery_id equals br.Id into ps
                           select (beer: b, ps.FirstOrDefault().name);
            foreach (var i in iWriterM)
            {
              WriteLine($"el beer es {i.beer.Beer_name} y su brewery es {i.name}");   
            }
            WriteLine($"<== close ");  
        }

        public async Task ExpBr()
        {
            WriteLine("comenzo ");
            var brewery = await BrC.GetlistBrewery(BreweryFile);
            var result = from br in brewery 
                        select br;

            foreach (var item in result)
            {
                WriteLine($"{item.Id} {item.name}");
            }
            WriteLine("Se ejeto");
        }
    }
}
