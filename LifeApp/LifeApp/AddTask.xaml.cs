using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LifeApp
{
    public partial class AddTask : ContentPage
    {
        public AddTask(string text)
        {
            InitializeComponent();

            Entry editTaskEntry = this.FindByName<Entry>("editTaskEntry");
            editTaskEntry.Text = text;
        }
    }
}