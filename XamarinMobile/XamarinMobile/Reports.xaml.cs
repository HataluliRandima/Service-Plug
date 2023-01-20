using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamarinMobile.Helper;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http.Headers;
using System.Diagnostics;
using Newtonsoft.Json;
using Microcharts;
using SkiaSharp;
using static XamarinMobile.Views.StatsPage;
using Android.Content;
using Newtonsoft.Json.Linq;

namespace XamarinMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Reports : ContentPage
    {
        public string Jan;
        public int Feb;
        public int March;
        public int April;
        public int May;
        public int June;
        public int July;
        public int Aug;
        public string Sept;
        public int Oct;
        public int Nov;
        public int Dec;
        public string jsoon; 
        public Reports()
        {
            
            InitializeComponent();
            _ = getallrequest();
            _ = gettotalrequests();
            _ = gettotaljobdone();
            _ = getTotalRejectedJobs();
            _= getTotalRequestsPerMonthJan(1);
            _ = getTotalRequestsPerMonthFeb(2);
            _ = getTotalRequestsPerMonthMarch(3);
            _ = getTotalRequestsPerMonthApril(4);
            _ = getTotalRequestsPerMonthMay(5);
            _ = getTotalRequestsPerMonthJune(6);
            _ = getTotalRequestsPerMonthJuly(7);
            _ = getTotalRequestsPerMonthAugust(8);
            _ = getTotalRequestsPerMonthSeptember(9);
            _ = getTotalRequestsPerMonthOct(10);
            _ = getTotalRequestsPerMonthNov(11);
            _ = getTotalRequestsPerMonthDec(12);
           // DisplayChart();
        }

        public void DisplayChart()
        {
            List<AreaOrdersCount> orderCounts;

            var entries = new List<ChartEntry>();

            orderCounts = new List<AreaOrdersCount>();
            orderCounts.Add(new AreaOrdersCount { Area = "January", OrderCount = 7 });
            orderCounts.Add(new AreaOrdersCount { Area = "February", OrderCount = 8 });
            orderCounts.Add(new AreaOrdersCount { Area = "March", OrderCount = 9 });
            orderCounts.Add(new AreaOrdersCount { Area = "April", OrderCount = 4 });
            orderCounts.Add(new AreaOrdersCount { Area = "May", OrderCount = 15 });
            orderCounts.Add(new AreaOrdersCount { Area = "June", OrderCount = 3 });
            orderCounts.Add(new AreaOrdersCount { Area = "July", OrderCount = 1 });
            orderCounts.Add(new AreaOrdersCount { Area = "August", OrderCount = 9 });
            orderCounts.Add(new AreaOrdersCount { Area = "September", OrderCount = 12 });
            orderCounts.Add(new AreaOrdersCount { Area = "October", OrderCount = Convert.ToInt32(jsoon) });
            orderCounts.Add(new AreaOrdersCount { Area = "November", OrderCount = 3 });
            orderCounts.Add(new AreaOrdersCount { Area = "December", OrderCount = 25 });


            foreach (var data in orderCounts)
            {
                Random ran = new Random();
                SKColor randomColor = SKColor.FromHsv(ran.Next(256), ran.Next(256), ran.Next(256));

                var entry = new ChartEntry(data.OrderCount)
                {
                    Label = data.Area,
                    ValueLabel = data.OrderCount.ToString(),
                    Color = randomColor

                };
                entries.Add(entry);

            }

            var lineChart = new LineChart()
            {
                Entries = entries,
                LabelTextSize = 25,
            };

            var donutChart = new DonutChart()
            {
                Entries = entries,
                LabelTextSize = 25,
            };

            var barChart = new BarChart()
            {
                Entries = entries,
                LabelTextSize = 25,
            };

            this.lineChart.Chart = lineChart;
            this.barChart.Chart = barChart;
            this.donutChart.Chart = donutChart;


        }
        public class AreaOrdersCount
        {
            public string Area { get; set; }
            public int OrderCount { get; set; }
        }

        private async Task<string> getTotalRequestsPerMonthJan(int month)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);
            var json = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Bookings/totRequestPerMonth/" + month);
            txtJan.Text = json;
            Debug.WriteLine(json);
            return json;
        }
        private async Task<string> getTotalRequestsPerMonthFeb(int month)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);
            var json = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Bookings/totRequestPerMonth/" + month);
            txtFeb.Text = json;
            Debug.WriteLine(json);
            return json;
        }

        private async Task<string> getTotalRequestsPerMonthMarch(int month)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);
            var json = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Bookings/totRequestPerMonth/" + month);
            txtMarch.Text = json;
            Debug.WriteLine(json);
            return json;
        }

        private async Task<string> getTotalRequestsPerMonthApril(int month)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);
            var json = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Bookings/totRequestPerMonth/" + month);
            txtApril.Text = json;
            Debug.WriteLine(json);
            return json;
        }

        private async Task<string> getTotalRequestsPerMonthMay(int month)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);
            var json = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Bookings/totRequestPerMonth/" + month);
            txtMay.Text = json;
            Debug.WriteLine(json);
            return json;
        }


        private async Task<string> getTotalRequestsPerMonthJune(int month)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);
            var json = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Bookings/totRequestPerMonth/" + month);
            txtJune.Text = json;
            Debug.WriteLine(json);
            return json;
        }

        private async Task<string> getTotalRequestsPerMonthJuly(int month)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);
            var json = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Bookings/totRequestPerMonth/" + month);
            txtJuly.Text = json;
            Debug.WriteLine(json);
            return json;
        }

        private async Task<string> getTotalRequestsPerMonthAugust(int month)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);
            var json = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Bookings/totRequestPerMonth/" + month);
            txtAug.Text = json;
            Debug.WriteLine(json);
            return json;
        }

        private async Task<string> getTotalRequestsPerMonthSeptember(int month)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);
            var json = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Bookings/totRequestPerMonth/" + month);
            txtSept.Text = json;
            Debug.WriteLine(json);
            return json;
        }


        private async Task<string> getTotalRequestsPerMonthOct(int month)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);
            var json = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Bookings/totRequestPerMonth/" + month);          
            txtOct.Text = json;
            //JObject jwtd = JsonConvert.DeserializeObject<JObject>(jsoon);
            Oct = int.Parse(txtOct.Text);
            Debug.WriteLine(Oct);
            return json;
        }

        private async Task<string> getTotalRequestsPerMonthNov(int month)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);
            var json = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Bookings/totRequestPerMonth/" + month);
            txtNov.Text = json;
            Debug.WriteLine(json);
            return json;
        }

        private async Task<string> getTotalRequestsPerMonthDec(int month)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);
            var json = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Bookings/totRequestPerMonth/" + month);
            txtDec.Text = json;
            Debug.WriteLine(json);
            return json;
        } 

        private async Task<string> gettotaljobdone()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);

            var json = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Bookings/JobsDonenumbers");
            //var content2 = await json.Content.ReadAsStringAsync();
            totalCompletedJobs.Text = json;
            Debug.WriteLine(json);
            return json;
        }

        private async Task<string> getallrequest()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);

            var json = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Bookings/bookingnumbers");
            // var content2 = await json.Content.ReadAsStringAsync();
            AllRequests.Text = json;
            Debug.WriteLine(json);
            return json;
        }


        private async Task<string> gettotalrequests()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);

            var json = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Bookings/bookingnumberstotal");
            //var content2 = await json.Content.ReadAsStringAsync();
            totalActiveRequests.Text = json;
            Debug.WriteLine(json);
            return json;
        }

        private async Task<string> getTotalRejectedJobs()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);

            var json = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Bookings/TotRejectedRequests");
            //var content2 = await json.Content.ReadAsStringAsync();
            totalRejectedJobs.Text = json;
            Debug.WriteLine(json);
            return json;
        }


        private void Button_Clicked(object sender, EventArgs e)
        {



        }
    }
}