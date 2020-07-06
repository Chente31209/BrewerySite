using System;
using TRSFBrewery;
using System.Linq;
namespace TRSFBrewerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog=new StylesCatalog();
            StylesCatalog styles = new StylesCatalog();
            OccasionsCatalog occasions= new OccasionsCatalog();
            var O1 = styles.getListStyle(@"D:\User\Vicente\Proyectos\Cursos de Programacion\Curso de C#\Repocitorio\BrewerySite\Files\styles.csv");
            var O = occasions.GetlistOccasions(@"D:\User\Vicente\Proyectos\Cursos de Programacion\Curso de C#\Repocitorio\BrewerySite\Files\Occasions.csv");
            
            
           
                
            

            
        }
    }
}
