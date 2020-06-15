using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace deadwood_app.Views
{
    public partial class App : Application
    {
        public App()
        {
            try
            {
                InitializeComponent();
            } catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            MainPage = new SplashScreen();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
