using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TRSFBrewery;

namespace BrewerySite.API.Controllers
{
    [Route("api/Occasions")]
    [ApiController]
    public class OccasionsController : ControllerBase
    {
        OccasionsCatalog occasionsCatalog = new OccasionsCatalog();
        [HttpGet]
        public Task<List<Occasions>> GetOccasions()
        {
            return occasionsCatalog.GetlistOccasions(@"..\\Files\\Occasions.csv");
        }

        [HttpPost]
        public ActionResult setOccasions(Occasions occasions)
        {
             return Ok(occasions); 
        }
    }
}
