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
using XamarinMobile.Models;
using XamarinMobile.Services;
using XamarinMobile.Views;

namespace XamarinMobile.Booking
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewActiveJobs : ContentPage
    {
        private APIServices aPIServices = new APIServices();
        public ViewActiveJobs()
        {
            InitializeComponent();
        }

        private async Task<String> Test()
        {
            var client = new HttpClient();
            var json = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Bookings/booking");

            JObject jwtd = JsonConvert.DeserializeObject<JObject>(json);

            var username = jwtd.Value<String>("userName");
            var surname = jwtd.Value<String>("userSurname");
            var useremail = jwtd.Value<String>("userEmail");
            var userAddress = jwtd.Value<String>("userAddress");
            var userContDet = jwtd.Value<String>("userContactdetails");


            //status

            //userEmailAdd.Text = useremail;
            //contactDetails.Text = userContDet;
            //userAdd.Text = userAddress;
            //userName11.Text = username;
            //usersurname11.Text = surname;

            return json;
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            var myrequest = e.Item as RequestsModel;
            await Navigation.PushAsync(new ActiveJobDetail(myrequest.UserId, myrequest.MerchId, myrequest.BookStatus, myrequest.BookDate, myrequest.BookTime, myrequest.BookMessage, myrequest.BookId));

            var user = await aPIServices.getclientAsync(myrequest.UserId);
        }

    }
}