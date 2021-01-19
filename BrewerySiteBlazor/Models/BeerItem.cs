using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace BrewerySiteBlazor.Models
{
    public class BeerItem
    {
        [Required]
        [StringLength(500, ErrorMessage = "Title is too long.")]
        public int id { get; set; }
        public string brewery_id { get; set; }
        public string beer_name { get; set; }
       
    }
}
