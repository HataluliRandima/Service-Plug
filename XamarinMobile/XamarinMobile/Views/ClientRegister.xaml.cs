using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientRegister : ContentPage
    {
        public ClientRegister()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WelcomePage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MerchantRegister());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}