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
using XamarinMobile.dto;
using static Android.Media.Session.MediaSession;
using XamarinMobile.Helper;
using System.Diagnostics;

namespace XamarinMobile.Booking
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Quotation : ContentPage
    {
        int bookid1;
        int merchid1;
        int userid1;
        public Quotation(int BookId, int MerchId, int UserId)
        {
            InitializeComponent();
            bookid1 = BookId;
            merchid1 = MerchId;
            userid1 = UserId;
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);
            var model = new SendQuotation
            {
                BookId = bookid1,
                MerchId = merchid1,
                UserId = userid1,
                QuotAmount = QuoteAmount.Text,
                QuotDescription = QuoteDescription.Text
            };

            var model1 = new TakeJob
            {
                UserId = userid1,
                MerchId = merchid1,
                BookId = bookid1
            };

            var json1 = JsonConvert.SerializeObject(model1);
            HttpContent content1 = new StringContent(json1);
            content1.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response1 = await client.PostAsync("https://spfinalapi.azurewebsites.net/api/Jobs/addjobs", content1);
            var content3 = await response1.Content.ReadAsStringAsync();
            JObject jwtd1 = JsonConvert.DeserializeObject<JObject>(content3);
            Debug.WriteLine(content3);

            
            var json = JsonConvert.SerializeObject(model);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await client.PostAsync("https://spfinalapi.azurewebsites.net/api/Quotations/addquotation", content);
            var content2 = await response.Content.ReadAsStringAsync();
            JObject jwtd = JsonConvert.DeserializeObject<JObject>(content2);
            Debug.WriteLine(content2);
            
            Navigation.PushAsync(new FlyoutHome());
        }
    }
}