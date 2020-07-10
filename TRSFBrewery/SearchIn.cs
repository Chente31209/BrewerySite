using System;
using static System.Console;
using System.Linq;
using System.Threading.Tasks;

namespace TRSFBrewery
{
    public class Searchin
    {
        // rutas de los catalogos 
        String StylesFile=@"D:\User\Vicente\Proyectos\Cursos de Programacion\Curso de C#\Repocitorio\BrewerySite\Files\styles.csv";
        String BeerFile=@"D:\User\Vicente\Proyectos\Cursos de Programacion\Curso de C#\Repocitorio\BrewerySite\Files\beers-cleaned.csv";
        String BreweryFile=@"D:\User\Vicente\Proyectos\Cursos de Programacion\Curso de C#\Repocitorio\BrewerySite\Files\breweries.csv";
        // objetos de los catalogos 
        BeerCatalog BC = new BeerCatalog();
        BreweryCatalog BrC = new BreweryCatalog();
        CategoriesCatalog CC = new CategoriesCatalog();
        OccasionsCatalog OC = new OccasionsCatalog();
        StylesCatalog SC = new StylesCatalog();
        // variables de los objetos 
        
        public  async Task  searchBeerAsync(String Name)
        {
            var beer=await BC.GetlistBeerAsync(BeerFile);
            var style= await SC.getListStyleAsync(StylesFile);
            
            var bee = from bc in beer
                    join sc in style on bc.style_id equals sc.Id into ps
                    where bc.name == Name 
                    select (beer: bc, ps.FirstOrDefault().style_name);
                    foreach(var i in bee)
                    {
                        WriteLine($"{bee.FirstOrDefault().beer.name}  {bee.FirstOrDefault().style_name}");
                    }

            /*
            from num in numbers
    where num < 3 || num > 7
    select num;
            
            
            var NBeer=from bc in beer
                      join sc in style on bc equals sc into ps
                      from sc in ps.DefaultIfEmpty()
                      select (style_name: sc, name: bc == Name );
                      //on brc in BrC.GetlistBrewery(BreweryFile)*/


        }
    }
}
