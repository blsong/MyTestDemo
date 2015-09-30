using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplicationDemo
{
    public class Student:INotifyPropertyChanged
    {
        public int UserId
        {
            get;
            set;
        }

        public string UserName
        {
            get;
            set;
        }

        private int score;

        public int Score
        {
            get
            {
                return this.score;
            }
            set
            {
                if(this.score!=value)
                {
                    this.score = value;
                    OnPropertyChanged("Score");
                }
            }
        }

        #region  INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if(handler!=null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
