using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace LifeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Shop : TabbedPage
    {
        public int itemChoosen = 0;

        public Shop()
        {
            InitializeComponent();

            ViewModel vm;
            vm = new ViewModel();
            MainListView.ItemsSource = vm.Currentnewitem;

           // MainListView.BindingContext = itemList;
        }

        public class ViewModel
        {
            public ObservableCollection<newItem> Currentnewitem { get; set; }

            public ViewModel()
            {
                Currentnewitem = new newItem().GetItems();
            }
        }
        // This class makes a new Item
        public class newItem
        {

            public String Name { get; set; }
            public int Cost { get; set; }
            public ImageSource Img { get; set; }
            public Boolean Equipped { get; set; }

            ObservableCollection<newItem> items = new ObservableCollection<newItem>(); //items variable of observableCollection


            //data encapsualtion set method
            public ObservableCollection<newItem> GetItems()
            {
                //    items.Add(new newItem { Name = this.Name, Cost = this.Cost, Equipped = this.Equipped});
                //    items.Add(new newItem { Name = "Orange-T", Cost = 34, Equipped = false });

                return items;

            }

            //data encapsualtion set method 
            public void SetItems(string myName, int myCost, Boolean myEquipped)
            {
                items.Add(new newItem()
                {
                    Name = myName,
                    Cost = myCost,
                    Equipped = myEquipped
                });
            }
        }

        //Method to add item bought to list
        public void AddToInventory()
        {
            newItem addItem = new newItem();
            //Items inorder to populate the ListView.
            if (itemChoosen == 1)
            {
                addItem.SetItems("Orange-Shoes", 50, false);
                
            }
            else if (itemChoosen == 2)
            {
                addItem.SetItems("Red-Shoes", 50, false);
            }
            else if (itemChoosen == 3)
            {
                addItem.SetItems("Blue-Shoes", 50, false);
            }
            else if (itemChoosen == 4)
            {
                addItem.SetItems("Green-Shoes", 50, false);
            }
            else if (itemChoosen == 5)
            {
                addItem.SetItems("Orange-T", 50, false);
            }
            else if (itemChoosen == 6)
            {
                addItem.SetItems("Red-T", 50, false);
            }
            else if (itemChoosen == 7)
            {
                addItem.SetItems("Blue-T", 50, false);
            }
            else if (itemChoosen == 8)
            {
                addItem.SetItems("Green-T", 50, false);
            }
            else if (itemChoosen == 9)
            {
                addItem.SetItems("Orange-Pants", 50, false);
            }
            else if (itemChoosen == 10)
            {
                addItem.SetItems("Red-Pants", 50, false);
            }
            else if (itemChoosen == 11)
            {
                addItem.SetItems("Blue-Pants", 50, false);
            }
            else if (itemChoosen == 12)
            {
                addItem.SetItems("Green-Pants", 50, false);
            }

        }

        async void ButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
        //    newItem addItem = new newItem();

            //Check Button Clicked
            if (button.StyleId == "1")
            {
                
                String buy = await DisplayActionSheet("Selected Item 1", "Cancel", null, "Buy");

                //creates pop up to prompt if customer wants to buy item and save it in inventory.
                if (buy == "Buy")
                {
                    itemChoosen = 1;
                    bool doBuy = await DisplayAlert("Item 1", "Saved in inventory", "Okay", "Cancel");

                    if (doBuy)
                    {
                        AddToInventory();
                    }
                }
            }
            else if (button.StyleId == "2")
            {
                String buy = await DisplayActionSheet("Selected Item 2", "Cancel", null, "Buy");

                if (buy == "Buy")
                {
                    itemChoosen = 2;
                    bool doBuy = await DisplayAlert("Item 2", "Saved in inventory", "Okay", "Cancel");

                    if (doBuy)
                    {
                        AddToInventory();
                    }
                }
            }
            else if (button.StyleId == "3")
            {
                String buy = await DisplayActionSheet("Selected Item 3", "Cancel", null, "Buy");

                if (buy == "Buy")
                {
                    await DisplayAlert("Item 3", "Saved in inventory", "Cancel");
                    itemChoosen = 3;
             //       addItem.SetItems("Blue-Shoes", 50, false);
                }
            }
            else if (button.StyleId == "4")
            {
                String buy = await DisplayActionSheet("Selected Item 4", "Cancel", null, "Buy");

                if (buy == "Buy")
                {
                    await DisplayAlert("Item 4", "Saved in inventory", "Cancel");
                    itemChoosen = 4;
            //        addItem.SetItems("Green-Shoes", 50, false);
                }
            }
            else if (button.StyleId == "5")
            {
                String buy = await DisplayActionSheet("Selected Item 1", "Cancel", null, "Buy");

                if (buy == "Buy")
                {
                    await DisplayAlert("Item 1", "Saved in inventory", "Cancel");
                    itemChoosen = 5;
                }
            }
            else if (button.StyleId == "6")
            {
                String buy = await DisplayActionSheet("Selected Item 2", "Cancel", null, "Buy");

                if (buy == "Buy")
                {
                    await DisplayAlert("Item 2", "Saved in inventory", "Cancel");
                    itemChoosen = 6;
                }
            }
            else if (button.StyleId == "7")
            {
                String buy = await DisplayActionSheet("Selected Item 3", "Cancel", null, "Buy");

                if (buy == "Buy")
                {
                    await DisplayAlert("Item 3", "Saved in inventory", "Cancel");
                    itemChoosen = 7;
                }
            }
            else if (button.StyleId == "8")
            {
                String buy = await DisplayActionSheet("Selected Item 4", "Cancel", null, "Buy");

                if (buy == "Buy")
                {
                    await DisplayAlert("Item 4", "Saved in inventory", "Cancel");
                    itemChoosen = 8;
                }
            }
            else if (button.StyleId == "9")
            {
                String buy = await DisplayActionSheet("Selected Item 1", "Cancel", null, "Buy");

                if (buy == "Buy")
                {
                    await DisplayAlert("Item 1", "Saved in inventory", "Cancel");
                    itemChoosen = 9;
                }
            }
            else if (button.StyleId == "10")
            {
                String buy = await DisplayActionSheet("Selected Item 2", "Cancel", null, "Buy");

                if (buy == "Buy")
                {
                    await DisplayAlert("Item 2", "Saved in inventory", "Cancel");
                    itemChoosen = 10;
                }
            }
            else if (button.StyleId == "11")
            {
                String buy = await DisplayActionSheet("Selected Item 3", "Cancel", null, "Buy");

                if (buy == "Buy")
                {
                    await DisplayAlert("Item 3", "Saved in inventory", "Cancel");
                    itemChoosen = 11;
                }
            }
            else if (button.StyleId == "12")
            {
                String buy = await DisplayActionSheet("Selected Item 4", "Cancel", null, "Buy");

                if (buy == "Buy")
                {
                    await DisplayAlert("Item 4", "Saved in inventory", "Cancel");
                    itemChoosen = 12;
                }
            }

        }

    }

}