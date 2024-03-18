using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAboutCatsApp.ViewModels
{
    internal class GetBreedFromDbViewModel
    {
        public List<Models.CatsBreed2> Breeds { get; set; }

        public GetBreedFromDbViewModel()
        {
            var task = Task.Run(() => GetBreedCollectionFromDb());
            task.Wait();
            Breeds = task.Result;
        }

        private async Task<List<Models.CatsBreed2>> GetBreedCollectionFromDb()
        { 
            List<Models.CatsBreed2> breedsFromDb = await Data.DB.BreedsCollection().AsQueryable().ToListAsync();
            return breedsFromDb;
        }
    }
}
