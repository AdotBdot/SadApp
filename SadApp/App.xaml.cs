using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace SadApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            NavigationPage page = new NavigationPage(new LoginPage());

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}