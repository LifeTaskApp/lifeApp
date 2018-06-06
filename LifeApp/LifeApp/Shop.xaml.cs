using System;
using System.Collections.Generic;
using System.Drawing;
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
        private int itemChoosen = 0;

        public Shop()
        {
            InitializeComponent();

        }
        //Items Object
  /*      public class BoughtItems
        {
            public String Name { get; set; }
            public int Cost { get; set; }
            public Image Img { get; set; }
            public Boolean Equipped { get; set; }
        }
        */

        // This class makes a new Item
        public class newItem
        {
            public String Name { get; set; }
            public int Cost { get; set; }
            public Image Img { get; set; }
            public Boolean Equipped { get; set; }

            public newItem(string Name, int Cost, Boolean Equipped, string Imagepath)
            {
                this.Name = Name;
                this.Cost = Cost;
                this.Equipped = Equipped;
                this.Img = new Image { Source = Imagepath };
                
            }
            
        }

        //Method to add item bought to list
        public void InInventory()
        {
            if (itemChoosen == 1)
            {
                newItem OrangeShirt = new newItem("OrangeShirt", 1000, false, "orange-T.png");
            }
            else if (itemChoosen == 2)
            {
                newItem OrangeShirt = new newItem("OrangeShirt", 1000, false, "orange-T.png");
            }
            else if (itemChoosen == 3)
            {
                newItem OrangeShirt = new newItem("OrangeShirt", 1000, false, "orange-T.png");
            }
            else if (itemChoosen == 4)
            {
                newItem OrangeShirt = new newItem("OrangeShirt", 1000, false, "orange-T.png");
            }



        }

        async void ButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;

            //Check Button Clicked
            if (button.StyleId == "1")
            {
                
                String buy = await DisplayActionSheet("Selected Item 1", "Cancel", null, "Buy");

                //creates pop up to prompt if customer wants to buy item and save it in inventory.
                if (buy == "Buy")
                {
                    await DisplayAlert("Item 1", "Saved in inventory", "Cancel");
                    itemChoosen = 1; // Item which was bought by the user.
                }
            }
            else if (button.StyleId == "2")
            {
                String buy = await DisplayActionSheet("Selected Item 2", "Cancel", null, "Buy");

                if (buy == "Buy")
                {
                    await DisplayAlert("Item 2", "Saved in inventory", "Cancel");
                    itemChoosen = 2; 
                }
            }
            else if (button.StyleId == "3")
            {
                String buy = await DisplayActionSheet("Selected Item 3", "Cancel", null, "Buy");

                if (buy == "Buy")
                {
                    await DisplayAlert("Item 3", "Saved in inventory", "Cancel");
                    itemChoosen = 3;
                }
            }
            else if (button.StyleId == "4")
            {
                String buy = await DisplayActionSheet("Selected Item 4", "Cancel", null, "Buy");

                if (buy == "Buy")
                {
                    await DisplayAlert("Item 4", "Saved in inventory", "Cancel");
                    itemChoosen = 4;
                }
            }

        }

    }

}