using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace deadwood_app.ViewModels
{
    class PickerClass : ContentPage
    {
        public void AddPicker(StackLayout stack, List<string> List, int max)
        {
            // Takes in a list of element children, a list of items, and the max number of entries
            if (stack.Children.Count < max - 1)
            // Prevents user adding too many options
            {
                Picker picker = new Picker { Title = "Tap to select option", Style = (Style)Application.Current.Resources["Picker"] };
                picker.ItemsSource = List;
                stack.Children.Add(picker);
            }
        }

        public void RemovePicker(StackLayout stack, Picker picker)
        {
            if(stack.Children.Count > 0)
            {
                stack.Children.RemoveAt(stack.Children.Count - 1);
            } else
            {
                picker.SelectedIndex = -1;
            }
        }

    }
}
