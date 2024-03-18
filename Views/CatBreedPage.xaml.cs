using AllAboutCatsApp.Contract;
using AllAboutCatsApp.Models;
using AllAboutCatsApp.ViewModels;
using MongoDB.Driver;


namespace AllAboutCatsApp.Views;

public partial class CatBreedPage : ContentPage
{
    
    public CatBreedPage()
	{
		InitializeComponent();        
        BindingContext = new CatsBreedViewModel();
     

	}

	private async void OnSearchButtonClicked(object sender, EventArgs e)
    {
        var searchQuery = Entrybreed.Text;
        BindingContext = new SearchViewModelDb(searchQuery);

        await SearchViewModelDb.Search(searchQuery);

        //breed.SaveLastSearchedBreed(searchQuery);

        await Navigation.PushAsync(new ChosenBreedsPage(searchQuery));
       
    }

    private async void OnClickedHomeButton(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}