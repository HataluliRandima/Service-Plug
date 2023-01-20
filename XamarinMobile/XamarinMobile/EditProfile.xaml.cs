using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamarinMobile.Helper;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;
using System.Xml.Linq;
using XamarinMobile.dto;
using static Android.Media.Session.MediaSession;

namespace XamarinMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditProfile : ContentPage
    {
        private int merchidd;
        public EditProfile()
        {
            InitializeComponent();
            _ = getcurrentmerchant();
        }
     
        private async Task<string> getcurrentmerchant()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);

            var json = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Merchants/merchant/current");

            Debug.WriteLine(json);
            //  var content2 = await json..ReadAsStringAsync();

            JObject jwtd = JsonConvert.DeserializeObject<JObject>(json);
            // JObject hata = JsonConvert.DeserializeObject(json);

            var username = jwtd.Value<string>("merchName");
            var surname = jwtd.Value<string>("merchSurname");
            var useremail = jwtd.Value<string>("merchEmail");
            var merchType = jwtd.Value<string>("merchType");
            var merchAddress = jwtd.Value<string>("merchAddress");
            var merchProvince = jwtd.Value<string>("merchProvince");
            var merchContactDetail = jwtd.Value<string>("merchContactdetails");
            var merchCity = jwtd.Value<string>("merchCity");
            int merchId = jwtd.Value<int>("merchId");

            merchidd = merchId;

            txtName.Text = username;
            txtMerchAddress.Text = merchAddress;
            txtSurname.Text = surname;
            txtEmail.Text = useremail;
            txtMerchType.Text = merchType;
            txtMerchProvince.Text = merchProvince;
            txtMerchCity.Text = merchCity;
            txtContactDetails.Text = merchContactDetail;

            Debug.WriteLine(username);
            Debug.WriteLine(surname);
            //var bookss = JsonConvert.DeserializeObject<string>(json);

            return json;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);

            var model = new MerchantRegisterDTO
            {
                MerchAddress = txtMerchAddress.Text,
                MerchCity = txtMerchCity.Text,
                MerchProvince = txtMerchProvince.Text,
                MerchContactdetails = txtContactDetails.Text,
            };
            var json = JsonConvert.SerializeObject(model);

            HttpContent content = new StringContent(json);

            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await client.PutAsync("https://spfinalapi.azurewebsites.net/api/Merchants/edituser/" + merchidd, content);
            var content2 = await response.Content.ReadAsStringAsync();

            Debug.WriteLine(content2);
            await DisplayAlert("Profile edited", "You have sucessfully updated your profile details", "ok");
            Navigation.PushAsync(new Profile());
        }
    }
}