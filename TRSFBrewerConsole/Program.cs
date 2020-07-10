using System;
using TRSFBrewery;
using System.Threading.Tasks;

namespace TRSFBrewerConsole
{
    class Program
    {
        static async Task Main(string[] args) 
        {
           
            BeerCatalog beer=new BeerCatalog();
            await beer.getBeerAsync("Hocus");
        String BreweryFile=@"D:\User\Vicente\Proyectos\Cursos de Programacion\Curso de C#\Repocitorio\BrewerySite\Files\breweries.csv";

            BreweryCatalog b =new BreweryCatalog();
           
     
        }
    }
}
