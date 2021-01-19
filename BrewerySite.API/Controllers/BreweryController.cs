using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BrewerySite;
using TRSFBrewery;

namespace BrewerySite.API.Controllers
{
    [Route("api/Brewery")]
    [ApiController]
    public class BreweryController : ControllerBase
    {
        BreweryCatalog brewery = new BreweryCatalog();
        [HttpGet]
        public Task<List<Brewery>>GetBreweries()
        {
            return brewery.GetlistBrewery(@"..\\Files\\breweries.csv");
        }


    }
}
