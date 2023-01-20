using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMobile.Services;
using XamarinMobile.ViewModels;

namespace XamarinMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        private APIServices aPIServices = new APIServices();

        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            var user = await aPIServices.LoginAsync(emailPlaceholder.Text, passwordPlaceholder.Text);
            if(user != null)
            {
                await Navigation.PushAsync(new FlyoutHome());
            }
            else
            {
                await DisplayAlert("Wrong credentials", "Either the password or email is wrong", "ok");
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ForgotPassword());
        }
        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MerchantRegister());
        }
    }
}