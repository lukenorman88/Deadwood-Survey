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
    public partial class Contact : ContentPage
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void BtnEmail_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("mailto:information@tcv.org.uk?subject=Mail from TCV app"));
        }

        private void BtnVolunteer_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://tcv.org.uk/volunteer"));
        }

        private void BtnCall_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel:01786479697"));
        }

        private void BtnTwitter_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://twitter.com/TCVtweets"));
        }

        private void BtnAbout_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.tcv.org.uk/about"));
        }

        private void BtnFacebook_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.facebook.com/TheConservationVolunteers/"));
        }
    }
}