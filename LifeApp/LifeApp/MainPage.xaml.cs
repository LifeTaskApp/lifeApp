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
            Label Level = this.FindByName<Label>("Level");
            Convert.ToInt32(Level.Text);
            Label User = this.FindByName<Label>("User");
            ProgressBar MainLevel = this.FindByName<ProgressBar>("MainLevel");
            await MainLevel.ProgressTo(1, 250, Easing.Linear);
            User.Text = "Level up";
            await MainLevel.ProgressTo(0, 250, Easing.Linear);
            User.Text = "Name";

        }

    }


}
