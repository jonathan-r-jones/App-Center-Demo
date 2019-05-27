using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Buster
{
	public partial class App : Application
	{
		
		public App ()
		{
			InitializeComponent();
			MainPage = new Views.MainPage();
		}

		protected override void OnStart ()
		{
            // Handle when your app starts
            AppCenter.Start("android=f8006ffa-91da-484a-afce-19e530d3d50c;" + "uwp={Your UWP App secret here};" + "ios=d595c25f-8329-4cbd-8869-939bd9e119f6;", typeof(Analytics), typeof(Crashes));
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}