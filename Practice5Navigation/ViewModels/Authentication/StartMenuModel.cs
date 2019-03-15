using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using KMA.ProgrammingInCSharp2019.Lab03.Navigation.Tools;
using KMA.ProgrammingInCSharp2019.Lab03.Navigation.Tools.Managers;
using KMA.ProgrammingInCSharp2019.Lab03.Navigation.Tools.Navigation;
using KMA.ProgrammingInCSharp2019.Practice5.Navigation.Models;

namespace KMA.ProgrammingInCSharp2019.Lab03.Navigation.ViewModels.Authentication
{
    internal class StartMenuModel:BaseViewModel
    {
        #region Fields
        private string _fName;
        private string _lName;
        private string _email;
        private DateTime _date = DateTime.Today;

        #region Commands
        private RelayCommand<object> _signInCommand;
        #endregion
        #endregion

        #region Properties
        public string FName
        {
            get { return _fName; }
            set
            {
                _fName = value.Replace(" ", "Space");
                OnPropertyChanged();
            }
        }
        public string LName
        {
            get { return _lName; }
            set
            {
                _lName = value.Replace(" ", "Space");
                OnPropertyChanged();
            }
        }
        public string EMAIL
        {
            get { return _email; }
            set
            {
       
                _email = value.Replace(" ", "Space");
                OnPropertyChanged();
            }
        }

        public DateTime DATE
        {
            get { return _date; }
            set
            {
            
                    _date = value;
                    OnPropertyChanged();
                

            }
        }

        #region Commands

        public RelayCommand<object> SignInCommand
        {
            get
            {
                return _signInCommand ?? (_signInCommand = new RelayCommand<object>(
                           Check, o => CanExecuteCommand()));
            }
        }


    
        #endregion
        #endregion

        private bool CanExecuteCommand()
        {
            return !string.IsNullOrWhiteSpace(_fName) && !string.IsNullOrWhiteSpace(_lName) 
                    && !string.IsNullOrWhiteSpace(_email);
        }

        private void Check(object obj)
        {
            try
            {
                Person p = new Person(_fName, _lName, _email, _date);
                StationManager.CurrentPerson = p;
                Proceed(obj);
            }
            catch (PersonException ex)
            {
               
                MessageBox.Show($"Error: {ex.Message} {ex.Value}");
            }
            Console.Read();
        }
        private async void Proceed(object obj)
        {
            LoaderManeger.Instance.ShowLoader();
            await Task.Run(() =>
            {
                Thread.Sleep(1000);
            });
            LoaderManeger.Instance.HideLoader();
            if (StationManager.CurrentPerson.IsBirthdayGet)
                MessageBox.Show($"Happy Birthday, {_fName} {_lName}!");
            NavigationManager.Instance.Navigate(ViewType.SignUp);
        }
    }
}
