using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using XamarinMobile.Helper;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http.Headers;
using XamarinMobile.dto;
using System.Diagnostics;

namespace XamarinMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewActiveJobDetail : ContentPage
    {
        //, string UserContactdetails, string UserProvince, string UserCity, string UserAddres
        private int useriddd;

        private int jobb;
        public ViewActiveJobDetail(int UserId, string UserName, string UserSurname, DateTime BookDatetime, string UserEmails, string JobStatus, int jobidd)
        {
            InitializeComponent();
            useriddd = UserId;
            jobss.Text = JobStatus;
            jobb = jobidd;
            _ = Test(useriddd);
        }

        private async Task<String> Test(int id)
        {
            var client = new HttpClient();
            var json = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Users/Users/" + id);

            JObject jwtd = JsonConvert.DeserializeObject<JObject>(json);


            int useriddd = jwtd.Value<int>("userId");
            var username = jwtd.Value<String>("userName");
            var surname = jwtd.Value<String>("userSurname");
            var useremail = jwtd.Value<String>("userEmail");
            var userAddress = jwtd.Value<String>("userAddress");
            var userprovince = jwtd.Value<String>("userProvince");
            var usercity = jwtd.Value<String>("userCity");
            var userContDet = jwtd.Value<String>("userContactdetails");
            var uBookDateTime = jwtd.Value<DateTime>("");

            userE.Text = useremail;
            contactDetails.Text = userContDet;
            userAdd.Text = userAddress;
            userN.Text = username;
            userS.Text = surname;
            //userP.Text = userprovince;
            //userC.Text = usercity;
            return json;
        }

        private async void AcceptBooking_Clicked(object sender, EventArgs e)
        {

            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);

            var model = new Jobconfirm
            {   
                JobId = jobb,
                JobStatus = "Service Done",
               
            };
            var json = JsonConvert.SerializeObject(model);

            HttpContent content = new StringContent(json);

            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await client.PutAsync("https://spfinalapi.azurewebsites.net/api/Jobs/jobconfirm/" + useriddd, content);
            var content2 = await response.Content.ReadAsStringAsync();

            Debug.WriteLine(content2);
            DisplayAlert("Job Done", "Successfully Completed Job for Client", "ok");
            Navigation.PushAsync(new FlyoutHome());

        }

        private void DecineBooking_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FlyoutHome());
        }
    }
}