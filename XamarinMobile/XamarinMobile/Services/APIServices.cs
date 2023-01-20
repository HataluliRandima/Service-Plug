using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Shapes;
using XamarinMobile.dto;
using XamarinMobile.Models;
using static Android.Resource;
using String = Android.Resource.String;

namespace XamarinMobile.Services
{
    public class APIServices
    {

        //static HttpClient client11 = new HttpClient();

        public object DefaultRequestHeaders { get; private set; }
        public async Task<bool> registerAsync(string merchName, string merchSurname, string merchEmail, string merchPassword, string merchType, string merchAddress, string merchCity, string merchProvince, string merchContactdetails)
        {
            var client = new HttpClient();

            var model = new MerchantRegisterDTO
            {
                MerchName = merchName,
                MerchSurname = merchSurname,
                MerchEmail = merchEmail,
                MerchPassword = merchPassword,
                MerchType = merchType,
                MerchAddress = merchAddress,
                MerchCity = merchCity,
                MerchProvince = merchProvince,
                MerchContactdetails = merchContactdetails
            };
            var json = JsonConvert.SerializeObject(model);

            HttpContent content = new StringContent(json);

            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await client.PostAsync("https://spfinalapi.azurewebsites.net/api/Merchants/Merchantregister", content);
            return response.IsSuccessStatusCode;
        }
        public async Task<string> LoginAsync(string merchEmail, string merchPassword)
        {
            var client = new HttpClient();

            var model = new MerchantLoginDTO
            {
                MerchEmail = merchEmail,
                MerchPassword = merchPassword
            };
            var json = JsonConvert.SerializeObject(model);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await client.PostAsync("https://spfinalapi.azurewebsites.net/api/Merchants/merchantlogin", content);
            var content2 = await response.Content.ReadAsStringAsync();
            JObject jwtd = JsonConvert.DeserializeObject<JObject>(content2);
            var token = jwtd.Value<string>("token");
            Debug.WriteLine(token);
            return token;
        }
        public  async Task<List<RequestsModel>> GetRequestsAsync(string Token)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
            var json = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Bookings/bookingnot");
            var requests = JsonConvert.DeserializeObject<List<RequestsModel>>(json);

            //mine for testing now 
            JArray jwtd = JsonConvert.DeserializeObject<JArray>(json);
            Debug.WriteLine(jwtd);

            foreach (var f in jwtd)
            {
                int token11 = f.Value<int>("userId");

                Debug.WriteLine(token11);
                   await  getclientAsync(token11);
                var json12 = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Users/Users/" + token11);

                Debug.WriteLine(json12);
            }
            return requests;
        }

        public async Task<List<RequestsModel>> GetActiveRequestsAsync(string Token)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
            var json = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Bookings/booking");
            var requests = JsonConvert.DeserializeObject<List<RequestsModel>>(json);
            return requests;
        }
        public async Task<List<JobsStartedModel>> GetJobsStartedAsync(string Token)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
            var json = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Jobs/getjobnbymerchant");
            var requests = JsonConvert.DeserializeObject<List<JobsStartedModel>>(json);
           // var content2 = await requests.Content.ReadAsStringAsync();
           JArray jwtd = JsonConvert.DeserializeObject<JArray>(json);
            Debug.WriteLine(jwtd);
            List<ClientDetail> jobs = new List<ClientDetail>();
            foreach (var f in jwtd)
            {
                int token11 = f.Value<int>("userId");
                Debug.WriteLine(token11);
                   await  getclientAsync(token11);
                var json12 = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Users/Users/" + token11);
                JObject jwtddd = JsonConvert.DeserializeObject<JObject>(json12);

                
                var username = jwtddd.Value<string>("userName");
                var surname = jwtddd.Value<string>("userSurname");
                var useremail = jwtddd.Value<string>("userEmail");
                var userAddress = jwtddd.Value<string>("userAddress");
                var userContDet = jwtddd.Value<string>("userContactdetails");
                Debug.WriteLine(username);
                Debug.WriteLine(json12);
            }
            //var token1 = jwtd.Value<string>("JobStatus");
            //Debug.WriteLine(token1);
       //     int token = jwtd.Value<int>("userId");
           //var name = jwtd.Value<int>("userId");
          // var name = 
            Debug.WriteLine(json);
          //  Debug.WriteLine(token);
            Debug.WriteLine(jwtd);
            Debug.WriteLine(requests);  

            return requests ;


           // return jwtd;
        }

        public async Task<string> getclientAsync(int id)
        {
            var client = new HttpClient();
            var json = await client.GetStringAsync("https://spfinalapi.azurewebsites.net/api/Users/Users/" + id);

            Debug.WriteLine(json);
            //var bookss = JsonConvert.DeserializeObject<string>(json);

            return json;
        }

        //public async Task<List<Requests>> GetRequestsAsync(string Token)
        //{
        //    var client = new HttpClient();
        //    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
        //    var json =  await client.GetStringAsync("https://localhost:7296/api/Bookings/bookingnot");
        //    var requests = JsonConvert.DeserializeObject<List<Requests>>(json);
        //    return requests; 
        //}
    }
}
