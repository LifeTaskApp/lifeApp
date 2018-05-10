using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace LifeApp
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new Shop())); // opens new Shop in NavigationPage container.
        }

    }
}
