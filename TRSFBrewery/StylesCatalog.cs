using System;
using System.Collections.Generic;


namespace TRSFBrewery
{
    public class StylesCatalog:Catalog
    {
        /// <summary>
        ///  este metodo es para transformar una linea de un arachivo a un objeto 
        /// </summary>
        public Style Parse(String Row)
        {
            try
            {
                Style style = new Style();
                if (!string.IsNullOrEmpty(Row) && !string.IsNullOrWhiteSpace(Row))
                {
                    var styles = Row.Split(',');
                    if (styles.Length == 14)
                    {
                        style.Id = int.Parse(styles[0]);
                        style.cat_id = int.Parse(styles[1]);
                        style.style_name = styles[2];
                        style.Description = styles[3];
                        style.ABV_Low = styles[4];
                        style.ABV_High = styles[5];
                        style.IBU_low = styles[6];
                        style.IBU_High = styles[7];
                        style.SRM_Low = styles[8];
                        style.SRM_High = styles[9];
                        style.OG_Low = styles[10];
                        style.OG_High = styles[11];
                        style.FG_Low = styles[12];
                        style.FG_High = styles[13];
                        style.GlassType = styles[14];

                    }
                    return style;
                }
                else
                    return null;
            }
            catch(Exception e)
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<Style> getListStyle(String filename)
        {
            List<Style> listStyle = new List<Style> {};
            String[] Line = load(filename);

            foreach (var item in Line)
            {
                
                var notnull = Parse(item);
                if (notnull != null)
                    listStyle.Add(notnull);
            }

            return listStyle;
        }
    }
}