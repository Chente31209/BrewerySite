using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrewerySiteBlazor.Models;

namespace BrewerySiteBlazor.Services
{
    public class BeerService : ICRUDService<BeerListItem, BeerItem>
    {
        static InputSelectItem[] categories = new InputSelectItem[] {
            new InputSelectItem() { Value = "1", Label = "Category 1" },
            new InputSelectItem() { Value = "2", Label = "Category 2" },
            new InputSelectItem() { Value = "3", Label = "Category 3" }
        };

        static List<BeerItem> Beers = new List<BeerItem>{
           new BeerItem{id=1,beer_name="Corona",brewery_id="1"},
           new BeerItem{id=2,beer_name="Modelo",brewery_id="2"},
           new BeerItem{id=3,beer_name="XX",brewery_id="3"}
        };

        public Task<BeerListItem[]> GetList()
        {
            return Task.FromResult(
                Beers.Select(x => new BeerListItem()
                {
                    id = x.id,
                    beer_name = x.beer_name,
                    brewery_id = categories
                        .Where(y => y.Value == x.brewery_id)
                        .Select(y => y.Label)
                        .SingleOrDefault()
                }).ToArray()
            );
        }

        public Task<BeerItem> GetNew()
        {
            var beer = new BeerItem();
            beer.brewery_id = categories.First().Value;
            //beer.CategoryId = categories.First().Value;
            return Task.FromResult(beer);
        }


        public Task<BeerItem> Get(int id)
        {
            var beer = Beers.SingleOrDefault(x => x.id == id);
           // beer.Categories = categories;
            return Task.FromResult(beer);
        }

        public Task Create(BeerItem item)
        {
            item.id = Beers.Count() > 0 ? Beers.Max(x => x.id) + 1 : 1;
            Beers.Add(item);
            return Task.CompletedTask;
        }

        public Task Update(BeerItem item)
        {
            var beer = Beers.SingleOrDefault(x => x.id == item.id);
            if (beer == null) throw new ArgumentException("beer not found!");
            beer.id = item.id;
            beer.brewery_id = item.brewery_id;
            beer.beer_name = item.beer_name;
            return Task.CompletedTask;
        }

        public Task Delete(int id)
        {
            var beer = Beers.SingleOrDefault(x => x.id == id);
            if (beer == null) throw new ArgumentException("beer not found!");
            Beers.Remove(beer);
            return Task.CompletedTask;
        }
    }
}