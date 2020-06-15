using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using deadwood_app.ViewModels;
using deadwood_app.Models;

namespace deadwood_app.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Survey3 : ContentPage
    {
        // instantiates the picker class to make use of it's create and remove methods
        PickerClass p = new PickerClass();
        List<Picker> ListGrowing = new List<Picker>();

        Survey survey;
        public Survey3(Survey s)
        {
            InitializeComponent();
            survey = s;
        }

        private void BtnAddGrowing_Clicked(object sender, EventArgs e)
        {
            // Max number of elements
            int max = 6;

            // Create new picker and add to Stack Layout
            List<string> list = new List<string>
            {
                "Moss",
                "Lichen",
                "Fern",
                "Ivy",
                "Bracket Fungus",
                "Toadstool"
            };

            if (StackGrowing.Children.Count < max - 1)
            {
                p.AddPicker(StackGrowing, list, max);
            }
            else
            {
                DisplayAlert("Oops", "Only " + max + " items can be added", "OK");
            }
        }

        private void BtnRemoveGrowing_Clicked(object sender, EventArgs e)
        {
            p.RemovePicker(StackGrowing, PickGrowing);
        }

        private void BtnAddAnimal_Clicked(object sender, EventArgs e)
        {
            int max = 4;
            // Create new picker and add to Stack Layout
            List<string> list = new List<string> {
                "Spiders",
                "Birds",
                "Robber Flies",
                "Other"
            };

            // Adds picker to the screen
            if (StackAnimals.Children.Count < max - 1)
            {
                p.AddPicker(StackAnimals, list, max);
            }
            else
            {
                DisplayAlert("Oops", "Only " + max + " items can be added", "OK");
            }
        }

        private void BtnRemoveAnimal_Clicked(object sender, EventArgs e)
        {
            p.RemovePicker(StackAnimals, PickAnimals);
        }

        private void BtnNext_Clicked(object sender, EventArgs e)
        {
            // Holes in deadwood
            survey.holesInDeadwood = (string)PickWoodHoles.SelectedItem;

            // Adds comma separated string of items growing on the deadwood
            List<string> GrowingOnDeadWoodList = new List<string>() { (string)PickGrowing.SelectedItem };
            foreach (Picker item in StackGrowing.Children)
            {
                GrowingOnDeadWoodList.Add(item.SelectedItem.ToString());
            }
            string GrowingOnDeadWood = string.Join(", ", GrowingOnDeadWoodList);
            survey.floraOnDeadwood = GrowingOnDeadWood;


            // Adds comma separated string of animals on the deadwood
            List<string> AnimalsOnDeadWoodList = new List<string>() { (string)PickAnimals.SelectedItem };
            foreach (Picker item in StackAnimals.Children)
            {
                AnimalsOnDeadWoodList.Add(item.SelectedItem.ToString());
            }
            string AnimalsOnDeadWood = string.Join(", ", AnimalsOnDeadWoodList);
            Console.WriteLine("ANIMALS ON DEADWOOD: " + AnimalsOnDeadWood);
            survey.faunaInDeadwood = AnimalsOnDeadWood;

            Navigation.PushAsync(new Survey4(survey));
        }
    }
}