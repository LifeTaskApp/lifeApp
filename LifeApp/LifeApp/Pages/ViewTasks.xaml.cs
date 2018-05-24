using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LifeApp.Pages
{
    public partial class ViewTasks : TabbedPage
    {
        public Task userTask = new Task();
        public string userTaskName;
        public string userDueDate;

        public ViewTasks()
        {
            InitializeComponent();
        }
    }
}
