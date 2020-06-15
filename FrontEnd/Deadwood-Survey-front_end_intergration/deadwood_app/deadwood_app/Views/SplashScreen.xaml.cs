using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using deadwood_app.Models;
using Plugin.Geolocator.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace deadwood_app.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SplashScreen : ContentPage
	{
		public SplashScreen ()
		{
			InitializeComponent ();

            

		}

       protected async override void OnAppearing()
        {
            // Moves to the main menu after 5 seconds
            base.OnAppearing();
            await Task.Delay(5000);


            //call sender class
            //Sender s = new Sender();
            //await s.RunAsync();

            App.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}