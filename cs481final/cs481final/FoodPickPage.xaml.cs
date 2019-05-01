using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cs481final
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FoodPickPage : ContentPage
	{
		public FoodPickPage ()
		{
			InitializeComponent ();
		}

        private async void Find_Food_Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(itemToSearch.Text))
            {
                await DisplayAlert("Error", "Please enter a food item to search for", "Ok");
            }
            else
                await Navigation.PushAsync(new RecipePage(itemToSearch.Text, true));
        }
    }
}