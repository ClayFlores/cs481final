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

        private void Find_Food_Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}