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
	public partial class RecipePage : ContentPage
	{
		public RecipePage ()
		{
			InitializeComponent ();
		}

        public RecipePage (string searchFor)
        {
            InitializeComponent ();
            Test.Text = searchFor;
        }
	}
}