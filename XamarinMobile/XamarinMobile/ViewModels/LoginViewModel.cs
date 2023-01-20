using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinMobile.Services;
using XamarinMobile.Helper;

namespace XamarinMobile.ViewModels
{
    public class LoginViewModel
    {
        private APIServices aPIServices = new APIServices();

        public string MerchEmail { get; set; }
        public string MerchPassword { get; set; }

        public ICommand LoginCommand
        {
            get
            {
                return new Command(async() =>
                {
                    var token = await aPIServices.LoginAsync(MerchEmail, MerchPassword);

                    Settings.token = token;
                });
            }
        }
    }
}
