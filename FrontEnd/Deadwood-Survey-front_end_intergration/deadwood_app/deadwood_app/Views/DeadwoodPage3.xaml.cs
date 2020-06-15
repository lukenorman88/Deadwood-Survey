using deadwood_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace deadwood_app.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DeadwoodPage3 : ContentPage
	{
		public DeadwoodPage3 ()
		{
			InitializeComponent ();
		}

        private void PaceButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DeadwoodPage4());
        }

        private void OldAgeButton_Clicked(object sender, EventArgs e)
        {
            Survey s = new Survey();
            Navigation.PushAsync(new Survey2(s));
        }

        private void SurveyResultsButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DeadwoodPage5());
        }
    }
}