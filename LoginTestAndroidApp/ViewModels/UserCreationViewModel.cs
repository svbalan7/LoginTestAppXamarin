using System;
using System.Threading.Tasks;
using System.Windows.Input;
using LoginTestAndroidApp.Views;
using Xamarin.Forms;

namespace LoginTestAndroidApp.ViewModels
{
    public class UserCreationViewModel : BaseViewModel
    {
        public UserCreationViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            SignInVisible = false;
            _accountCreateCmd = new Lazy<ICommand>(() => new Command(AccountCreateBtn));
        }

        

        public INavigation Navigation { get; set; }


        private readonly Lazy<ICommand> _accountCreateCmd;
        public ICommand AccountCreateCmd => _accountCreateCmd.Value;

        private string _FirstName;

        

        public string FirstName
        {
            get { return _FirstName; }
            set { SetProperty(ref _FirstName, value); }
        }

        private string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set { SetProperty(ref _LastName, value); }
        }

        private string _userId;
        public string UserId
        {
            get { return _userId; }
            set { SetProperty(ref _userId, value); }
        }

        private string _pswd;
        public string Password
        {
            get { return _pswd; }
            set { SetProperty(ref _pswd, value); }
        }

        private bool _SignInVisible;
        public bool SignInVisible
        {
            get { return _SignInVisible; }

            set { SetProperty(ref _SignInVisible, value); }
        }

        private bool _accountCreateBtnEnable;
        public bool AccountCreateBtnEnable
        {
            get { return _accountCreateBtnEnable; }
            set { SetProperty(ref _accountCreateBtnEnable, value); }
        }



        public async Task SetNewAccountBtnVisibility()
        {
            if (!string.IsNullOrEmpty(UserId) && !string.IsNullOrEmpty(Password)
                && !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName))
            {
                SignInVisible = true;
            }
            else
                SignInVisible = false;
        }

        private async void AccountCreateBtn(object obj)
        {
            await Navigation.PushAsync(new AccountSuccess());
        }
    }
}
