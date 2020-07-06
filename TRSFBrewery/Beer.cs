using System;
namespace TRSFBrewery
{
    public class Beer
    {
        
        public int Id{ get; set; }
        public int brewery_id{ get; set; }
        public String name { get; set; }
        public int cat_id{ get; set; }
         public int style_id{ get; set; }
        public String abv { get; set; }
        public String ibu { get; set; }
        public String srm { get; set; }
        public String upc { get; set; }
        public String descript { get; set; }
        
    }

}