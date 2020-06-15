using deadwood_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using deadwood_app.Models;
using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;
using System.Text.RegularExpressions;

namespace deadwood_app.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Survey1 : ContentPage
    {
        Survey survey;
        public Survey1(Survey s)
        {
            InitializeComponent();
            survey = s;
        }


        private void BtnNext_Clicked(object sender, EventArgs e)
        {

            // Part of environment group
            var enviroGroup = (string)PickerEnvGroup.SelectedItem;
            if (enviroGroup == "Yes")
            {
                survey.enviroGroup = true;
            }
            else if (enviroGroup == "No")
            {
                survey.enviroGroup = false;
            }

            // Done environment survey before
            var enviroSurvey = (string)PickerSurveyBefore.SelectedItem;
            if (enviroGroup == "Yes")
            {
                survey.performedSurveyBefore = true;
            }
            else if (enviroGroup == "No")
            {
                survey.performedSurveyBefore = false;
            }

            // Name of woodland
            survey.woodlandName = (string)TxtWoodland.Text;

            // Location
            if (LblLocation.Text != null)
            {
                string[] location = LblLocation.Text.Split(' ');
                survey.longitude = location[0];
                survey.latitude = location[1];
            }

            // Grid ref
            survey.gridRef = (string)TxtGrid.Text;

            // Size of woodland
            if((string)TxtSize.Text != null) {
                survey.woodlandSize = Double.Parse((string)TxtSize.Text);
            }

            Navigation.PushAsync(new Survey2(survey));

        }

        private async void BtnLocation_ClickedAsync(object sender, EventArgs e)
        {

            LblLocation.Text = "Loading, please wait...";
            var locatorObj = CrossGeolocator.Current;
            try
            {
                var position = await locatorObj.GetPositionAsync(TimeSpan.FromSeconds(30));
                var lat = position.Latitude;
                var lon = position.Longitude;
                LblLocation.Text = lon + " " + lat;
            }
            catch (Exception ex)
            {
                LblLocation.Text = "Cannot find you, please enable your location";
            }
        }
    }
}