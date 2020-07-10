using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TRSFBrewery
{
    public class Catalog
    {
        /// <summary>
        /// en esta metodo se realiza una carga asíncrona de los archivos introducidos
        /// ||
        /// in this method an asynchronous load of the entered files is performed
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public async Task <String[]> loadAsync(String filename)
        {
            //var list = File.ReadAllLines(filename);
            var list = await File.ReadAllLinesAsync(filename);
            return list;
        }


    }

}