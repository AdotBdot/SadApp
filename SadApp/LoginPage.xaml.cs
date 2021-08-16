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
            InitializeComponent();
        }

        //TODO: Login in
        async void LoginBtn_OnClick(object sender, EventArgs args)
        {
        }
    }
}