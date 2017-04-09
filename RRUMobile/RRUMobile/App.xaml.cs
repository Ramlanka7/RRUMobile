using RRUMobile.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace RRUMobile
{
	public partial class App : Application
	{
        public App()
		{
		    this.InitializeComponent();

			SetMainPage();
		}

		public static void SetMainPage()
		{
            Current.MainPage = new TabbedPage
            {
                Children =
                {
                    new NavigationPage(new ItemsPage())
                    {
                        Title = "Browse",
                        Icon = Device.OnPlatform<string>("tab_feed.png",null,null)
                    },
                    new NavigationPage(new AboutPage())
                    {
                        Title = "About",
                        Icon = Device.OnPlatform<string>("tab_about.png",null,null)
                    },
                    new NavigationPage(new ContactPage())
                    {
                        Title = "Contact",
                        Icon = Device.OnPlatform<string>("tab_contact.png",null,null)
                    },
                }
            };
        }
	}
}
