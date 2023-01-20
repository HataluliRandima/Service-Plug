using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMobile.dto
{
    public class MerchantRegisterDTO
    {
        public string MerchName { get; set; } 
        public string MerchSurname { get; set; } 
        public string MerchEmail { get; set; } 
        public string MerchPassword { get; set; } 
        public string MerchType { get; set; } 

        public string MerchAddress { get; set; } 
        public string MerchCity { get; set; } 
        public string MerchProvince { get; set; } 
        public string MerchContactdetails { get; set; } 
    }
}
