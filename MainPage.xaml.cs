using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LifeApp.w1
{
	public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
			InitializeComponent();

            this.BindingContext = new[] { "a", "b", "c" };

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

        void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e == null) return; // has been set to null, do not 'process' tapped event
            Console.WriteLine("Tapped: " + e.Item);
            ((ListView)sender).SelectedItem = null; // de-select the row
        }
    }
}
