using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAboutCatsApp.Models
{
    //Design pattern to save searched breed
    internal class SearchedBreedSingleton
    {
        private static SearchedBreedSingleton _instance = new SearchedBreedSingleton();

        private string _lastSearchedBreed; 

        public static SearchedBreedSingleton Instance()
        { 
            return _instance; 
        }

        private SearchedBreedSingleton()
        {

        }

        public string LastSearchedBreed()
        { 
            return _lastSearchedBreed; 
        }

        public void SaveLastSearchedBreed(string lastSearchedBreed)
        { 
            _lastSearchedBreed = lastSearchedBreed;
        }
    }
}
