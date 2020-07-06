using System;
namespace TRSFBrewery
{
    public class Style
    {
        public int Id { get; set; }
        public int cat_id { get; set; }
        public String style_name { get; set; }
        public String Description { get; set; }
        public String ABV_Low { get; set; }
        public String ABV_High { get; set; }
        public String IBU_low { get; set; }
        public String IBU_High { get; set; }
        public String SRM_Low { get; set; }
        public String SRM_High { get; set; }
        public String OG_Low { get; set; }
        public String OG_High { get; set; }
        public String FG_Low { get; set; }
        public String FG_High { get; set; }
        public String GlassType { get; set; }
    }

}