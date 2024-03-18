namespace AllAboutCatsApp.Views;

public partial class CatBreedDatabasePage : ContentPage
{
	public CatBreedDatabasePage()
	{
		InitializeComponent();
		BindingContext = new ViewModels.GetBreedFromDbViewModel();
		
	}

    private async void OnClickedHomeButton(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new MainPage());
    }
}