using System;
using MvvmCross.ViewModels;
using Spectrum.Core.ViewModels;

namespace Spectrum.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            //Mvx.IoCProvider.RegisterType<ICalculationService, CalculationService>();

            RegisterAppStart<SignInViewModel>();
        }
    }
}
