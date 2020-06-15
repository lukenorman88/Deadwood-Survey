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
	public partial class DeadwoodGuideMainPage : ContentPage
	{
		public DeadwoodGuideMainPage ()
		{
			InitializeComponent ();
		}

        private void DeadwoodPage1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DeadwoodGuideTabs(new DeadwoodPage1()));
            
        }

        private void DeadwoodPage2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DeadwoodGuideTabs(new DeadwoodPage2()));
        }

        private void DeadwoodPage3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DeadwoodGuideTabs(new DeadwoodPage3()));
        }

        private void DeadwoodPage4_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DeadwoodGuideTabs(new DeadwoodPage4()));
        }
    }
}