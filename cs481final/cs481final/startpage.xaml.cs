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
	public partial class startpage : ContentPage
	{
		public startpage ()
		{
			InitializeComponent ();
		}
        private async void Food_Button_Clicked(object sender, EventArgs e)
        {
            //await DisplayAlert("Food Button","Clicked!","Sounds Good", "cancel"); // reminder: CAN DO 3 ARG OR 4
            await Navigation.PushAsync(new FoodPickPage());

        }

        private async void Drink_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DrinkPickPage());
        }
    }
}