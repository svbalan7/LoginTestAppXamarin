using System;
using System.Threading.Tasks;
using System.Windows.Input;
using LoginTestAndroidApp.Views;
using Xamarin.Forms;

namespace LoginTestAndroidApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public INavigation Navigation { get; set; }

        public LoginViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            _loginCommand = new Lazy<ICommand>(() => new Command(Login));
            _newUserCreationCmd = new Lazy<ICommand>(() => new Command(UserCreation));
        }
        private bool _SignInVisible;
		public bool SignInVisible
		{
			get { return _SignInVisible; }

			set { SetProperty(ref _SignInVisible, value); }
		}

        private bool _isLoginButtonEnable;
        public bool IsLoginButtonEnable
        {
            get { return _isLoginButtonEnable; }
            set { SetProperty(ref _isLoginButtonEnable, value); }
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

       
        private readonly Lazy<ICommand> _loginCommand;
        public ICommand LoginCommand => _loginCommand.Value;

        private readonly Lazy<ICommand> _newUserCreationCmd;
        public ICommand NewUserCreationCmd => _newUserCreationCmd.Value;

        async void Login()
        {
            string userId = UserId;
            string pswd = Password;

            await ProcessLoginCredentials();
    
        }

        private async Task ProcessLoginCredentials()
        {
            //-If the account doesn’t exist, an error message should show up on the screen, specifying that the account doesn’t exist.
            //-If the password doesn’t match, an error message should show up on the screen specifying that the password is incorrect.
            //-If the user account exists and the password matches, a success message should show up on the screen(message up to the candidate).

            await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Error", "Invalid ID or Password", "OK");
        }

        public async Task SignInButtonEnable(string userId, string pswd)
        {
            if(!string.IsNullOrEmpty(userId) && !string.IsNullOrEmpty(pswd))
            {
                SignInVisible = true;
            }
            else
            {
                SignInVisible = false;
            }
        }

        public async void UserCreation()
        {
            await Navigation.PushAsync(new UserCreationPage());
        }
    }
}
