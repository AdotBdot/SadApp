using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SadApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        //TODO: Login in
        async void LoginBtn_OnClick(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new MainPage());
            Navigation.RemovePage(this);
        }
    }
}