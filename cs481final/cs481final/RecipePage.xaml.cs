using cs481final.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cs481final
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RecipePage : ContentPage
	{
		public RecipePage ()
		{
			InitializeComponent ();
		}

        public RecipePage(string searchFor) // false is drink
        {
            InitializeComponent();

            foodFetch(searchFor);
        }

        public async void foodFetch(string sf)
        {
            var client = new HttpClient();
            Recipe recipe = new Recipe();

            var recipeURL = "https://www.themealdb.com/api/json/v1/1/search.php?s=" + sf;
            var uri = new Uri(recipeURL);

            var response = await client.GetAsync(uri);
            var jsonContent = await response.Content.ReadAsStringAsync();

            if (jsonContent == "{\"meals\":null}") 
            {
                await DisplayAlert("Error", "No recipe found. Possibly check spelling", "OK");
            }
            else
            {

                recipe = JsonConvert.DeserializeObject<Recipe>(jsonContent);
                // pick first then show recipe?

                
                RecipeListView.ItemsSource = new ObservableCollection<Meal>(recipe.Meals);
            }
        }
        private async void RecipeListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListView lv = (ListView)sender;
            Meal meal = lv.SelectedItem as Meal;
            await Navigation.PushAsync(new FullMealPage(meal));
        }
    }
}