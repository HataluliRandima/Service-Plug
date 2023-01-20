using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMobile.Services;
using XamarinMobile.Views;

namespace XamarinMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MerchantRegister : ContentPage
    {
        private APIServices aPIServices = new APIServices();

        string merchType;
        public string MerchType
        {
            get => merchType;
            set
            {
                merchType = value;
                OnPropertyChanged("MerchType");
            }
        }

        //public event PropertyChangedEventHandler PropertyChanged;
        //protected void OnPropertyChanged(string propertyName)
        //{
        //    var handler = PropertyChanged;
        //    if(handler != null)
        //        handler(this, new PropertyChangedEventArgs(propertyName));
        //}

        public MerchantRegister()
        {
            InitializeComponent();
        }

        private async void VerifyAcc(object sender, EventArgs e)
        {
            
            if (merchBricklaying.IsChecked)
            {
                MerchType = merchBricklaying.Value.ToString();
            }

            if (merchCarpentry.IsChecked)
            {
                MerchType = merchBricklaying.Value.ToString();
            }
            if (merchGardener.IsChecked)
            {
                MerchType = merchBricklaying.Value.ToString();
            }
            if (merchPlastering.IsChecked)
            {
                MerchType = merchPlastering.Value.ToString();
            }
            if (merchTiling.IsChecked)
            {
                MerchType = merchTiling.Value.ToString();
            }
            if (merchPlumbing.IsChecked)
            {
                MerchType = merchPlumbing.Value.ToString();
            }
            if (merchGateMaking.IsChecked)
            {
                MerchType = merchGateMaking.Value.ToString();
            }

            if(password.Text != retryPassword.Text)
            {
                await DisplayAlert("incorrect password", "Passwords do not match", "OK");
            }
            else
            {
                var user = await aPIServices.registerAsync(merchName.Text, merchSurname.Text, merchEmail.Text, password.Text, merchType, merchAddress.Text, merchCity.Text, merchProvince.Text, merchContactDetails.Text);


                    await Navigation.PushAsync(new LoginPage());
                

            }


        }

        private void LoginClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}