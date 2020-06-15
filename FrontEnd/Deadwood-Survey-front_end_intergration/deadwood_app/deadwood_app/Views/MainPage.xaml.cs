using deadwood_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using deadwood_app.Models;

namespace deadwood_app.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SurveyButton_Clicked(object sender, EventArgs e)
        {
            Survey survey = new Survey();
            Navigation.PushAsync(new Survey1(survey));
        }

        private void DeadwoodGuideButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DeadwoodGuideTabs());
        }

        private void ContactButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Contact());
        }
    }
}
