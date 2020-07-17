using System;
using System.Xml.Serialization;
using System.IO;

namespace TRSFBrewery
{
    public interface IWriter
    {
        void Write(string filename);
        
    }
}

