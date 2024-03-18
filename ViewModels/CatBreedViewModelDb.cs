using AllAboutCatsApp.Data;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAboutCatsApp.ViewModels
{
    internal class CatBreedViewModelDb
    {
        public static List<Models.CatsBreed2> TheBreeds { get; set; }
        

        static string connectionString = "mongodb+srv://dwina83:dwina0707!@cluster0.9pgnac0.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";

        public static string ExexptionMessage { get; set; }

        public CatBreedViewModelDb()
        {
           InitializeAsync();
        }

        private async void InitializeAsync()
        {
            try
            {
                await SaveToDb();
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync($"Failed to download database!: {ex.Message}");
            }
        }

        public  static async Task SaveToDb() 
        {
            
            var client = Data.DB.GetClient();
            var database = "BreedData";
            var breedCollection = "Breeds";
                
            var repository = new CatBreedRepository(connectionString,database,breedCollection);

            List<Models.CatsBreed2> breeds = await CatsBreedViewModel.GetBreedsAsync();

            await repository.SaveBreedAsync(breeds);

            TheBreeds = breeds;


        }
    
    }
}
