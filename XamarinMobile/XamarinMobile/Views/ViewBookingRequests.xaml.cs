using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMobile.Models;
using XamarinMobile.ViewModels;

namespace XamarinMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewBookingRequests : ContentPage
    {
        public ViewBookingRequests()
        {
            InitializeComponent();
            BindingContext = new MyListPageViewModel();
        }

        private async void OnItemSelected(Object sender, ItemTappedEventArgs e)
        {
            var mydetails = e.Item as MyListModel;
            await Navigation.PushAsync(new MyListPageDetail(mydetails.Name, mydetails.Ingredients, mydetails.Image));

        }


    }
}