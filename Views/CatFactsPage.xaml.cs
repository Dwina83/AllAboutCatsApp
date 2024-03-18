namespace AllAboutCatsApp.Views;

public partial class CatFactsPage : ContentPage
{
	public CatFactsPage()
	{
		InitializeComponent();
		BindingContext = new ViewModels.CatFactsViewModel();
	}

    private async void OnClickedHomeButton(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new MainPage());
    }
}