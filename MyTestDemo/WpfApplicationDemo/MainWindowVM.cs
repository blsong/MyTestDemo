using Microsoft.Practices.Composite.Presentation.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApplicationDemo
{
    public class MainWindowVM:INotifyPropertyChanged
    {
        public MainWindowVM()
        {
            this.StudentList = new ObservableCollection<Student>(StudentService.RetrieveStudentList());

            AddCommand = new DelegateCommand<object>(OnAdd, arg => true);
            ModifyCommand = new DelegateCommand<object>(OnModify, arg => true);
            RemoveCommand = new DelegateCommand<object>(OnRemove, agr => true);

            this.PropertyChanged += MainWindowVM_PropertyChanged;
        }

        void MainWindowVM_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch(e.PropertyName)
            {
                case "IsPassed":
                    this.StudentList = new ObservableCollection<Student>(this.IsPassed ? StudentService.RetrievePassedStudentList() :
                StudentService.RetrieveStudentList());
                    break;
                default:
                    break;
            }
        }

        public MainWindow View { get; set; }
        private bool isPassed;
        public bool IsPassed
        {
            get
            {
                return this.isPassed;
            }
            set
            {
                if(this.isPassed!=value)
                {
                    this.isPassed = value;
                    OnPropertyChanged("IsPassed");
                }
            }
        }
        private ObservableCollection<Student> studengList;
        public ObservableCollection<Student> StudentList
        {
            get
            {
                return this.studengList;
            }
            set
            {
                if(this.studengList!=value)
                {
                    this.studengList = value;
                    OnPropertyChanged("StudentList");
                }
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand ModifyCommand { get; set; }
        public ICommand RemoveCommand { get; set; }

        public void OnAdd(object obj)
        {
            this.StudentList.Add(new Student() { UserId = 7, UserName = "李永京", Score = 75 });
        }

        public void OnModify(object obj)
        {
            var item = this.StudentList.SingleOrDefault(x => x.UserId == 1);
            if(item!=null)
            {
                if (item.Score == 100)
                    item.Score = 0;
                else
                    item.Score = 100;
            }
        }

        public void OnRemove(object obj)
        {
            var item = this.StudentList.SingleOrDefault(x => x.UserId == 2);
            if(item!=null)
            {
                this.StudentList.Remove(item);
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
