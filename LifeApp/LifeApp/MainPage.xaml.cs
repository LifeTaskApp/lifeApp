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

        async void OnButtonClicked(object sender, EventArgs args)
        {
            Label User = this.FindByName<Label>("User");
            User.Text = "Calvin";
            Label Level = this.FindByName<Label>("Level");
            
            
            ProgressBar MainLevel = this.FindByName<ProgressBar>("MainLevel");
            await MainLevel.ProgressTo(MainLevel.Progress+.2, 250, Easing.Linear);
            if (MainLevel.Progress == 1)
            {
                User.Text = "Level up";
                int convertLevelInt = Convert.ToInt32(Level.Text);
                convertLevelInt++;
                String convertLevelString = Convert.ToString(convertLevelInt);
                Level.Text = convertLevelString;
                await MainLevel.ProgressTo(0, 250, Easing.Linear);
            }
            User.Text = "Name";

        }
        
        public MainPage()
		{
			InitializeComponent();
		}

    }