using cs481final.Models;
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
	public partial class FullDrinkPage : ContentPage
	{
		public FullDrinkPage ()
		{
			InitializeComponent ();
		}

        public FullDrinkPage(Drink drink)
        {
            InitializeComponent();
            BindingContext = drink;

            // normal binding was not showing anything, will come back if there is time

            //img.Source = drink.strDrinkThumb;
            //title.Text = drink.strDrink;
            //ing1.Text = drink.strIngredient1;
            //ing2.Text = drink.strIngredient2;
            //ing3.Text = drink.strIngredient3;
            //ing4.Text = drink.strIngredient4;
            //ing5.Text = drink.strIngredient5;
            //ing6.Text = drink.strIngredient6;
            //ing7.Text = drink.strIngredient7;
            //ing8.Text = drink.strIngredient8;
            //ing9.Text = drink.strIngredient9;
            ////ing10.Text = drink.strIngredient10;
            ////ing11.Text = drink.strIngredient11;
            ////ing12.Text = drink.strIngredient12;
            ////ing13.Text = drink.strIngredient13;
            ////ing14.Text = drink.strIngredient14;
            ////ing15.Text = drink.strIngredient15;



            //mea1.Text = drink.strMeasure1;
            //mea2.Text = drink.strMeasure2;
            //mea3.Text = drink.strMeasure3;
            //mea4.Text = drink.strMeasure4;
            //mea5.Text = drink.strMeasure5;
            //mea6.Text = drink.strMeasure6;
            //mea7.Text = drink.strMeasure7;
            //mea8.Text = drink.strMeasure8;
            //mea9.Text = drink.strMeasure9;
            ////mea10.Text = drink.strMeasure10;
            ////mea11.Text = drink.strMeasure11;
            ////mea12.Text = drink.strMeasure12;
            ////mea13.Text = drink.strMeasure13;
            ////mea14.Text = drink.strMeasure14;
            ////mea15.Text = drink.strMeasure15;

            //instr.Text = drink.strInstructions;
        }
	}
}