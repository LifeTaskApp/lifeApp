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
        public class UserInfo
        { 
            public string userName { get; set; }
            public int level { get; set; }
        }

        private void setTestUser()
        {
            var testUser = new UserInfo();
            testUser.userName = "Calvin";
            testUser.level = 3;
        }
        
        async void OnButtonClicked(object sender, EventArgs args)
        {
            setTestUser();


            Label Level = this.FindByName<Label>("Level");
            int convertLevelInt = Convert.ToInt32(Level.Text);
            //convertLevelInt = testUser.level;
            String convertLevelString = Convert.ToString(convertLevelInt);
            Level.Text = convertLevelString;
            Label User = this.FindByName<Label>("User");
            ProgressBar MainLevel = this.FindByName<ProgressBar>("MainLevel");
            await MainLevel.ProgressTo(1, 250, Easing.Linear);
            User.Text = "Level up";
            //testUser.level++;
            await MainLevel.ProgressTo(0, 250, Easing.Linear);
            User.Text = "Name";
        }

        public MainPage()
        {
            InitializeComponent();
            setTestUser();
        }
    }
}


