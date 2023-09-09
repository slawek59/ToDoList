﻿using System.Windows.Controls;
using ToDoLIst.Core;

namespace ToDoList
{
    /// <summary>
    /// Logika interakcji dla klasy WorkTasksPage.xaml
    /// </summary>
    public partial class WorkTasksPage : Page
    {
        public WorkTasksPage()
        {
            InitializeComponent();

            DataContext = new WorkTasksPageViewModel();
        }
    }
}
