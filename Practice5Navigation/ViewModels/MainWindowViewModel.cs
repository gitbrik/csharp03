﻿using System.Windows;
using KMA.ProgrammingInCSharp2019.Lab03.Navigation.Tools;
using KMA.ProgrammingInCSharp2019.Lab03.Navigation.Tools.Managers;

namespace KMA.ProgrammingInCSharp2019.Lab03.Navigation.ViewModels
{
    internal class MainWindowViewModel : BaseViewModel, ILoaderOwner
    {
        #region Fields
        private Visibility _loaderVisibility = Visibility.Hidden;
        private bool _isControlEnabled = true;
        #endregion

        #region Properties
        public Visibility LoaderVisibility
        {
            get { return _loaderVisibility; }
            set
            {
                _loaderVisibility = value;
                OnPropertyChanged();
            }
        }
        public bool IsControlEnabled
        {
            get { return _isControlEnabled; }
            set
            {
                _isControlEnabled = value;
                OnPropertyChanged();
            }
        } 
        #endregion

        internal MainWindowViewModel()
        {
            LoaderManeger.Instance.Initialize(this);
        }
    }
}
