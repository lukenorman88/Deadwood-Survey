using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using deadwood_app.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using deadwood_app.ViewModels;
using deadwood_app.Models;

namespace deadwood_app.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Survey4 : ContentPage
    {
        // instantiates the picker class to make use of it's create and remove methods
        PickerClass p = new PickerClass();

        Survey survey;
        public Survey4(Survey s)
        {
            InitializeComponent();
            survey = s;
        }

        private void BtnAddInside_Clicked(object sender, EventArgs e)
        {
            // Max amount of elements that can be added
            int max = 4;

            // Creates list to pass to the add picker method
            List<string> list = new List<string>
            {
                "Centipedes",
                "Woodlice",
                "Ground Beetles",
                "Other"
            };

            // Adds Picker to the screen
            if (StackInside.Children.Count < max - 1)
            {
                p.AddPicker(StackInside, list, max);
            }
            else
            {
                DisplayAlert("Oops", "Only " + max + " items can be added", "OK");
            }
        }

        private void BtnRemoveInside_Clicked(object sender, EventArgs e)
        {
            p.RemovePicker(StackInside, PickInside);
        }

        private async void BtnSubmit_Clicked(object sender, EventArgs e)
        {
            // Pencil test
            if(TxtHowDeep.Text != null) {
                survey.pencilDepth = Double.Parse(TxtHowDeep.Text);
            }

            // How soft is the deadwood
            survey.deadwoodSoftness = (string)PickHowSoft.SelectedItem;

            // Adds comma separated string of animals inside the deadwood
            List<string> AnimalsInDeadWoodList = new List<string>() { (string)PickInside.SelectedItem };
            foreach (Picker item in StackInside.Children)
            {
                AnimalsInDeadWoodList.Add((string)item.SelectedItem);
            }
            string AnimalsInDeadWood = string.Join(", ", AnimalsInDeadWoodList);
            Console.WriteLine("ANIMALS ON DEADWOOD: " + AnimalsInDeadWood);
            survey.faunaOnDeadwood = AnimalsInDeadWood;

            // Deadwood colour
            survey.deadwoodColour = (string)PickColour.SelectedItem;

            // Decay
            if(PickDecay.SelectedIndex >= 0) {
                survey.deadwoodDecay = int.Parse((string)PickDecay.SelectedItem);
            }


            // Will submit final survey
            bool result = await DisplayAlert("Are you sure?", "Would you like to submit your survey? You cannot go back and change it once you do", "Submit", "Cancel");
            if (result)
            {
                LblSendingMessage.Text = "Sending, please wait...";
                //test for net connection
                while (true) {
                    ConnectionValidator connectionValidator = new ConnectionValidator();

                    if (connectionValidator.CheckForInternetConnection()) {
                        Sender surveySender = new Sender();
                        await surveySender.RunAsync(survey);
                        break;
                    }

                    System.Threading.Thread.Sleep(5000);
                }

                bool thanks = await DisplayAlert("Thank you", "Thank you for completing the dead good deadwood survey! Feel free to complete more surveys", "OK", "Cancel");
                if (thanks || !thanks)
                {
                    await Navigation.PopToRootAsync();
                }
            }


        }
    }
}