using cs481final.Models;
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
    public partial class DrinkRecipePage : ContentPage
    {
        public DrinkRecipePage()
        {
            InitializeComponent();
        }
        public DrinkRecipePage(string searchFor)
        {
            InitializeComponent();

            drinkFetch(searchFor);
        }

        public async void drinkFetch(string sf)
        {
            var client = new HttpClient();
            DrinkRecipe recipe = new DrinkRecipe();

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
                recipe = JsonConvert.DeserializeObject<DrinkRecipe>(jsoncontent);
                DrinkRecipeListView.ItemsSource = new ObservableCollection<Drink>(recipe.Drinks);
            }

        }

        //public async void Handle_Clicked(object sender, System.EventArgs e)
        //{
        //    var menuItem = (MenuItem)sender;
        //    var drink = (Drink)menuItem.CommandParameter;
        //    await Navigation.PushAsync(new FullDrinkPage(drink));
        //}

        public async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ListView lv = (ListView)sender;
            Drink drink = lv.SelectedItem as Drink;
            await Navigation.PushAsync(new FullDrinkPage(drink));
        }

        private async void DrinkRecipeListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListView lv = (ListView)sender;
            Drink drink = lv.SelectedItem as Drink;
            await Navigation.PushAsync(new FullDrinkPage(drink));
        }
    }
}