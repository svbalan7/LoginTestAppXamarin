using System;
using Xamarin.Forms;

namespace LoginTestAndroidApp.ViewModels
{
    public class AccountSuccessViewModel
    {
        public INavigation Navigation { get; set; }
        public AccountSuccessViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
        }
        
    }
}
