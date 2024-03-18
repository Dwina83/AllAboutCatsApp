namespace AllAboutCatsApp.Views;

public partial class CatImagePage : ContentPage
{
	public CatImagePage()
	{
		InitializeComponent();
		BindingContext = new ViewModels.CatsImagePageViewModels();
	}

    private async void OnGetNewImageClicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new CatImagePage());
    }

    private async void OnClickedHomeButton(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}