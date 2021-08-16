using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SadApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            CurrentPage = Children[2];
        }
    }
}