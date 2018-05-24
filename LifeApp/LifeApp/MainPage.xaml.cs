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

        private void viewAllTasks(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.ViewTasks());
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            Label username = this.FindByName<Label>("username");
            Label levelLabel = this.FindByName<Label>("userLevel");
            ProgressBar userLevelBar = this.FindByName<ProgressBar>("userLevelBar");

            await userLevelBar.ProgressTo(userLevelBar.Progress + .2, 250, Easing.Linear);

            if (userLevelBar.Progress == 1)
            {
                username.Text = "Level Up!";
                int convertLevelInt = Convert.ToInt32(levelLabel.Text);
                convertLevelInt++;
                String convertLevelString = Convert.ToString(convertLevelInt);
                levelLabel.Text = convertLevelString;
                await userLevelBar.ProgressTo(0, 250, Easing.Linear);
            }
        }

        public MainPage()
        {
            InitializeComponent();
            Label username = this.FindByName<Label>("username");
            username.Text = "Calvin";
        }

    }
}