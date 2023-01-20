using Plugin.XamarinFormsSaveOpenPDFPackage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System.Diagnostics;
using static Android.Media.Session.MediaSession;
using System.Net.Http.Headers;

using XamarinMobile.Helper;

using Android.Provider;
using Settings = XamarinMobile.Helper.Settings;
using Newtonsoft.Json;
using XamarinMobile.dto;

namespace XamarinMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PDFUpload : ContentPage
    {
        private MediaFile _mediaFile;
        public PDFUpload()
        {
            InitializeComponent();
        }
        //private async void imageUpload_Clicked(object sender, EventArgs e)
        //{
        //    await CrossMedia.Current.Initialize();

        //    if (!CrossMedia.Current.IsTakePhotoSupported)
        //    {
        //        await DisplayAlert("No PickPhoto", ":(No PickPhoto available.)", "OK");
        //        return;
        //    }

        //    _mediaFile = await CrossMedia.Current.PickPhotoAsync();

        //    if (_mediaFile == null)
        //        return;

        //    FileImage.Source = ImageSource.FromStream(() =>
        //    {
        //        return _mediaFile.GetStream();
        //    });
        //}



        



        private async void Upload(object sender, EventArgs e)
        {
            //  var content = new MultipartFormDataContent();

            //  content.Add(new StreamContent(_mediaFile.GetStream()), "\"file\"", $"\"{_mediaFile.Path}\"");
            //  var httpClient = new HttpClient();
            ////  var client = new HttpClient();
            //  httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);

            //  var uploadServiceBaseAddress = "http://frenkie-001-site1.ctempurl.com/api/Files/uploadfile";
            //  var httpResponseMessage = await httpClient.PutAsync(uploadServiceBaseAddress, content);

            //  var content2 = await httpResponseMessage.Content.ReadAsStringAsync();

            //  Debug.WriteLine(content2);

            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.token);

            var model = new Verification
            {
                merchIdnumber = IDNumber.Text,
                merchTaxNumber = emailPlaceholder.Text,
                
            };
            var json = JsonConvert.SerializeObject(model);

            HttpContent content = new StringContent(json);

            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await client.PutAsync("https://spfinalapi.azurewebsites.net/api/Merchants/editmerchant" , content);
            var content2 = await response.Content.ReadAsStringAsync();

            Debug.WriteLine(content2);
            await DisplayAlert("Verification", "Successfully uploaded verification details", "ok");
            Navigation.PushAsync(new FlyoutHome());

            //if (httpResponseMessage.IsSuccessStatusCode)
            //{
            //    await DisplayAlert("Success", "Upload sucessful", "OK");
            //}
            //else
            //{
            //    await DisplayAlert("Failure", "Upload failed", "OK");
            //}
        }     
    }
}