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
    public partial class Survey2 : ContentPage
    {
        Survey survey;
        public Survey2(Survey s)
        {
            InitializeComponent();
            survey = s;
        }

        private void BtnNext_Clicked(object sender, EventArgs e)
        {
            // Wood standing or lying
            survey.deadwoodStandingOrLying = (string)PickerWoodStatus.SelectedItem;

            // Wood diameter
            if (TxtDiameter.Text != null)
            {
                survey.deadwoodDiameter = Double.Parse(TxtDiameter.Text);
            }

            //Wood length
            if (TxtLength.Text != null)
            {
                survey.deadwoodLength = Double.Parse(TxtLength.Text);
            }

            // Species
            survey.deadwoodSpecies = TxtSpecies.Text;


            Navigation.PushAsync(new Survey3(survey));
        }
    }
}