using AllAboutCatsApp.Services;



namespace AllAboutCatsApp.Views;

public partial class LoadingPage : ContentPage
{
	private readonly Authentication _authservice;
	public LoadingPage(Authentication authservice)
	{
		InitializeComponent();
		_authservice = authservice;
	}

	//protected async override void OnNavigationTo(NavigationEventArgs e)
	//{
		
	//	{
	//		if (await _authservice.IsAuthenticatedAsync())
	//		{
	//			//user logged in
	//			await Shell.Current.GoToAsync($"//{nameof(CatBreedPage)}");
	//		}
	//		else
	//		{
	//			//user not logged in
	//			await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
	//		}
	//	}
 //       base.OnNavigatedTo(e);

 //   }

	//protected override async void OnAppearing()
	//{
	//	base.OnAppearing();

	//	if ( await _authservice.IsAuthenticatedAsync())
	//	{
	//		await Shell.Current.GoToAsync($"//{nameof(SignUpPage)}");
	//	}
	//	else
	//	{
	//		await Shell.Current.GoToAsync($"//{nameof(SignInPage)}");
	//	}
	//}

}