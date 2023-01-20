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
using XamarinMobile.Booking;
using XamarinMobile.Control;
using XamarinMobile.Views;
using XamarinMobile.Helper;
using System.Diagnostics;

namespace XamarinMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutHomeDetail : ContentPage
    {
        public FlyoutHomeDetail()
        {
            InitializeComponent();
            _ = getcurrentmerchant();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            TranslateFrame(frame1);
            TranslateFrame(frame2);
            TranslateFrame(frame3);
            TranslateFrame(frame4);
            TranslateFrame(frame4);
            TranslateFrame(frame6);
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

            txtName.Text = "Welcome "+username;
            // usersurname11.Text = surname;

            Debug.WriteLine(username);
            Debug.WriteLine(surname);
            //var bookss = JsonConvert.DeserializeObject<string>(json);

            return json;
        }

        private void TranslateFrame(FrameView frame)
        {
            Task.Run(async () =>
            {
                await frame.RotateYTo(-360, 600); ;
            });
        }

        private async void lblframe1(object sender, EventArgs e)
        {
            AI.IsRunning = SAI.IsVisible = true;
            var view = (FrameView)sender;
            await view.ScaleTo(1.1, 100);
            await view.ScaleTo(1, 100);
            AI.IsRunning = SAI.IsVisible = false;
        }

        private void RequestTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Requests());

        }

        private void ActiveJobsTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewActiveJobs());
        }

        private void ProfileTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewJobsStarted());
        }

        private void ScheduleTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Scheduling2());
        }

        private void AnalysisTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Profile());
        }

        private void PaymentsTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Reports());
        }
    }
}