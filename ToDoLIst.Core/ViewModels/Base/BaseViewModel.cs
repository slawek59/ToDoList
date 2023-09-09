﻿using System.ComponentModel;

namespace ToDoLIst.Core
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (s, e) => { };
    }
}
