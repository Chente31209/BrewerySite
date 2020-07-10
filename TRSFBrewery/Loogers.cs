using System;
using System.IO;
namespace TRSFBrewery
{
    public class Loogers
    {
        /// <summary>
        /// con este matodo se se guradan los errores surgidos durate le ejecucion 
        /// ||
        /// With this method, errors arising during the execution are guaranteed.
        /// </summary>
        /// <param name="error"></param>
        public void LogError(String error)
        {
            String fileName=@"D:\User\Vicente\Proyectos\Cursos de Programacion\Curso de C#\Repocitorio\BrewerySite\Files\LongError.txt";
           String[] e =new String[2];
           e[0]="----Error en la ejecucion <Decripcion>> ";
           e[1]=error;
           File.WriteAllLinesAsync(fileName , e);
           
        }
    }
    
}