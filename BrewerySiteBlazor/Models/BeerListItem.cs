using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrewerySiteBlazor.Models
{
    public class BeerListItem
    {
        public int id { get; set; }
        public string brewery_id { get; set; }
        public string beer_name { get; set; }
    }
}
