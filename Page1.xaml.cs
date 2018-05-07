using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LifeApp.w1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}

        static string bomb = new Random().Next(1, 4).ToString();

        async void ButtonClicked(object userButton, EventArgs e)
        {
            Button button = userButton as Button;

            if (button.Text == bomb) //game over
            {
                await DisplayAlert("Bomb exploded", "Game Over", "Retry");
                bomb = new Random().Next(1, 4).ToString();
            }

        }
    }
}