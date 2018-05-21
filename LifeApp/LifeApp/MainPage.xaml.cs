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
        public MainPage()
        {
            InitializeComponent();

        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            Label User = this.FindByName<Label>("User");
            User.Text = "Calvin";
            Label Level = this.FindByName<Label>("Level");
            String tasktype1 = "Fitness";
            String tasktype2 = "Social";
            
            ProgressBar MainLevel = this.FindByName<ProgressBar>("MainLevel");
            ProgressBar FitnessBar = this.FindByName<ProgressBar>("FitnessBar");
            ProgressBar SocialBar = this.FindByName<ProgressBar>("SocialBar");
            ProgressBar FinancialBar = this.FindByName<ProgressBar>("FinancialBar");
            ProgressBar IntellectBar = this.FindByName<ProgressBar>("IntellectBar");
            await MainLevel.ProgressTo(MainLevel.Progress+.2, 250, Easing.Linear);
            if(tasktype1 == "Fitness" || tasktype2 == "Fitness")
            {
                await FitnessBar.ProgressTo(FitnessBar.Progress+ .1, 100, Easing.Linear);
            }
            else
            {
                await FitnessBar.ProgressTo(FitnessBar.Progress - .1, 100, Easing.Linear);
            }
            if (tasktype1 == "Intellect" || tasktype2 == "Intellect")
            {
                await IntellectBar.ProgressTo(IntellectBar.Progress + .1, 100, Easing.Linear);
            }
            else
            {
                await IntellectBar.ProgressTo(IntellectBar.Progress - .1, 100, Easing.Linear);
            }
            if (tasktype1 == "Social" || tasktype2 == "Social")
            {
                await SocialBar.ProgressTo(SocialBar.Progress + .1, 100, Easing.Linear);
            }
            else
            {
                await SocialBar.ProgressTo(SocialBar.Progress - .1, 100, Easing.Linear);
            }
            if (tasktype1 == "Financial" || tasktype2 == "Financial")
            {
                await FinancialBar.ProgressTo(FinancialBar.Progress + .1, 100, Easing.Linear);
            }
            else
            {
                await FinancialBar.ProgressTo(FinancialBar.Progress - .1, 100, Easing.Linear);
            }
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

    }


}
