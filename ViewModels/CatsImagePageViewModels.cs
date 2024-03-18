using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAboutCatsApp.ViewModels
{
    internal class CatsImagePageViewModels
    {
        public List<Models.CatsImage> TheImages { get; set; }

        public CatsImagePageViewModels()
        {
            var task = Task.Run(() => GetImageAsync());
            task.Wait();
            TheImages = task.Result;
        }


        public static async Task<List<Models.CatsImage>> GetImageAsync()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.thecatapi.com/");
            client.DefaultRequestHeaders.Add("x-api-key", "live_rYWKKgRZlkP2fNkGM75KHRcJvEqKiEq0EXduiNOJzMog4QwSuCPbVhWoBrzlacN7");

            List<Models.CatsImage> images = null;

            HttpResponseMessage response = await client.GetAsync("v1/images/search?limit=3");

            if (response.IsSuccessStatusCode)
            {
                string responseString = await response.Content.ReadAsStringAsync();
                images = JsonSerializer.Deserialize<List<Models.CatsImage>>(responseString);
            }


            return images;
        }

    }
}
