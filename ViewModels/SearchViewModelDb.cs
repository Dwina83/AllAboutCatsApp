using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAboutCatsApp.ViewModels
{
    internal class SearchViewModelDb
    {
        public List<Models.CatsBreed2> SearchResult {  get; set; }

        public SearchViewModelDb(string searchQuery)
        {
            var task = Task.Run(() => Search(searchQuery));
            task.Wait();
            SearchResult = task.Result;

        }

        public  static async Task<List<Models.CatsBreed2>> Search(string userInput)
        {
            var collection = Data.DB.BreedsCollection();
            var filter = Builders<Models.CatsBreed2>.Filter.Eq(x => x.id, userInput);
            var result = await collection.Find(filter).ToListAsync();
            return result;
        }    
    }
}
