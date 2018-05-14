using System;
using MvvmCross.ViewModels;
using TestCrossTwo.Core.ViewModels;

namespace TestCrossTwo.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<FirstViewModel>();
        }
    }
}