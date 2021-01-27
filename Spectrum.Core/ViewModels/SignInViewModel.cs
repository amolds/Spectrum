using System;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Spectrum.Core.ViewModels
{
    public class SignInViewModel : MvxViewModel
    {
        readonly IMvxNavigationService _navigationService;

        public SignInViewModel(IMvxNavigationService  navigationService)
        {
            _navigationService = navigationService;
        }

        private string _userName;
        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                SetProperty(ref _userName, value);
                RaisePropertyChanged(() => CanSignIn);
                SignInCommand.RaiseCanExecuteChanged();
            }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                SetProperty(ref _password, value);
                RaisePropertyChanged(() => CanSignIn);
                SignInCommand.RaiseCanExecuteChanged();
            }
        }

        public bool CanSignIn
        {
            get => !string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(Password);
        }

        public override Task Initialize()
        {
            return base.Initialize();

            UserName = string.Empty;
            Password = string.Empty;
        }

        public IMvxCommand SignInCommand
        {
            get => new MvxCommand(SignIn, () => CanSignIn);
        }

        public IMvxCommand CreateAccountCommand
        {
            get => new MvxCommand(CreateAccount);
        }

        private void SignIn()
        {

        }

        private void CreateAccount()
        {
            _navigationService.Navigate<CreateAccountViewModel>();
        }
    }
}
