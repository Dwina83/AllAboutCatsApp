namespace AllAboutCatsApp.Views;

public partial class AdminPage : ContentPage
{
    public AdminPage()
    {
        InitializeComponent();

    }

    private async void OnClickedDownloadDatabaseCatBreeds(object sender, EventArgs e)
    {
        await ViewModels.CatBreedViewModelDb.SaveToDb() ;
        
    }

    private async void OnClickedViewDatabaseCatBreeds(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CatBreedDatabasePage());
    }

    private async void OnClickedHomeButton(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}
