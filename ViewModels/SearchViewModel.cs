using AllAboutCatsApp.Contract;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AllAboutCatsApp.ViewModels
{
    internal class SearchViewModel
    {
        public List<Models.CatsBreed2> SearchResults { get; set; }

        public SearchViewModel(string searchQuery)
        {

            var task2 = Task.Run(() => Search(searchQuery));
            task2.Wait();
            SearchResults = task2.Result;
        }

        public static async Task<List<Models.CatsBreed2>> Search(string userInput)
        {
            userInput = "beng";
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.thecatapi.com/");
            client.DefaultRequestHeaders.Add("x-api-key", "live_rYWKKgRZlkP2fNkGM75KHRcJvEqKiEq0EXduiNOJzMog4QwSuCPbVhWoBrzlacN7");
            HttpResponseMessage response = await client.GetAsync($"v1/images/search?breed_ids={userInput}");
            List<Models.CatsBreed2> breedsSearch = null;

            if (response.IsSuccessStatusCode)
            {
                string responseString = await response.Content.ReadAsStringAsync();
                breedsSearch = JsonSerializer.Deserialize<List<Models.CatsBreed2>>(responseString);



            }

            return breedsSearch;
        }
    }
}
