using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TodoList.Models;
using System.Collections.Generic;

namespace TodoList.Services
{
    public class AppStateService : INotifyPropertyChanged
    {
        #region Properties
        private string todoItem;
        public string TodoItem
        {
            get
            {
                return todoItem;
            }
            set
            {
                todoItem = value;
                NotifyPropertyChanged();
            }
        }
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Methods
        
        #endregion
    }
}