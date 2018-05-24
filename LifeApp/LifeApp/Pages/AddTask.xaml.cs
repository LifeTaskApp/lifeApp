using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace LifeApp.Pages
{
    public partial class AddTask : ContentPage
    {
        private string task;

        private void saveTask(object sender, EventArgs e)
        {
            Entry addTaskEntry = this.FindByName<Entry>("editTaskEntry");
            task = addTaskEntry.Text;

            //ListView allTaskList = this.FindByName<ListView>("allTaskList");
            //allTaskList.ItemsSource = new List<Task>()
            //{
            //    new Task()
            //    {
            //        taskName = task
            //    }
            //};

            //List<Task> taskList = new List<Task>();

            //Label listTaskName = this.FindByName<Label>("listTaskName");
            //listTaskName.Text = task;

            //List<Task> tasks = new List<Task>();
            //tasks.Add(new Task { taskName = task });

            //allTaskList.ItemsSource = tasks;
        }

        public AddTask(string text)
        {
            InitializeComponent();

            Entry addTaskEntry = this.FindByName<Entry>("editTaskEntry");
            addTaskEntry.Text = text;
        }
    }
}