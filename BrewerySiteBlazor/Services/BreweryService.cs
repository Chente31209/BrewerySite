using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrewerySiteBlazor.Models;
namespace BrewerySiteBlazor.Services
{
    public class BreweryService: ICRUDService<BreweryListItem, BreweryItem>
    {
        static List<BreweryItem> categories = new List<BreweryItem>{
            new BreweryItem() { id = 1, Name = "Category 1", Description = "Description 1" },
            new BreweryItem() { id = 2, Name = "Category 2", Description = "Description 2" },
            new BreweryItem() { id = 3, Name = "Category 3", Description = "Description 3" },
        };

        public Task<BreweryListItem[]> GetList()
        {
            return Task.FromResult(
                categories.Select(x => new BreweryListItem()
                {
                    id = x.id,
                    Name = x.Name
                }).ToArray()
            );
        }

        public Task<BreweryItem> GetNew()
        {
            return Task.FromResult(
                new BreweryItem()
            );
        }
        public Task<BreweryItem> Get(int id)
        {
            return Task.FromResult(
                categories.SingleOrDefault(x => x.id == id)
            );
        }

        public Task Create(BreweryItem item)
        {
            item.id = categories.Count() > 0 ? categories.Max(x => x.id) + 1 : 1;
            categories.Add(item);
            return Task.CompletedTask;
        }

        public Task Update(BreweryItem item)
        {
            var category = categories.SingleOrDefault(x => x.id == item.id);
            if (category == null) throw new ArgumentException("Category not found!");
            category.Name = item.Name;
            category.Description = item.Description;
            return Task.CompletedTask;
        }

        public Task Delete(int id)
        {
            var category = categories.SingleOrDefault(x => x.id == id);
            if (category == null) throw new ArgumentException("Category not found!");
            categories.Remove(category);
            return Task.CompletedTask;
        }
    }

}
