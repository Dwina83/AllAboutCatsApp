using AllAboutCatsApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AllAboutCatsApp.ViewModels
{
    internal class CatsBreedViewModel
    {
        public List<Models.CatsBreed2> TheBreeds { get; set; }
        

        //public string UserInput { get; set; }

        public CatsBreedViewModel()
        {
           
                var task1 = Task.Run(() => GetBreedsAsync());
                task1.Wait();
                TheBreeds = task1.Result;
           
        }


        public static async Task<List<Models.CatsBreed2>> GetBreedsAsync()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.thecatapi.com/");
            client.DefaultRequestHeaders.Add("x-api-key", "live_rYWKKgRZlkP2fNkGM75KHRcJvEqKiEq0EXduiNOJzMog4QwSuCPbVhWoBrzlacN7");

            List<Models.CatsBreed2> breeds = null;

            HttpResponseMessage response = await client.GetAsync("v1/breeds");

            if (response.IsSuccessStatusCode)
            {
                string responseString = await response.Content.ReadAsStringAsync();
                breeds = JsonSerializer.Deserialize<List<Models.CatsBreed2>>(responseString);

            }

            return breeds;
        }

        
       

    }
}

