using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMobile.Services;

using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using XamarinMobile.Views;
using System.Net.Http;

namespace XamarinMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Scheduling2 : ContentPage
    {
        private APIServices aPIServices = new APIServices();
        public Scheduling2()
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
    }
}