using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace TestCrossTwo.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public FirstViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            GoToCmd = new MvxCommand(() => { _navigationService.Navigate<SecondViewModel>(); });
        }

        private string _firstName;

        public string FirstName
        {
            get => _firstName;
            set
            {
                SetProperty(ref _firstName, value);
                RaisePropertyChanged(() => FullName);
            }
        }

        private string _lastName;

        public string LastName
        {
            get => _lastName;
            set
            {
                SetProperty(ref _lastName, value);
                RaisePropertyChanged(() => FullName);
            }
        }

        public string FullName => $"{_firstName} {_lastName}";

        public ICommand GoToCmd { get; set; }
    }

    public class MainViewModel : MvxViewModel
    {
    }
}