﻿using System;
using TRSFBrewery;
using System.Threading.Tasks;

namespace TRSFBrewerConsole
{
    class Program
    {
        static async Task Main(string[] args) 
        {
        Searchin searhin = new Searchin();
        searhin.searchIn("Unique");

       //await searhin.searchBeerAsync();

        //searhin.searchInBeerandBreweryAsync();

        }
    }
}
