namespace AllAboutCatsApp.Views;

public partial class UserLoggedIn : ContentPage
{
	public UserLoggedIn()
	{
		InitializeComponent();
	}

    private async void OnClickedCatBreeds(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CatBreedPage());
    }

    private async void OnClickedCatImage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CatImagePage());
    }
}