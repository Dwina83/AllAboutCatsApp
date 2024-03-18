using AllAboutCatsApp.Views;
using MongoDB.Driver;

namespace AllAboutCatsApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnAdminIconClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdminPage());
        }

        //public async void OnUserIconClicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new SignInPage());
        //}

        //private async void OnSignUpClicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new SignUpPage(null));
        //}

       
    }
}
