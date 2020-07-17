using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace TRSFBrewery
{
    public class Serialization 
    {
        BeersAndBeweriesXml BABrX = new BeersAndBeweriesXml();
        
        public void Write(List<BeersAndBeweriesXml> ListBeAndBr, string filename = @"..\\Files\\BeersAndBeweries.xml")
        {

            XmlSerializer x = new XmlSerializer(typeof(BeerList));
            BeerList lista =new BeerList();
            lista.lista= ListBeAndBr;


            using (TextWriter writer = new StreamWriter(filename))
            {
                x.Serialize(writer, lista);
                writer.Close();
            }
            var output = File.ReadAllText(filename);
            Console.WriteLine(output);
        }
    }
}