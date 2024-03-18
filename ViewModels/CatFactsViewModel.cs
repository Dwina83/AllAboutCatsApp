using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAboutCatsApp.ViewModels
{
    internal class CatFactsViewModel
    {
        public List<Models.CatFacts> TheFact {  get; set; }

        public CatFactsViewModel()
        {
            var task = Task.Run(() => GetFactsAsync());
            task.Wait();
            TheFact = task.Result;
        }

        public static async Task<List<Models.CatFacts>> GetFactsAsync()
        { 
            List<Models.CatFacts> facts = null;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync("https://cat-fact.herokuapp.com/facts/random?amount=5");
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    facts = JsonConvert.DeserializeObject<List<Models.CatFacts>>(responseBody);
                }
                
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);

            }
            return facts;
        }
    }
    
}
