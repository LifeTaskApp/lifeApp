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

        async void levelUp(object sender, EventArgs args)
        {   //our levelling up test system
            Label name = this.FindByName<Label>("username");
            Label levelLabel = this.FindByName<Label>("userLevel");
            ProgressBar levelBar = this.FindByName<ProgressBar>("userLevelBar");

            //increases our progress bar as task is completed
            await levelBar.ProgressTo(levelBar.Progress + .2, 250, Easing.Linear);

            //checks for full progress bar for a level up
            if (levelBar.Progress == 1)
            {
                name.Text = "Level Up!";

                int convertLevelInt = Convert.ToInt32(levelLabel.Text);
                convertLevelInt++;

                String convertLevelString = Convert.ToString(convertLevelInt);
                levelLabel.Text = convertLevelString;

                await levelBar.ProgressTo(0, 250, Easing.Linear);
            }
        }

        public MainPage()
        {   
            InitializeComponent();

            //initisalised a test user as we have not set up login
            Label name = this.FindByName<Label>("username");
            name.Text = "Bob";
        }

    }
}