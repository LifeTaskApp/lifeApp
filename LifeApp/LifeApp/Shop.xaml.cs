using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LifeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Shop : TabbedPage
    {

        public Shop()
        {
            InitializeComponent();
            MyInventory();

        }

        public void MyInventory()
        {
            StackLayout myStacklayout = new StackLayout();

            Grid mygrid = new Grid();


            for (int i = 0; i < 5; ++i)
            {
                mygrid.RowDefinitions.Add(new RowDefinition());
            }

            for (int i = 0; i < 5; ++i)
            {
                mygrid.ColumnDefinitions.Add(new ColumnDefinition());
            }

        }



        async void ButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;

            //Check Button Clicked
            if (button.StyleId == "1")
            {
                
                String buy = await DisplayActionSheet("Selected Item 1", "Cancel", null, "Buy");

                if (buy == "Buy")
                {
                    await DisplayAlert("Item 1", "Saved in inventory", "Cancel");
                }
            }
            else if (button.StyleId == "2")
            {
                String buy = await DisplayActionSheet("Selected Item 2", "Cancel", null, "Buy");

                if (buy == "Buy")
                {
                    await DisplayAlert("Item 2", "Saved in inventory", "Cancel");
                }
            }
            else if (button.StyleId == "3")
            {
                String buy = await DisplayActionSheet("Selected Item 3", "Cancel", null, "Buy");

                if (buy == "Buy")
                {
                    await DisplayAlert("Item 3", "Saved in inventory", "Cancel");
                }
            }
            else if (button.StyleId == "4")
            {
                String buy = await DisplayActionSheet("Selected Item 4", "Cancel", null, "Buy");

                if (buy == "Buy")
                {
                    await DisplayAlert("Item 4", "Saved in inventory", "Cancel");
                }
            }


        }


    }

    /*         
     public class CustomBehavior : Behavior<View>
     {
         protected override void OnAttachedTo(View bindable)
         {
             base.OnAttachedTo(bindable);
             // Perform setup
         }

         protected override void OnDetachingFrom(View bindable)
         {
             base.OnDetachingFrom(bindable);
             // Perform clean up
         }

         // Behavior implementation
         void Inventory()
         {
         } 
     }
     */

    public class Inventory : Shop
    {

    }

}