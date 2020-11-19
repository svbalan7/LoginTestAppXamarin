using System;
using System.Collections.Generic;
using LoginTestAndroidApp.ViewModels;
using Xamarin.Forms;

namespace LoginTestAndroidApp.Views
{
    public partial class AccountSuccess : ContentPage
    {
        public AccountSuccess()
        {
            InitializeComponent();
            BindingContext = new AccountSuccessViewModel(Navigation);
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
