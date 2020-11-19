using System;
using System.Collections.Generic;
using LoginTestAndroidApp.ViewModels;
using Xamarin.Forms;

namespace LoginTestAndroidApp.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel(Navigation);
        }

        protected override void OnAppearing()
        {
            this.UserId.Text = "";
            this.Password.Text = "";
            
            base.OnAppearing();
        }

        async void UserId_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            await (this.BindingContext as LoginViewModel).SignInButtonEnable(this.UserId.Text, this.Password.Text);
            
        }

        async void Password_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            await (this.BindingContext as LoginViewModel).SignInButtonEnable(this.UserId.Text, this.Password.Text);
            
        }
    }
}
