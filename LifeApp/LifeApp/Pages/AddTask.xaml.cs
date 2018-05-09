using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LifeApp.Pages
{
    public partial class AddTask : ContentPage
    {
        public AddTask(string text)
        {
            InitializeComponent();

            Entry addTaskEntry = this.FindByName<Entry>("editTaskEntry");
            addTaskEntry.Text = text;
        }
    }
}
