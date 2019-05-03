using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public RecipePage(string searchFor, bool flag) // false is drink
        {
            InitializeComponent();
            // Test.Text = searchFor;

            if (flag == false)
            {
                drinkFetch(searchFor);
            }
            else
            {
                foodFetch(searchFor);
            }
        }

        public async void drinkFetch(string sf)
        {
            var client = new HttpClient();
            Recipe recipe = new Recipe();

            var recipeURL = "https://www.thecocktaildb.com/api/json/v1/1/search.php?s=" + sf;
            var uri = new Uri(recipeURL);

            var response = await client.GetAsync(uri);
            var jsonContent = await response.Content.ReadAsStringAsync();

            if (jsonContent == "{\"drinks\":null}")
            {
                await DisplayAlert("Error", "No recipe found. Check spelling", "OK");
            }
            else
            {
                recipe = JsonConvert.DeserializeObject<Recipe>(jsonContent);
                RecipeListView.ItemsSource = new ObservableCollection<Dictionary<string,string>>(recipe.Drinks);

            }
            
        }

        public async void foodFetch(string sf)
        {
            var client = new HttpClient();
            Recipe recipe = new Recipe();

            var recipeURL = "https://www.themealdb.com/api/json/v1/1/search.php?s=" + sf;
            var uri = new Uri(recipeURL);

            var response = await client.GetAsync(uri);
            var jsonContent = await response.Content.ReadAsStringAsync();

            if (jsonContent == "{\"meals\":null}") // this may not be correct
            {
                await DisplayAlert("Error", "No recipe found. Check spelling", "OK");
            }
            else
            {
                recipe = JsonConvert.DeserializeObject<Recipe>(jsonContent);
                RecipeListView.ItemsSource = new ObservableCollection<Dictionary<string, string>>(recipe.Meals);
            }
        }
    }
}