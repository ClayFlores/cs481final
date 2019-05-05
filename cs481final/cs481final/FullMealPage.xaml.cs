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
	public partial class FullMealPage : ContentPage
	{
		public FullMealPage ()
		{
			InitializeComponent ();
		}

        public FullMealPage(Meal meal)
        {
            InitializeComponent();

            img.Source = meal.strMealThumb;
            title.Text = meal.strMeal;
            ing1.Text = meal.strIngredient1;
            ing2.Text = meal.strIngredient2;
            ing3.Text = meal.strIngredient3;
            ing4.Text = meal.strIngredient4;
            ing5.Text = meal.strIngredient5;
            ing6.Text = meal.strIngredient6;
            ing7.Text = meal.strIngredient7;
            ing8.Text = meal.strIngredient8;
            ing9.Text = meal.strIngredient9;
            //ing10.Text = meal.strIngredient10;
            //ing11.Text = meal.strIngredient11;
            //ing12.Text = meal.strIngredient12;
            //ing13.Text = meal.strIngredient13;
            //ing14.Text = meal.strIngredient14;
            //ing15.Text = meal.strIngredient15;



            mea1.Text = meal.strMeasure1;
            mea2.Text = meal.strMeasure2;
            mea3.Text = meal.strMeasure3;
            mea4.Text = meal.strMeasure4;
            mea5.Text = meal.strMeasure5;
            mea6.Text = meal.strMeasure6;
            mea7.Text = meal.strMeasure7;
            mea8.Text = meal.strMeasure8;
            mea9.Text = meal.strMeasure9;
            //mea10.Text = meal.strMeasure10;
            //mea11.Text = meal.strMeasure11;
            //mea12.Text = meal.strMeasure12;
            //mea13.Text = meal.strMeasure13;
            //mea14.Text = meal.strMeasure14;
            //mea15.Text = meal.strMeasure15;

            instr.Text = meal.strInstructions;
        }
	}
}