using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LifeApp
{
    public partial class MainPage : ContentPage
    {
        private void taskAdded(object sender, EventArgs e)
        {
            Entry entry = sender as Entry;
            var text = entry.Text;
            Navigation.PushAsync(new Pages.AddTask(text));
        }

        public MainPage()
		{
			InitializeComponent();
		}
	}
}