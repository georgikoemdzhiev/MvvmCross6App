using System;
using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using TestCrossTwo.Core.ViewModels;

namespace TestCrossTwo.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<FirstViewModel>();

            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
        }
    }
}