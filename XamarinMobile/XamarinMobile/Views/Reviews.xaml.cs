using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMobile.Models;
using XamarinMobile.Services;
using System.Diagnostics;
using XamarinMobile.Helper;
using static System.Net.Mime.MediaTypeNames;
using Android.Webkit;

namespace XamarinMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Reviews : ContentPage
    {
        private APIServices aPIServices = new APIServices();
        private string revRating;
        private string revMessage;

        private string userrrr;

        private int jobiddd;

        List<ClientDetail> list1 = new List<ClientDetail>();

        List<ReviewsModel> list2 = new List<ReviewsModel>();
        public Reviews()
        {
            InitializeComponent();
            _ = getinfo();
        }

        //private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        //{

        //    var myrequest = e.Item as JobsStartedModel;
        //    await Navigation.PushAsync(new ViewActiveJobDetail(myrequest.UserId, myrequest.UserName, myrequest.UserSurname, myrequest.BookDatetime, myrequest.UserEmail, myrequest.JobStatus, myrequest.JobId));

        //    var user = await aPIServices.getclientAsync(myrequest.UserId);
        //}

        private async Task<string> getinfo()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);
            var json = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Reviews/getallreviews");
            Debug.WriteLine(json);
        //    var requests = JsonConvert.DeserializeObject<List<ReviewsModel>>(json);
            // var content2 = await requests.Content.ReadAsStringAsync();
            JArray jwtd = JsonConvert.DeserializeObject<JArray>(json);
            Debug.WriteLine(jwtd);

            foreach (var f in jwtd)
            {
                int token11 = f.Value<int>("userId");
                revRating = f.Value<string>("reviewRating");
                revMessage = f.Value<string>("reviewMessage");
                jobiddd = f.Value<int>("jobId");

                List<string> jobss = new List<string>();

                ReviewsModel dm1 = new ReviewsModel();

                //dm1.ReviewId = 
                dm1.ReviewRating = revRating;
                dm1.ReviewMessage = revMessage;

                dm1.JobId = jobiddd;

                list2.Add(dm1);

                //status.Text = statusss;

                Debug.WriteLine(token11);
                //   await  getclientAsync(token11);
                var json12 = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Users/Users/" + token11);
                JObject jwtddd = JsonConvert.DeserializeObject<JObject>(json12);

                ClientDetail mm = new ClientDetail();

                //var username = jwtddd.Value<string>("userName");
                userrrr = jwtddd.Value<string>("userName");
                var surname = jwtddd.Value<string>("userSurname");
                var useremail = jwtddd.Value<string>("userEmail");
                var userAddress = jwtddd.Value<string>("userAddress");
                var userContDet = jwtddd.Value<string>("userContactdetails");
                int useiddd = jwtddd.Value<int>("userId");

                //dm1.UserName = userrrr;
                //dm.UserSurname = surname;
                dm1.UserName = userrrr;
                dm1.UserSurname = surname;
                dm1.UserEmail = useremail;
                //dm1.UserId = useiddd;

                mm.UserName = userrrr;

                list1.Add(mm);

                //list1.Add(new ClientDetail { UserName = userrrr });


                //teste.ItemsSource = list1;


                //tsetse.ItemsSource =  status12;

                // usname.Text = username;
                // Debug.WriteLine(username);
                Debug.WriteLine(json12);


            }
            teste.ItemsSource = list1;


            teste.ItemsSource = list2;


            //  status.Text = status12;

            //var token1 = jwtd.Value<string>("JobStatus");

            //Debug.WriteLine(token1);

            //     int token = jwtd.Value<int>("userId");
            //var name = jwtd.Value<int>("userId");
            // var name = 
            Debug.WriteLine(json);

            //  Debug.WriteLine(token);
            Debug.WriteLine(jwtd);

         

            return userrrr;
        }

        private async void teste_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //, myrequest.UserContactdetails, myrequest.UserProvince,myrequest.UserCity,myrequest.UserAddress
            var myrequest = e.Item as ReviewsModel;
            await Navigation.PushAsync(new ReviewsDetail(myrequest.UserId, myrequest.JobId));

            var user = await aPIServices.getclientAsync(myrequest.UserId);
        }

    }
}