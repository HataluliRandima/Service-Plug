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
using XamarinMobile.Views;
using System.Diagnostics;

namespace XamarinMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile : ContentPage
    {
        static HttpClient client11 = new HttpClient();
        public Profile()
        {
            InitializeComponent();
            _ = getcurrentmerchant();
             _= getallrequest();
            _ = gettotalrequests();
            _ = gettotaljobdone();
        }

        private async Task<string> getcurrentmerchant()
        {
        //    var client = new HttpClient();
            client11.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);

            var json = await client11.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Merchants/merchant/current");

            Debug.WriteLine(json);
           Debug.WriteLine("Hello");
            //  var content2 = await json..ReadAsStringAsync();
            JObject jwtd = JsonConvert.DeserializeObject<JObject>(json);
            Debug.WriteLine(jwtd);
            // JObject hata = JsonConvert.DeserializeObject(json);
          //  foreach (var f in jwtd)
           // {
                var username = jwtd.Value<string>("merchName");
                Debug.WriteLine(username);
                var surname = jwtd.Value<string>("merchSurname");
                var useremail = jwtd.Value<string>("merchEmail");
                var merchType = jwtd.Value<string>("merchType");
                var merchAddress = jwtd.Value<string>("merchAddress");
                var merchProvince = jwtd.Value<string>("merchProvince");
                var ContactDetails = jwtd.Value<string>("merchContactdetails");

                Debug.WriteLine("Hello");
                txtName.Text = username;
                txtMerchAddress.Text = merchAddress;
                txtSurname.Text = " " + surname;
                txtEmail.Text = " " + useremail;
                txtMerchType.Text = " " + merchType;
                txtMerchProvince.Text = merchProvince;
                txtContactDetails.Text = ContactDetails;

                Debug.WriteLine(username);
                Debug.WriteLine(surname);
                Debug.WriteLine(merchType);
                //var bookss = JsonConvert.DeserializeObject<string>(json);

               
         //   }
            return json;
        }

        private async Task<string> getallrequest()
        {
           // var client = new HttpClient();
            client11.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);

            var json = await client11.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Bookings/bookingnumbers");
            // var content2 = await json.Content.ReadAsStringAsync();
            txttotalactiverequest.Text = json;
            Debug.WriteLine(json);
            return json;
        }

        private async Task<string> gettotalrequests()
        {
           // var client = new HttpClient();
            client11.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);

            var json = await client11.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Bookings/bookingnumberstotal");
            //var content2 = await json.Content.ReadAsStringAsync();
            txttotalrequests.Text = json;
            Debug.WriteLine(json);
            return json;
        }

        private async Task<string> gettotaljobdone()
        {
           // var client = new HttpClient();
            client11.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);

            var json = await client11.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Bookings/JobsDonenumbers");
            //var content2 = await json.Content.ReadAsStringAsync();
            txtgetjobsdone.Text = json;
            Debug.WriteLine(json);
            return json;
        }

        private void Edit_Button(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditProfile());
        }
    }
}