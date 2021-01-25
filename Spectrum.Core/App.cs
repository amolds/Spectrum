using System;
using MvvmCross;
using MvvmCross.ViewModels;
using Spectrum.Core.ViewModels;

namespace Spectrum.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            //Mvx.IoCProvider.RegisterType<>

            // One and only view - this line gets executed.
            RegisterAppStart<ExampleViewModel>();
        }
    }

    //public class Setup : MvxIosSetup
    //{
    //    public Setup(MvxApplicationDelegate appDelegate, IMvxIosViewPresenter presenter)
    //    : base(appDelegate, presenter)
    //    {
    //    }

    //    protected override IMvxApplication CreateApp()
    //    {
    //        return new App();
    //    }
    //}
}
