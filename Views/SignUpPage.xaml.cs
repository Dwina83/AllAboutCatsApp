namespace AllAboutCatsApp.Views;

public partial class SignUpPage : ContentPage
{
    public Models.Users User { get; set; }
	public SignUpPage(Models.Users user)
	{
		InitializeComponent();
        User = user;

        if (user != null)
        {
            FullnameSignUpEntry.Text = user.FullName;
            EmailSignUpEntry.Text = user.Email;
            PasswordSignUpEntry.Text = user.Password;

        }
        

	}

   
    private async void OnClickedHomeButton(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

    private async void OnClickedSignUp(object sender, EventArgs e)
    {
        Models.Users users = new Models.Users()
        { 
           Id = Guid.NewGuid(),
           FullName = FullnameSignUpEntry.Text,
           Email = EmailSignUpEntry.Text, 
           Password = PasswordSignUpEntry.Text

        };
        await Data.DB.UserCollection().InsertOneAsync(users);
        await Navigation.PushAsync(new SignInPage());
    }
}