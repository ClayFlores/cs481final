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

            var recipeurl = "https://www.thecocktaildb.com/api/json/v1/1/search.php?s=" + sf;
            var uri = new Uri(recipeurl);

            var response = await client.GetAsync(uri);
            var jsoncontent = await response.Content.ReadAsStringAsync();

            if (jsoncontent == "{\"drinks\":null}")
            {
                await DisplayAlert("error", "no recipe found. check spelling", "ok");
            }
            else
            {
                recipe = JsonConvert.DeserializeObject<Recipe>(jsoncontent);
                //RecipeListView.ItemsSource = new ObservableCollection<string>(recipe.Drinks.Values);

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

            if (jsonContent == "{\"meals\":null}") 
            {
                await DisplayAlert("Error", "No recipe found. Possibly check spelling", "OK");
            }
            else
            {

                recipe = JsonConvert.DeserializeObject<Recipe>(jsonContent);
                // pick first then show recipe?

                
                RecipeListView.ItemsSource = new ObservableCollection<Meal>(recipe.Meals);
                

                //StockListView.ItemsSource = new ObservableCollection<TimeSeriesDaily>(stockData.TSD.Values)
                // array of dictionaries?

                //recipe.Meals["mealStr"];
            }
        }
    }
}