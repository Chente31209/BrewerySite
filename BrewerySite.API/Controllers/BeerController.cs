using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TRSFBrewery;

namespace BrewerySite.API.Controllers
{
    [Route("api/Beer")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        BeerCatalog beer = new BeerCatalog();
        [HttpGet]
        public Task<List<Beer>> GetBeers()
        {
            return beer.GetlistBeerAsync(@"..\\Files\\beers-cleaned.csv");
        }

        
    }
}
