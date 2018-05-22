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
            String tasktype = "Fitness";
            
            ProgressBar MainLevel = this.FindByName<ProgressBar>("MainLevel");
            ProgressBar FitnessBar = this.FindByName<ProgressBar>("FitnessBar");
            ProgressBar SocialBar = this.FindByName<ProgressBar>("SocialBar");
            ProgressBar FinancialBar = this.FindByName<ProgressBar>("FinancialBar");
            ProgressBar IntellectBar = this.FindByName<ProgressBar>("IntellectBar");
            await MainLevel.ProgressTo(MainLevel.Progress+.2, 250, Easing.Linear);
            if(tasktype == "Fitness")
            {
                if(FitnessBar.Progress>=0.85)
                {
                    double progresscalc = 1.0 - FitnessBar.Progress;
                    await FitnessBar.ProgressTo(FitnessBar.Progress + progresscalc, 100, Easing.Linear);
                    progresscalc = progresscalc / 3;
                    await IntellectBar.ProgressTo(IntellectBar.Progress - progresscalc, 100, Easing.Linear);
                    await SocialBar.ProgressTo(SocialBar.Progress - progresscalc, 100, Easing.Linear);
                    await FinancialBar.ProgressTo(FinancialBar.Progress - progresscalc, 100, Easing.Linear);

                }
                else
                {
                    await FitnessBar.ProgressTo(FitnessBar.Progress + .15, 100, Easing.Linear);
                }
                
            }
            else
            {
                await FitnessBar.ProgressTo(FitnessBar.Progress - .05, 100, Easing.Linear);
            }
            if (tasktype == "Intellect")
            {
                if (IntellectBar.Progress >= 0.85)
                {
                    double progresscalc = 1.0 - IntellectBar.Progress;
                    await IntellectBar.ProgressTo(IntellectBar.Progress + progresscalc, 100, Easing.Linear);
                    progresscalc = progresscalc / 3;
                    await FitnessBar.ProgressTo(FitnessBar.Progress - progresscalc, 100, Easing.Linear);
                    await SocialBar.ProgressTo(SocialBar.Progress - progresscalc, 100, Easing.Linear);
                    await FinancialBar.ProgressTo(FinancialBar.Progress - progresscalc, 100, Easing.Linear);

                }
                else
                {
                    await IntellectBar.ProgressTo(IntellectBar.Progress + .15, 100, Easing.Linear);
                }
               
            }
            else
            {
                await IntellectBar.ProgressTo(IntellectBar.Progress - .05, 100, Easing.Linear);
            }
            if (tasktype == "Social")
            {
                if (SocialBar.Progress >= 0.85)
                {
                    double progresscalc = 1.0 - SocialBar.Progress;
                    await SocialBar.ProgressTo(SocialBar.Progress + progresscalc, 100, Easing.Linear);
                    progresscalc = progresscalc / 3;
                    await IntellectBar.ProgressTo(IntellectBar.Progress - progresscalc, 100, Easing.Linear);
                    await FitnessBar.ProgressTo(FitnessBar.Progress - progresscalc, 100, Easing.Linear);
                    await FinancialBar.ProgressTo(FinancialBar.Progress - progresscalc, 100, Easing.Linear);

                }
                else
                {
                    await SocialBar.ProgressTo(SocialBar.Progress + .15, 100, Easing.Linear);
                }
                
            }
            else
            {
                await SocialBar.ProgressTo(SocialBar.Progress - .05, 100, Easing.Linear);
            }
            if (tasktype == "Financial")
            {
                if (FinancialBar.Progress >= 0.85)
                {
                    double progresscalc = 1.0 - FitnessBar.Progress;
                    await FinancialBar.ProgressTo(FinancialBar.Progress + progresscalc, 100, Easing.Linear);
                    progresscalc = progresscalc / 3;
                    await IntellectBar.ProgressTo(IntellectBar.Progress - progresscalc, 100, Easing.Linear);
                    await SocialBar.ProgressTo(SocialBar.Progress - progresscalc, 100, Easing.Linear);
                    await FitnessBar.ProgressTo(FitnessBar.Progress - progresscalc, 100, Easing.Linear);

                }
                else
                {
                    await FinancialBar.ProgressTo(FinancialBar.Progress + .15, 100, Easing.Linear);
                }
                
            }
            else
            {
                await FinancialBar.ProgressTo(FinancialBar.Progress - .05, 100, Easing.Linear);
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
