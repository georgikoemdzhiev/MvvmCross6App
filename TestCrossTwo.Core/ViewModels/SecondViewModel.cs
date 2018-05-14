using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.ViewModels;
using TestCrossTwo.Core.Service;

namespace TestCrossTwo.Core.ViewModels
{
    public class SecondViewModel : MvxViewModel
    {
        private readonly INameProvidorService _nameProvidorService;

        public SecondViewModel(INameProvidorService nameProvidorService)
        {
            _nameProvidorService = nameProvidorService;

            Name = _nameProvidorService.GetName();

            
        }


        private string _name;

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
    }
}