using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace LifeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Shop : TabbedPage
    {
        private int itemChoosen = 0;
        //   public List<newItem> myItems { get; set; }
        ObservableCollection<newItem> itemList = new ObservableCollection<newItem>();

        public Shop()
        {
            InitializeComponent();

            ViewModel vm;

            vm = new ViewModel();
            MainListView.ItemsSource = vm.Tnewitem;
        }

        public class ViewModel
        {
            public List<newItem> Tnewitem { get; set; }

            public ViewModel()
            {
                Tnewitem = new newItem().GetItems();
            }
        }
   

    // This class makes a new Item
    public class newItem
        {
            public String Name { get; set; }
            public int Cost { get; set; }
            public ImageSource Img { get; set; }
            public Boolean Equipped { get; set; }
      
            //public newItem(string Name, int Cost, Boolean Equipped/*, String image*/)
            //{
            //    this.Name = Name;
            //    this.Cost = Cost;
            //    this.Equipped = Equipped;
            //   // this.Img = ImageSource.FromFile(image);
                
            //}

            public List<newItem> GetItems()
            {
                List<newItem> items = new List<newItem>()
                {
                    new newItem(){ Name = "Orange-T", Cost = 50, Equipped = false},
                    new newItem(){ Name = "Red-T", Cost = 100, Equipped = false}
                };

                return items;
            }



        }

        //Method to add item bought to list
        public void InInventory()
        {
            //Items inorder to populate the ListView.
            if (itemChoosen == 1)
            {
            }
            else if (itemChoosen == 2)
            {
            }
            else if (itemChoosen == 3)
            {
            }
            else if (itemChoosen == 4)
            {
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