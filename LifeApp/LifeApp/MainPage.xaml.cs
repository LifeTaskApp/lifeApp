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
            double progression_main = 0.15;
            double progression_sub = 0.05;
            double progression_calc = 0.0;
            if(tasktype == "Fitness")
            {
                if (FitnessBar.Progress >= 0.85)
                {
                    progression_main = 1.0 - FitnessBar.Progress;
                    progression_sub = progression_main / 3;
                }
                if(IntellectBar.Progress <=progression_sub)
                {
                    progression_calc = progression_sub - IntellectBar.Progress;
                    progression_sub = progression_sub + (progression_calc / 2);
                }
                if (SocialBar.Progress <= progression_sub)
                {
                    progression_calc = progression_sub - SocialBar.Progress;
                    progression_sub = progression_sub + (progression_calc / 2);
                }
                if (FinancialBar.Progress <= progression_sub)
                {
                    progression_calc = progression_sub - FinancialBar.Progress;
                    progression_sub = progression_sub + (progression_calc / 2);
                }
                await IntellectBar.ProgressTo(IntellectBar.Progress - progression_sub, 100, Easing.Linear);
                await SocialBar.ProgressTo(SocialBar.Progress - progression_sub, 100, Easing.Linear);
                await FinancialBar.ProgressTo(FinancialBar.Progress - progression_sub, 100, Easing.Linear);
                await FitnessBar.ProgressTo(FitnessBar.Progress + progression_main, 100, Easing.Linear);   
            }
            else if (tasktype == "Intellect")
            {
                if (IntellectBar.Progress >= 0.85)
                {
                    progression_main = 1.0 - IntellectBar.Progress;
                    progression_sub = progression_main / 3;
                }
                if (FitnessBar.Progress <= progression_sub)
                {
                    progression_calc = progression_sub - FitnessBar.Progress;
                    progression_sub = progression_sub + (progression_calc / 2);
                }
                if (SocialBar.Progress <= progression_sub)
                {
                    progression_calc = progression_sub - SocialBar.Progress;
                    progression_sub = progression_sub + (progression_calc / 2);
                }
                if (FinancialBar.Progress <= progression_sub)
                {
                    progression_calc = progression_sub - FinancialBar.Progress;
                    progression_sub = progression_sub + (progression_calc / 2);
                }
                await FitnessBar.ProgressTo(FitnessBar.Progress - progression_sub, 100, Easing.Linear);
                await SocialBar.ProgressTo(SocialBar.Progress - progression_sub, 100, Easing.Linear);
                await FinancialBar.ProgressTo(FinancialBar.Progress - progression_sub, 100, Easing.Linear);
                await IntellectBar.ProgressTo(IntellectBar.Progress + progression_main, 100, Easing.Linear);
            }
            else if (tasktype == "Social")
            {
                if (SocialBar.Progress >= 0.85)
                {
                    progression_main = 1.0 - SocialBar.Progress;
                    progression_sub = progression_main / 3;
                }
                if (IntellectBar.Progress <= progression_sub)
                {
                    progression_calc = progression_sub - IntellectBar.Progress;
                    progression_sub = progression_sub + (progression_calc / 2);
                }
                if (FitnessBar.Progress <= progression_sub)
                {
                    progression_calc = progression_sub - FitnessBar.Progress;
                    progression_sub = progression_sub + (progression_calc / 2);
                }
                if (FinancialBar.Progress <= progression_sub)
                {
                    progression_calc = progression_sub - FinancialBar.Progress;
                    progression_sub = progression_sub + (progression_calc / 2);
                }
                await IntellectBar.ProgressTo(IntellectBar.Progress - progression_sub, 100, Easing.Linear);
                await FitnessBar.ProgressTo(FitnessBar.Progress - progression_sub, 100, Easing.Linear);
                await FinancialBar.ProgressTo(FinancialBar.Progress - progression_sub, 100, Easing.Linear);
                await SocialBar.ProgressTo(SocialBar.Progress + progression_main, 100, Easing.Linear);
            }
            else
            {
                if (FinancialBar.Progress >= 0.85)
                {
                    progression_main = 1.0 - FinancialBar.Progress;
                    progression_sub = progression_main / 3;
                }
                if (IntellectBar.Progress <= progression_sub)
                {
                    progression_calc = progression_sub - IntellectBar.Progress;
                    progression_sub = progression_sub + (progression_calc / 2);
                }
                if (SocialBar.Progress <= progression_sub)
                {
                    progression_calc = progression_sub - SocialBar.Progress;
                    progression_sub = progression_sub + (progression_calc / 2);
                }
                if (FitnessBar.Progress <= progression_sub)
                {
                    progression_calc = progression_sub - FitnessBar.Progress;
                    progression_sub = progression_sub + (progression_calc / 2);
                }
                await IntellectBar.ProgressTo(IntellectBar.Progress - progression_sub, 100, Easing.Linear);
                await SocialBar.ProgressTo(SocialBar.Progress - progression_sub, 100, Easing.Linear);
                await FitnessBar.ProgressTo(FitnessBar.Progress - progression_sub, 100, Easing.Linear);
                await FinancialBar.ProgressTo(FinancialBar.Progress + progression_main, 100, Easing.Linear);
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
