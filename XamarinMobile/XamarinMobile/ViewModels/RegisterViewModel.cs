using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinMobile.Services;

namespace XamarinMobile.ViewModels
{
    public class RegisterViewModel
    {
        APIServices aPIServices = new APIServices();

        public string MerchName { get; set; } 
        public string MerchSurname { get; set; } 
        public string MerchEmail { get; set; } 
        public string MerchPassword { get; set; }
        public string MerchType { get; set; }

        public string MerchAddress { get; set; }
        public string MerchCity { get; set; } 
        public string MerchProvince { get; set; } 
        public string MerchContactdetails { get; set; }

        public string Message { get; set; }

        public ICommand RegisterCommand
        {
            get
            {
                return new Command( async () =>
                {
                   var isSuccess = await aPIServices.registerAsync(MerchName, MerchSurname, MerchEmail, MerchPassword, MerchType, MerchAddress, MerchCity, MerchProvince, MerchContactdetails);

                    if (isSuccess)
                        Message = "Registered sucessfully";
                    else
                    {
                        Message = "Retry again";
                    }
                });
            }
        }


    }
}
