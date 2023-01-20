using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMobile.Models;
using XamarinMobile.Services;
using XamarinMobile.Helper;
using XamarinMobile.ViewModels;
using Newtonsoft.Json;
using static Android.Media.Session.MediaSession;
using System.Net.Http.Headers;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace XamarinMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Requests : ContentPage
    {
        private APIServices aPIServices = new APIServices();

        private string status12;

        private string messagess;

        List<RequestsModel> list2 = new List<RequestsModel>();

        public Requests()
        {
            InitializeComponent();
            _ = getinforequest();

        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {


            var myrequest = e.Item as RequestsModel;
            await Navigation.PushAsync(new RequestsDetail(myrequest.UserId, myrequest.MerchId, myrequest.BookStatus, myrequest.BookDate, myrequest.BookTime, myrequest.BookMessage, myrequest.BookId));

            var user = await aPIServices.getclientAsync(myrequest.UserId);
        }

        private async Task<string> getinforequest()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);
            var json = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Bookings/bookingnot");
            var requests = JsonConvert.DeserializeObject<List<RequestsModel>>(json);

            JArray jwtd = JsonConvert.DeserializeObject<JArray>(json);
            Debug.WriteLine(jwtd);

            foreach (var f in jwtd)
            {
                int token11 = f.Value<int>("userId");
                status12 = f.Value<string>("bookStatus");
                //messagess=f.Value<string>("bookMessage");


                List<string> jobss = new List<string>();

                RequestsModel dm = new RequestsModel();



                dm.BookStatus = status12;

                //  dm.JobStatus = status12;

                list2.Add(dm);

                //status.Text = statusss;


                Debug.WriteLine(token11);
                Debug.WriteLine(status12);


            }


            return "";

        }


    }
}