using System;
using System.Collections.Generic;
using LoginTestAndroidApp.ViewModels;
using Xamarin.Forms;

namespace LoginTestAndroidApp.Views
{
    public partial class UserCreationPage : ContentPage
    {
        

        public UserCreationPage()
        {
            InitializeComponent();
            BindingContext = new UserCreationViewModel(Navigation);
        }

        async void EntryField_Changed(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            await (this.BindingContext as UserCreationViewModel).SetNewAccountBtnVisibility();
        }
    }
}
