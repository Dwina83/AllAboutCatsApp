using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAboutCatsApp.Data
{
    internal class CatBreedRepository
    {
        private readonly IMongoCollection<Models.CatsBreed2> _catsBreedsCollection;

        public CatBreedRepository(string connectionString, string databaseName, string collectionName)
        { 
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            _catsBreedsCollection = database.GetCollection<Models.CatsBreed2>(collectionName);
        }
        
        public async Task SaveBreedAsync(List<Models.CatsBreed2> breeds)
        {
            if (breeds == null || breeds.Count == 0)
                return;
            int count = 0;
            foreach (var breed in breeds)
            {
                //breed.data.id = breed.id + count;
                count++;
                
            }

            await _catsBreedsCollection.InsertManyAsync(breeds);
        }

     
    }
}
