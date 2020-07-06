using System;
using System.IO;
using System.Collections.Generic;

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
        public String[] load(String filename)
        {
            var list = File.ReadAllLines(filename);
            return list;
        }


    }

}