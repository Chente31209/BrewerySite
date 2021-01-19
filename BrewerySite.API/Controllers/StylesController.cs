using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TRSFBrewery;


namespace BrewerySite.API.Controllers
{
    [Route("api/Styles")]
    [ApiController]
    public class StylesController : ControllerBase
    {
        StylesCatalog stylesCatalog = new StylesCatalog();
        [HttpGet]
        public Task<List<Style>> GetStyles()
        {
            return stylesCatalog.getListStyleAsync(@"..\\Files\\styles.csv");
        }
    }
}
