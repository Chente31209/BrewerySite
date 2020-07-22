using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TRSFBrewery
{
    public class StylesCatalog : Catalog
    {
        /// <summary>
        ///  este metodo es para transformar una linea de un arachivo a un objeto 
        /// </summary>
        public async Task <Style> Parse(String Row)
        {
            Loogers logError = new Loogers();
            try
            {
                Style style = new Style();
                if (!string.IsNullOrEmpty(Row) && !string.IsNullOrWhiteSpace(Row))
                {
                    var styles = Row.Split(',');
                    if (styles.Length >= 14)
                    {
                        if (int.TryParse(styles[0].Trim('"'), out int Id))
                        {
                            if (int.TryParse(styles[1].Trim('"'), out int Cat_id))
                            {
                                style.Id = Id;
                                style.cat_id = Cat_id;
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
                                return style;
                            }
                            else
                        {
                            await  logError.LogError($"El valor que no se puede conbertir es {styles[1]} ", "5");
                            return null;
                        }
                        }
                        else
                        {
                            await  logError.LogError($"El valor que no se puede conbertir es {styles[0]} ", "5");
                            return null;
                        }
                    }
                    else
                        return null;


                }
                else
                    return null;
            }
            catch (Exception e)
            {
                await  logError.LogError(e.Message, "5");
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public async Task<List<Style>> getListStyleAsync(String filename)
        {
            List<Style> listStyle = new List<Style> { };
            String[] Line = await loadAsync(filename);

            foreach (var item in Line)
            {

                var notnull =await Parse(item);
                if (notnull != null)
                    listStyle.Add(notnull);
            }/*
            foreach (var item in listStyle)
            {
                Console.WriteLine($"{item.Id} {item.style_name}");
            }*/

            return listStyle;
        }
    }
}