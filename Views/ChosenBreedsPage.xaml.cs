using AllAboutCatsApp.Models;
using AllAboutCatsApp.ViewModels;

namespace AllAboutCatsApp.Views;

public partial class ChosenBreedsPage : ContentPage
{
    //private ViewModels.SearchViewModelDb searchBreed;
    //static SearchedBreedSingleton breed = SearchedBreedSingleton.Instance();


    public ChosenBreedsPage(string userInput)
	{
		InitializeComponent();
        //string lastSearchedBreed = breed.LastSearchedBreed();
        //searchBreed = new ViewModels.SearchViewModelDb(lastSearchedBreed);
        //BindingContext = searchBreed;
        BindingContext = new ViewModels.SearchViewModelDb(userInput);
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        //breed.SaveLastSearchedBreed(breed.LastSearchedBreed());
        await Navigation.PushAsync(new CatBreedPage());
    }

    private async void OnClickedHomeButton(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}