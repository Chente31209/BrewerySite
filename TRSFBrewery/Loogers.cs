using System;
using System.IO;
using System.Threading.Tasks;

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
        public async Task LogError(String error, String NoCatalog)
        {
            String fileName=@"..\\Files\\LongError.txt";
           using (StreamWriter sw = File.AppendText(fileName))
           {
               sw.WriteLine("----Error en la ejecucion <Decripcion>> ");
               sw.WriteLine(error);
               sw.WriteLine($"el numero del arhivo es {NoCatalog}");

           }
        }
    }
    
}