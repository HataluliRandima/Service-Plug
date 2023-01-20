using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMobile.Booking;
using XamarinMobile.Services;
using XamarinMobile.Models;

namespace XamarinMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActiveJobDetail : ContentPage
    {
        private int bookiddd;
        private int useriddd;
        private int merchiddd;
        public ActiveJobDetail(int userId, int MerchId, string BookStatus, DateTime BookDate, TimeSpan BookTime,string BookMessage, int BookId)
        {
            InitializeComponent();
            //muserID.Text = userId.ToString();
            //mMerchId.Text = MerchId.ToString();
            bookiddd = BookId;
            useriddd = userId;
            merchiddd = MerchId;
            mBookStatus.Text = BookStatus;
            mBookDate.Text = BookDate.ToString();
            mBookTime.Text = BookTime.ToString();
            mBookMessage.Text = BookMessage;
            _ = Test(userId); 
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

        private async void AcceptBooking_Clicked(object sender, EventArgs args)
        {

            //var myrequest = new RequestsModel();
            await Navigation.PushAsync(new Quotation(bookiddd, merchiddd, useriddd));
        }

        private async void DeclineBooking_Clicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new FlyoutHome());
        }
        
    }
}