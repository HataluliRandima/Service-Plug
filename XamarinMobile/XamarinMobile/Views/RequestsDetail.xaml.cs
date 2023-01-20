using Android.OS;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Plugin.Toast;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMobile.Booking;
using System.Diagnostics;
 

using XamarinMobile.Helper;
using static Android.Media.Session.MediaSession;
using System.Net.Http.Headers;
using XamarinMobile.dto;
using Debug = System.Diagnostics.Debug;
using Android.Content;

namespace XamarinMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RequestsDetail : ContentPage
    {
        private int bookiddd;
        private int useriddd;
        public RequestsDetail(int userId, int MerchId, string BookStatus, DateTime BookDate,TimeSpan BookTime, string BookMessage, int BookId)
        {
            InitializeComponent();
            //muserID.Text = userId.ToString();
            //mMerchId.Text = MerchId.ToString();
            bookiddd = BookId;
            useriddd = userId;
            mBookStatus.Text = BookStatus;
            mBookDate.Text = BookDate.ToString();
            mBookTime.Text = BookTime.ToString();
            mBookMessage.Text = BookMessage;
            _ = Test(userId);
         //  
        }

        private async Task<String> Test(int id)
        {
            var client = new HttpClient();
            var json = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Users/Users/" + id);

            JObject jwtd = JsonConvert.DeserializeObject<JObject>(json);

            var username = jwtd.Value<String>("userName");
            var surname = jwtd.Value<String>("userSurname");
            var useremail = jwtd.Value<String>("userEmail");
            var userAddress = jwtd.Value<String>("userAddress");
            var userContDet = jwtd.Value<String>("userContactdetails");

            userEmailAdd.Text = useremail;
            contactDetails.Text = userContDet;
            userAdd.Text = userAddress;
            userName11.Text = username;
            usersurname11.Text = surname;

            return json;
        }
         private async void AcceptBooking_Clicked (object sender, EventArgs args)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);
            var model = new Bookchange
            {
                bookId = bookiddd,
                bookStatus = "Active"
            };
            var json = JsonConvert.SerializeObject(model);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await client.PutAsync("https://spfinalapi.azurewebsites.net/api/Bookings/bookconfirm/" + useriddd, content);
            var content2 = await response.Content.ReadAsStringAsync();
            //JObject jwtd = JsonConvert.DeserializeObject<JObject>(content2);
            //var token = jwtd.Value<string>("token");
            Debug.WriteLine(content2);

            DisplayAlert("Accepted", "Client request has been accepted", "ok");
            Navigation.PushAsync(new ViewActiveJobs());
        }

        private async void DeclineBooking_Clicked(object sender, EventArgs e)
        {

            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);
            var model = new Bookchange
            {
                bookId = bookiddd,
                bookStatus = "Declined"
            };
            var json = JsonConvert.SerializeObject(model);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await client.PutAsync("https://spfinalapi.azurewebsites.net/api/Bookings/bookconfirm/" + useriddd, content);
            var content2 = await response.Content.ReadAsStringAsync();
            //JObject jwtd = JsonConvert.DeserializeObject<JObject>(content2);
            //var token = jwtd.Value<string>("token");
            Debug.WriteLine(content2);

            DisplayAlert("Declined", "client request has been declined", "ok");
            Navigation.PushAsync(new ViewActiveJobs());
        }
    }
}