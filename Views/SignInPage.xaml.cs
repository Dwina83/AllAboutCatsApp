
using AllAboutCatsApp.ViewModels;

namespace AllAboutCatsApp.Views;

public partial class SignInPage : ContentPage
{
    
	public SignInPage()
	{
		InitializeComponent();
        //BindingContext = new ViewModels.SignInViewModel();
        
	}

  

    
   

    private async void OnClickedHomeButton(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

    private void OnClickedSignIn(object sender, EventArgs e)
    {
        //if(Services.Authentication.)
    }
}