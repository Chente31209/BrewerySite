using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TRSFBrewery;


namespace BrewerySite.API.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        CategoriesCatalog categoriesCatalog = new CategoriesCatalog();
        [HttpGet]
        public Task<List<Categories>> GetCategories()
        {
            return categoriesCatalog.GetlistCategoriesAsync(@"..\\Files\\categories.csv");
        }
    }
}
